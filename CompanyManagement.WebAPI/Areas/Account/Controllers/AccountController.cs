using CompanyManagement.Dtos.Account;
using Microsoft.AspNetCore.Authentication;

namespace CompanyManagement.WebAPI.Areas.Account.Controllers
{
    [Area("Account")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public AccountController(IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        [HttpPost("api/[controller]/Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            await _signInManager.SignInAsync(user, isPersistent: false);
            var accessToken = HttpContext.Request.Cookies;
            return Ok(_mapper.Map<UserDto>(user));
        }

        [HttpGet("api/[controller]/GetToken")]
        public async Task<IActionResult> GetToken()
        {
            var accessToken = HttpContext.Request.Cookies;
            return Ok(accessToken);
        }

        [HttpPost("api/[controller]/Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok("Başarı ile çıkış yapıldı.");
        }

        [HttpPut("api/[controller]/ChangePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto changePasswordDto)
        {
            var user = await _userManager.FindByIdAsync(changePasswordDto.UserId.ToString());
            await _userManager.ChangePasswordAsync(user, changePasswordDto.CurrentPassword, changePasswordDto.NewPassword);
            return Ok("Başarı ile çıkış yapıldı.");
        }

        //[HttpPost("api/[controller]/ResetPassword")]
        //public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        //{
        //    var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
        //    var resetPasswordToken = await _userManager.GeneratePasswordResetTokenAsync(user);
        //    EmailSenderHelper.SendEmail(user.FirstName + user.LastName, resetPasswordToken, resetPasswordDto.RecoveryEmail);
        //}
    }
}

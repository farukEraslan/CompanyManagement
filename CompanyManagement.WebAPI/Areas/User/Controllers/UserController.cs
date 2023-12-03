using CompanyManagement.Business.Concrete;
using CompanyManagement.Core.Utilities.Results;
using CompanyManagement.Dtos.UserDto;
using CompanyManagement.Entities.Enum;

namespace CompanyManagement.WebAPI.Areas.User.Controllers
{
    [Area("User")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<UserEntity> _userManager;

        public UserController(IMapper mapper, UserManager<UserEntity> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost("api/[controller]/Create")]
        public async Task<IActionResult> Create(UserCreateDto userCreateDto)
        {
            var user = await _userManager.FindByNameAsync(userCreateDto.Username);
            if (user != null)
            {
                return BadRequest("Kullanıcı zaten var.");
            }
            var newUser = _mapper.Map<UserEntity>(userCreateDto);
            var result = await _userManager.CreateAsync(newUser);
            return result.Succeeded ? Ok("Kullanıcı başarı ile oluşturuldu.") : BadRequest("Kullanıcı oluşturulurken bir hata oluştu.");
        }

        [HttpPut("api/[controller]/Update")]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var user = await _userManager.FindByIdAsync(userUpdateDto.Id.ToString());
            if (user == null)
            {
                return BadRequest("Kullanıcı bulunamadı.");
            }
            var updatedUser = _mapper.Map(userUpdateDto,user);
            var result = _userManager.UpdateAsync(updatedUser);
            return result.Result == IdentityResult.Success ? Ok("Kullanıcı başarı ile güncellendi.") : BadRequest("Kullanıcı Güncellenemedi.");
        }

        [HttpDelete("api/[controller]/Delete")]
        public async Task<IActionResult> Delete(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                return BadRequest("Kullanıcı bulunamadı.");
            }
            var result = await _userManager.DeleteAsync(user);
            return result.Succeeded ? Ok("Kullanıcı başarı ile silindi.") : BadRequest("Kullanıcı silinirken bir hata oluştu.");
        }

        [HttpGet("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var users = _userManager.Users.ToList();
            return users != null ? Ok(users) : BadRequest(users);
        }

    }
}

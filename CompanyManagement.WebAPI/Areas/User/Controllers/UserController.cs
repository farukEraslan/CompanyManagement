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
            var result = await _userManager.CreateAsync(_mapper.Map<UserEntity>(userCreateDto), userCreateDto.Password);
            return result.Succeeded == true ? Ok(result) : BadRequest(result);
        }

        [HttpPut("api/[controller]/Update")]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var user = await _userManager.FindByIdAsync(userUpdateDto.Id.ToString());
            if (user == null)
            {
                return BadRequest("Kullanıcı bulunamadı.");
            }
            var result = await _userManager.UpdateAsync(_mapper.Map(userUpdateDto, user));
            return result.Succeeded == true ? Ok(result) : BadRequest(result);
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
            return result.Succeeded == true ? Ok(result) : BadRequest(result);
        }
    }
}

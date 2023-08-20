using AutoMapper;
using CompanyManagement.Dtos.UserDto;
using CompanyManagement.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

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
            var result = _userManager.CreateAsync(_mapper.Map<UserEntity>(userCreateDto), userCreateDto.Password);
            return result.IsCompletedSuccessfully == true ? Ok(result.ToString()) : BadRequest(result.ToString());
        }
    }
}

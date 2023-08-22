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
        private readonly AccountManager _accountManager;

        public UserController(IMapper mapper, AccountManager accountManager)
        {
            _mapper = mapper;
            _accountManager = accountManager;
        }

        [HttpPost("api/[controller]/Create")]
        public async Task<IActionResult> Create(UserCreateDto userCreateDto)
        {
            var result = await _accountManager.CreateAsync(userCreateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [HttpPut("api/[controller]/Update")]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var result = await _accountManager.UpdateAsync(userUpdateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("api/[controller]/Delete")]
        public async Task<IActionResult> Delete(Guid userId)
        {
            var result = await _accountManager.DeleteAsync(userId);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [HttpGet("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _accountManager.GetAllAsync();
            return users == null ? Ok(users) : BadRequest(users);
        }

    }
}

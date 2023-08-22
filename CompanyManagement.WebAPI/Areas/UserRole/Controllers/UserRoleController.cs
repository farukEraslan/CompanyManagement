using CompanyManagement.Business.Concrete;
using CompanyManagement.Core.Utilities.Results;
using CompanyManagement.Dtos.UserRole;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.WebAPI.Areas.UserRole.Controllers
{
    [Area("UserRole")]
    [ApiController]
    public class UserRoleController : Controller
    {
        private readonly UserRoleManager _userRoleManager;

        public UserRoleController(UserRoleManager userRoleManager)
        {
            _userRoleManager = userRoleManager;
        }

        [HttpPost("api/[controller]/GiveRole")]
        public async Task<IActionResult> GiveRole(UserRoleCreateDto userRoleCreateDto)
        {
            var result = await _userRoleManager.CreateAsync(userRoleCreateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.WebAPI.Areas.Account.Controllers
{
    [Area("Account")]
    [ApiController]
    public class AccountController : Controller
    {
        [HttpPost("api/[controller]/Login")]
        public async Task<IActionResult> Login()
        {
            return null;
        }
    }
}

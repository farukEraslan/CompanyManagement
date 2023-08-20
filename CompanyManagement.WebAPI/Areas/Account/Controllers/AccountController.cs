using AutoMapper;
using CompanyManagement.Core.Utilities.Results;
using CompanyManagement.Dtos.Account;
using CompanyManagement.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.WebAPI.Areas.Account.Controllers
{
    [Area("Account")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public AccountController(IMapper mapper, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        [HttpPost("api/[controller]/Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            await _signInManager.SignInAsync(user, isPersistent: false);
            return Ok("Başarı ile giriş yapıldı.");
        }
    }
}

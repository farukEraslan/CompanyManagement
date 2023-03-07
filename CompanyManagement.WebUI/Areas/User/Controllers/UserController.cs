using CompanyManagement.Entities.Concrete;
using CompanyManagement.WebUI.Areas.User.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.WebUI.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public UserController()
        {

        }

        [HttpGet("{area}/Register")]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost("{area}/Register")]
        public async Task<IActionResult> Register(UserVM user)
        {
            if (ModelState.IsValid)
            {
                var newUser = new UserEntity();
                newUser.UserName = user.UserName;
                newUser.Email = user.Email;
                newUser.PhoneNumber = user.PhoneNumber;

                var result = await _userManager.CreateAsync(newUser, user.Password);

                if (result.Succeeded)
                {
                    ModelState.AddModelError(nameof(UserVM.ErrorMessage), "Personel başarılı bir şekilde eklendi.");
                }
                else if (!result.Succeeded)
                {
                    ModelState.AddModelError(nameof(UserVM.ErrorMessage), "Personel eklenirken bir hata oluştu.");
                }
            }
            return View();
        }

        [HttpGet("{area}/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("{area}/Login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, login.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    ModelState.AddModelError(nameof(LoginDTO.ErrorMessage), "Email veya şifre hatalı. Lütfen kontrol ediniz.");
                    return View(login);
                }
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "User", new { area = "User" });
        }

        public IActionResult AccessDenied()
        { 
            return View(); 
        }

    }
}

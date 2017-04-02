using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using GeekPlatform.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Profile> _userManager;
        private readonly SignInManager<Profile> _signInManager;

        public AccountController(UserManager<Profile> userManager, GeekDatabaseContext dbContext, SignInManager<Profile> signInManager) : base(userManager, dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Login(string email, string password)
        {
            if (String.IsNullOrEmpty(email))
            {
                return View();
            }

            Profile user = await _userManager.FindByEmailAsync(email);
            if (user == null || !user.IsActive)
            {
                return View();
            }

            var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);

            if (!signInResult.Succeeded)
            {
                return View();
            }

            return Redirect("/");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }
    }
}

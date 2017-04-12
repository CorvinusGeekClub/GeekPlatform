using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using GeekPlatform.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class HomeController : ControllerBase
    {
        public HomeController(UserManager<Profile> userManager, GeekDatabaseContext dbContext) : base(userManager, dbContext)
        {
        }

        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }

    }
}

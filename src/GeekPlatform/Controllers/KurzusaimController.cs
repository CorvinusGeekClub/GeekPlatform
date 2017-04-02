using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class KurzusaimController : ControllerBase
    {
        // GET: /<controller>/
        public KurzusaimController(UserManager<Profile> userManager) : base(userManager)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

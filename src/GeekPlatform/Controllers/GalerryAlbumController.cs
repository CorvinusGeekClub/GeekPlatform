using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GeekPlatform.Controllers
{
    public class GalerryAlbumController : ControllerBase
    {
        public GalerryAlbumController(UserManager<Profile> userManager, GeekDatabaseContext dbContext) : base(userManager, dbContext)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
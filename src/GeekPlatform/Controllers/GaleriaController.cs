using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using GeekPlatform.Models;

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class GaleriaController : ControllerBase
    {
        public GaleriaController(UserManager<Profile> userManager, GeekDatabaseContext dbContext) : base(userManager, dbContext)
        {
        }

        public IActionResult Index()
        {
            return
                Redirect(
                    "https://photos.google.com/share/AF1QipN6kywYu5mSfr66frMQ6tea4kwPhmkC_PxCyiLgTbUK1rMWpKlDtUma_wbGeRc39g?key=cE5wMXdoR1J6UGJVZG9NQ051UTF1Y2phazBNM3F3");
        }

        public IActionResult Albumok()
        {
            return NotFound();
        }
    }
}
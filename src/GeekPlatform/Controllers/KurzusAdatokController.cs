using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using GeekPlatform.ViewModels.KurzusAdatok;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class KurzusAdatokController : ControllerBase
    {
        // GET: /<controller>/
        public KurzusAdatokController(UserManager<Profile> userManager, GeekDatabaseContext dbContext) : base(userManager, dbContext)
        {
        }

        public IActionResult Aktiv()
        {
            return View();
        }

        // GET: /KurzusAdatok/Passziv/id
        public IActionResult Passziv(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }

            Course kurzus = DbContext.Course.Where(c => c.IsActive && !c.IsRunning && c.CourseId == id).FirstOrDefault();

            if (kurzus == null)
            {
                return NotFound();
            }

            IEnumerable<CourseEnrollment> jelentkezesek = DbContext.CourseEnrollment
                .Include(ce => ce.Course)
                .Include(ce => ce.Profile);            
            IEnumerable<CourseThematics> tematika = DbContext.CourseThematics;
            KurzusAdatokViewModel viewModel = new KurzusAdatokViewModel(kurzus, jelentkezesek, tematika);
            return View(viewModel);

        }
    }
}

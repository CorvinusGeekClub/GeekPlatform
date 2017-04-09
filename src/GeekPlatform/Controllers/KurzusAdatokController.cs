using System;
using System.Collections;
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

            Course kurzus = DbContext.Course
                .Include(c => c.CourseEnrollment).ThenInclude(ce => ce.Profile)
                .Include(c => c.CourseThematics)
                .FirstOrDefault(c => c.IsActive && !c.IsRunning && c.CourseId == id);

            if (kurzus == null)
            {
                return NotFound();
            }
            
            IEnumerable<CourseThematics> tematika = DbContext.CourseThematics;
            KurzusAdatokViewModel viewModel = new KurzusAdatokViewModel
            {
                Nev = kurzus.CourseName,
                Leiras = kurzus.DescriptionLong,
                Oktatok = kurzus.CourseEnrollment
                    .Where(enrollment => enrollment.IsInstructor)
                    .Select(p => p.Profile)
                    .ToList()
                    .Select(o => new OktatoViewModel
                    {
                        Nev = o.Name,
                        EMail = o.Email,
                        Pozicio = o.Workplace,
                        Telefon = o.PhoneNumber
                    }),
                KurzusTematika = kurzus.CourseThematics
                    .ToList()
                    .Select(t => new KurzusTematikaViewModel
                    {
                        Datum = t.ActualDate.ToString("d"),
                        Het = t.WeekNumber,
                        Leiras = t.Description
                    })
            };
            return View(viewModel);

        }
    }
}

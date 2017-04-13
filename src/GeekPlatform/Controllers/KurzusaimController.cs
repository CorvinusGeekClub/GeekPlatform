using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using GeekPlatform.ViewModels.Kurzusaim;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class KurzusaimController : ControllerBase
    {
        // GET: /<controller>/
        public KurzusaimController(UserManager<Profile> userManager, GeekDatabaseContext dbContext) : base(userManager, dbContext)
        {
        }

        public IActionResult Index()
        {
            IEnumerable<Course> kurzusok = DbContext.Course
                .Include(t => t.CourseThematics)
                .Include(e => e.CourseEnrollment)
                .ThenInclude(p => p.Profile)
                .Where(c => c.IsActive && c.CourseEnrollment.Any(e => e.Profile == User));

            IEnumerable<Course> aktivKurzusok = kurzusok.Where(c => c.IsRunning).ToList();
           
            IEnumerable<Course> passzivKurzusok = kurzusok.Where(c => !c.IsRunning).ToList();

            KurzusaimViewModel vm = new KurzusaimViewModel
            {
                AktivKurzusok = aktivKurzusok.Select(c => new KurzusViewModel
                {
                    AktualisTematika = new KurzusTematikaViewModel
                    {
                        Datum = c.CourseThematics.LastOrDefault(t => t.ActualDate < DateTime.Now)?.ActualDate.ToString("g"),
                        Temakor = c.CourseThematics.LastOrDefault(t => t.ActualDate < DateTime.Now)?.Title
                    },
                    KovetkezoTematika = new KurzusTematikaViewModel
                    {
                        Datum = c.CourseThematics.LastOrDefault(t => t.ActualDate > DateTime.Now)?.ActualDate.ToString("g"),
                        Temakor = c.CourseThematics.LastOrDefault(t => t.ActualDate > DateTime.Now)?.Title
                    },
                    Leiras = c.DescriptionLong,
                    Nev = c.CourseName,
                    Id = c.CourseId
                }),
                PasszivKurzusok = passzivKurzusok.Select(c => new KurzusViewModel
                {
                    Leiras = c.DescriptionLong,
                    Nev = c.CourseName,
                    Id = c.CourseId,
                })
            };

            return View(vm);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using GeekPlatform.Models;
using GeekPlatform.ViewModels.Jelentkezes;




// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class JelentkezesController : ControllerBase
    {
        public JelentkezesController(UserManager<Profile> userManager, GeekDatabaseContext dbContext) : base(userManager, dbContext)
        {
        }

        // GET: /<controller>/
        public IActionResult Index(bool enrolled)
        {
            var vm = new JelentkezesViewModel
            {
                Courses = DbContext.Course
                    .Include(c => c.CourseEnrollment)
                    .ThenInclude(enr => enr.Profile)
                    .Where(s => s.IsActive && s.SignUpDeadline > DateTime.Now)
                    .ToList()
                    .Select(c => new CourseViewModel
                    {
                        CourseName = c.CourseName,
                        Instructor =
                            string.Join(", ", c.CourseEnrollment.Where(d => d.IsInstructor).Select(d => d.Profile.Name)),
                        ImgUrl = c.IconFileName,
                        Description = c.DescriptionShort,
                        CourseId = c.CourseId,
                        IsWorkshop = c.IsWorkshop,
                        IsEnrolled = c.CourseEnrollment.Any(a => a.Profile == User)
                    }),
                Enrolled = enrolled
            };
            return View(vm);
        }

        public IActionResult Jelentkezes(int Id)
        {
            DbContext.CourseEnrollment.Add(new CourseEnrollment()
                {
                    ProfileId = User.Id,
                    CourseId = Id,
                    IsInstructor = false
                });
            DbContext.SaveChanges();
            return Redirect("/Jelentkezes/?enrolled=true");
        }
    }
}

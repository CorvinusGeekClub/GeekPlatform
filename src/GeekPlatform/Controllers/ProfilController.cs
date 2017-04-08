using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using GeekPlatform.ViewModels.Profil;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class ProfilController : ControllerBase
    {
        // GET: /<controller>/
        public ProfilController(UserManager<Profile> userManager, GeekDatabaseContext dbContext) : base(userManager, dbContext)
        {
        }

        public IActionResult Index()
        {
            ProfilViewModel pv = new ProfilViewModel(
                DbContext.Profile
                    .Include(p => p.CourseEnrollment).ThenInclude(ce => ce.Course)
                    .Include(p => p.MemberCompetency).ThenInclude(mc => mc.Competency)
                    .First(p => p == User)
                );
            return View(pv);

        }
    }
}

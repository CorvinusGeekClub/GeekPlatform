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
        public ProfilController(UserManager<Profile> userManager, GeekDatabaseContext dbContext)
            : base(userManager, dbContext)
        {
        }

        public IActionResult Index()
        {
            ProfilViewModel pv = CreateVM(null);
            return View(pv);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(int id,  ProfilViewModel vm)
        {
            return Redirect($"/Profil/{nameof(Edit)}/{vm.Nev}");
        }
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var vm = CreateVM(id);
            return View(vm);

        }

        private ProfilViewModel CreateVM(int? id)
        {
            var user = DbContext.Profile
                            .Include(p => p.CourseEnrollment).ThenInclude(ce => ce.Course)
                            .Include(p => p.MemberCompetency).ThenInclude(mc => mc.Competency)
                            .First(p => p.Id == (id ?? User.Id));

            var kurzusok = user.CourseEnrollment.Where(ce => ce.Course.IsActive).ToList();

            ProfilViewModel pv = new ProfilViewModel
            {
                Nev = user.Name,
                PozicioTeamTagsag = user.TeamMember,
                TagsagKezdete = user.MembershipStart,
                Munkahely = user.Workplace,
                Email = user.Email,
                Slack = user.Slack,
                TartozkodasiHely = user.Address,
                Ajandek = user.Birthday,
                Telefonszam = user.PhoneNumber,
                Skype = user.Skype,
                AktivKurzus =
                    kurzusok.Where(ce => ce.Course.IsRunning)
                        .Select(ce => new KurzusViewModel { KurzusNev = ce.Course.CourseName }),
                ElvegezettKurzus =
                    kurzusok.Where(ce => !ce.Course.IsRunning)
                        .Select(ce => new KurzusViewModel { KurzusNev = ce.Course.CourseName }),
                Kompetencia =
                    user.MemberCompetency.Select(
                        mc =>
                            new KompetenciaViewModel
                            {
                                KompetenciaNev = mc.Competency.CompetencyName,
                                KompetenciaSzint = mc.CompetencyLvl
                            })
            };
            return pv;
        }
    }
}

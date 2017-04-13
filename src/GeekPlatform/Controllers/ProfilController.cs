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


        public IActionResult Index(int? id)

        {
            ProfilViewModel pv = CreateVm(id);
            return View(pv);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProfilViewModel vm)
        {
            var userToEdit = GetProfileById(id);

            userToEdit.Name = vm.Nev;
            // todo: Membership start
            userToEdit.Workplace = vm.Munkahely;
            userToEdit.Email = vm.Email;
            userToEdit.Slack = vm.Slack;
            userToEdit.Address = vm.TartozkodasiHely;
            userToEdit.Birthday = vm.Ajandek;
            userToEdit.PhoneNumber = vm.Telefonszam;
            userToEdit.Skype = vm.Skype;

            DbContext.SaveChanges();

            return Redirect($"/Profil/Index/{vm.Id}");
        }

        public IActionResult Edit(int? id)
        {
            var vm = CreateVm(id);
            return View(vm);
        }

        private ProfilViewModel CreateVm(int? id)
        {
            var user = GetProfileById(id ?? User.Id);

            var kurzusok = user.CourseEnrollment.Where(ce => ce.Course.IsActive).ToList();

            ProfilViewModel pv = new ProfilViewModel
            {
                Id = user.Id,
                Nev = user.Name,
                PozicioTeamTagsag = user.TeamMember,
                TagsagKezdete = user.MembershipStart.ToString("Y"),
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

        private Profile GetProfileById(int id)
        {
            return DbContext.Profile
                .Include(p => p.CourseEnrollment).ThenInclude(ce => ce.Course)
                .Include(p => p.MemberCompetency).ThenInclude(mc => mc.Competency)
                .First(p => p.Id == id);
        }
    }
}

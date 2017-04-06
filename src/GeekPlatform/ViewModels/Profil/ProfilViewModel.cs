using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;

namespace GeekPlatform.ViewModels.Profil
{
    public class ProfilViewModel : ViewModelBase
    {
        public ProfilViewModel(Profile user) : base(user)
        {
            Nev = user.Name;
            PozicioTeamTagsag = user.TeamMember;
            TagsagKezdete = user.MembershipStart;
            /*TagsagVege =user.*/
            Munkahely = user.Workplace;
            Email = user.Email;
            Slack = user.Slack;
            TartozkodasiHely = user.Address;
            Ajandek = user.Birthday;
            Telefonszam = user.PhoneNumber;
            Skype = user.Skype;
            Aktiv = user.CourseEnrollment.Select(ce => new KurzusViewModel(ce.Course));
            ElvegezettKurzus = user.CourseEnrollment.Select(ce => new KurzusViewModel(ce.Course));
            Kompetencia = user.MemberCompetency.Select(mc => new KompetenciaViewModel(mc));
        }

        public string Nev { get; }
        public string PozicioTeamTagsag {get;}
        public DateTime TagsagKezdete { get; }
        public DateTime TagsagVege { get; }
        public string Munkahely { get; }
        public string Email { get; }
        public string Slack { get; }
        public string TartozkodasiHely { get;}
        public DateTime? Ajandek { get; }
        public string Telefonszam { get; }
        public string Skype { get; } 

        public IEnumerable<KurzusViewModel> Aktiv { get; }
        public IEnumerable<KurzusViewModel> ElvegezettKurzus { get; }

        public IEnumerable<KompetenciaViewModel> Kompetencia { get; }
    }
}

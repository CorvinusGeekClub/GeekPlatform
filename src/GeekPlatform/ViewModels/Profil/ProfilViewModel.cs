using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;

namespace GeekPlatform.ViewModels.Profil
{
    public class ProfilViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string PozicioTeamTagsag {get; set; }
        public DateTime TagsagKezdete { get; set; }
        public DateTime TagsagVege { get; set; }
        public string Munkahely { get; set; }
        public string Email { get; set; }
        public string Slack { get; set; }
        public string TartozkodasiHely { get; set; }
        public DateTime? Ajandek { get; set; }
        public string Telefonszam { get; set; }
        public string Skype { get; set; } 

        public IEnumerable<KurzusViewModel> AktivKurzus { get; set; }
        public IEnumerable<KurzusViewModel> ElvegezettKurzus { get; set; }

        public IEnumerable<KompetenciaViewModel> Kompetencia { get; set; }
    }
}

using GeekPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.KurzusAdatok
{
    public class OktatoViewModel
    {
        public String Nev { get; }
        public String Pozicio { get; }
        public String EMail { get; }
        public String Telefon { get; }

        public OktatoViewModel(Profile profile)
        {
            Nev = profile.Name;
            Pozicio = profile.Workplace;
            EMail = profile.Email;
            Telefon = profile.PhoneNumber;
        }
    }
}

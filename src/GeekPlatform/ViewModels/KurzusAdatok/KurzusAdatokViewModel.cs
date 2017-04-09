using GeekPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekPlatform.ViewModels.KurzusAdatok
{
    public class KurzusAdatokViewModel : ViewModelBase
    {
        public String Nev { get; set; }
        public String Leiras { get; set; }
        public IEnumerable<OktatoViewModel> Oktatok { get; set; }
        public IEnumerable<KurzusTematikaViewModel> KurzusTematika { get; set; }
    }
}

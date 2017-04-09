using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;

namespace GeekPlatform.ViewModels.Kurzusaim
{
    public class KurzusaimViewModel : ViewModelBase
    {
        public IEnumerable<KurzusViewModel> AktivKurzusok { get; set; }
        public IEnumerable<KurzusViewModel> PasszivKurzusok { get; set; }
    }
}

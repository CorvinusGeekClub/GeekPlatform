using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;

namespace GeekPlatform.ViewModels.Kurzusaim
{
    public class KurzusaimViewModel : ViewModelBase
    {
        public IEnumerable<KurzusViewModel> AktivKurzusok { get; }
        public IEnumerable<KurzusViewModel> PasszivKurzusok { get; }

        public KurzusaimViewModel(IEnumerable<Course> aktivKurzusok, IEnumerable<Course> passzivkurzusok)
        {
                AktivKurzusok = aktivKurzusok.Select(a => new KurzusViewModel(a)).ToList();
                PasszivKurzusok = passzivkurzusok.Select(p => new KurzusViewModel(p)).ToList();
        }
    }
}

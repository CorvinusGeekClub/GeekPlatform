using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.KurzusAdatok
{
    public class KurzusAdatokViewModel
    {
        public String KurzusNev { get; }
        public IEnumerable<OktatoViewModel> Oktatok { get; }
        public String KurzusLeiras { get; }
        public IEnumerable<KurzusTematikaViewModel> Tematika { get; }
    }
}

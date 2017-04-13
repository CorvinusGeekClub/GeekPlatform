using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.Kurzusaim
{
    public class KurzusViewModel
    {
        public String Nev { get; set; }
        public String Leiras { get; set; }
        public KurzusTematikaViewModel AktualisTematika { get; set; }
        public KurzusTematikaViewModel KovetkezoTematika { get; set; }
        public int Id { get; set; }

    }
}

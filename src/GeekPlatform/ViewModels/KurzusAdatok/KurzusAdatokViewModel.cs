using GeekPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.KurzusAdatok
{
    public class KurzusAdatokViewModel
    {
        

        public String Nev { get; }
        public IEnumerable<OktatoViewModel> Oktatok { get; }
        public String Leiras { get; }
        public IEnumerable<KurzusTematikaViewModel> Tematika { get; }

        public KurzusAdatokViewModel(Course kurzus)
        {
            Nev = kurzus.CourseName;
            IEnumerable<CourseEnrollment> oktatoresztvevok = kurzus.CourseEnrollment.Where(enrollment => enrollment.IsInstructor);
            IEnumerable<Profile> oktatok = oktatoresztvevok.Select(e => e.Profile);
            Oktatok = oktatok.Select(model => new OktatoViewModel(model));
            Leiras = kurzus.DescriptionLong;

        }
    }
}

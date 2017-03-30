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

        public KurzusAdatokViewModel(IEnumerable<Course> kurzusok)
        {
            Course kurzus = kurzusok.First(c => !c.IsRunning);
            Nev = kurzus.CourseName;
            IEnumerable<CourseEnrollment> oktatoResztvevok = kurzus.CourseEnrollment.Where(enrollment => enrollment.IsInstructor);
            IEnumerable<Profile> oktatok = oktatoResztvevok.Select(e => e.Profile);
            Oktatok = oktatok.Select(model => new OktatoViewModel(model));
            Leiras = kurzus.DescriptionLong;
            IEnumerable<CourseThematics> relevansTematika = kurzus.CourseThematics.Where(thematics => thematics.CourseId == kurzus.CourseId);
            Tematika = relevansTematika.Select(model => new KurzusTematikaViewModel(model));
        }
    }
}

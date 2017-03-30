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
        public String Nev { get; }
        public String Leiras { get; }
        public IEnumerable<OktatoViewModel> Oktatok { get; }
        public IEnumerable<KurzusTematikaViewModel> Tematikak { get; }

        public KurzusAdatokViewModel(Course kurzus, IEnumerable<CourseEnrollment> jelentkezesek)
        {
            Nev = kurzus.CourseName;
            Leiras = kurzus.DescriptionLong;
            IEnumerable<Profile> oktatoResztvevok = jelentkezesek
                .Where(enrollment => enrollment.IsInstructor
                    && enrollment.CourseId == kurzus.CourseId)
                .Select(p => p.Profile);
            Oktatok = oktatoResztvevok.Select(o => new OktatoViewModel(o)).ToList();
            // TODO: tematika
        }
    }
}

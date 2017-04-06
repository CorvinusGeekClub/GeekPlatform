using GeekPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.Kurzusaim
{
    public class KurzusViewModel
    {
        public String Nev { get; }
        public String Leiras { get; }
        public KurzusTematikaViewModel AktualisTematika { get; }
        public KurzusTematikaViewModel KovetkezoTematika { get; }

        public KurzusViewModel(Course kurzus)
        {
            Nev = kurzus.CourseName;
            Leiras = kurzus.DescriptionLong;

            CourseThematics aktualisTematika = kurzus.CourseThematics.Where(t => t.ActualDate < DateTime.Now).LastOrDefault();
            CourseThematics kovetkezoTematika = kurzus.CourseThematics.Where(t => t.ActualDate > DateTime.Now).FirstOrDefault();
            if (aktualisTematika != null)
            {
                AktualisTematika = new KurzusTematikaViewModel(aktualisTematika); 
            }
            if (kovetkezoTematika != null)
            {
                KovetkezoTematika = new KurzusTematikaViewModel(kovetkezoTematika); 
            }
        }
    }
}

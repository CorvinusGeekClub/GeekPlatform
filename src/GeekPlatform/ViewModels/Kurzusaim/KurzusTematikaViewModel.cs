using GeekPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.Kurzusaim
{
    public class KurzusTematikaViewModel
    {
        public String Temakor { get; }
        public String Datum { get; }

        public KurzusTematikaViewModel(CourseThematics tematika)
        {
            DateTime datum = tematika.ActualDate;

            Temakor = tematika.Title;
            Datum = datum.ToString("yyyy.MM.dd. H:mm");
        }
    }
}

using GeekPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.KurzusAdatok
{
    public class KurzusTematikaViewModel
    {
        public int Het { get; }
        /*public DateTime Datum { get; }*/
        public String Datum { get; }
        public String Leiras { get; }

        public KurzusTematikaViewModel(CourseThematics tematika)
        {
            this.Het = tematika.WeekNumber;
            //this.Datum = tematika.ActualDate;
            this.Datum = tematika.ActualDate.Year.ToString() + "." + tematika.ActualDate.Month.ToString("00") + "." + tematika.ActualDate.Day.ToString("00") + ".";
            this.Leiras = tematika.Description;
        }
    }
}

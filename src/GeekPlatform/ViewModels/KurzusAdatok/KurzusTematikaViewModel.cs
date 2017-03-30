﻿using GeekPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.KurzusAdatok
{
    public class KurzusTematikaViewModel
    {
        public int Het { get; }
        public DateTime Datum { get; }
        public String Leiras { get; }

        public KurzusTematikaViewModel(CourseThematics tematika)
        {
            this.Het = tematika.WeekNumber;
            this.Datum = tematika.ActualDate;
            this.Leiras = tematika.Description;
        }
    }
}
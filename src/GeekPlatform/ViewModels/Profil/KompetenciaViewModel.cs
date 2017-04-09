using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;

namespace GeekPlatform.ViewModels.Profil
{
    public class KompetenciaViewModel
    {
        public string KompetenciaNev { get; }
        public int KompetenciaSzint { get; }

        public KompetenciaViewModel(MemberCompetency m)
        {
            KompetenciaNev = m.Competency.CompetencyName;
            KompetenciaSzint = m.CompetencyLvl;
    }
        
    }
}

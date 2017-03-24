using System;
using System.Collections.Generic;

namespace GeekPlatform.Models
{
    public partial class Competency
    {
        public Competency()
        {
            MemberCompetency = new HashSet<MemberCompetency>();
        }

        public int CompetencyId { get; set; }
        public string CompetencyName { get; set; }

        public virtual ICollection<MemberCompetency> MemberCompetency { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GeekPlatform.Models
{
    public partial class MemberCompetency
    {
        public int MemberCompetencyId { get; set; }
        public int ProfileId { get; set; }
        public int CompetencyId { get; set; }
        public byte CompetencyLvl { get; set; }
        public string CompetencyComment { get; set; }

        public virtual Competency Competency { get; set; }
        public virtual Profile Profile { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekPlatform.Models
{
    public partial class MemberCompetency
    {

        public int MemberCompetencyId { get; set; }

        public int ProfileId { get; set; }

        public int CompetencyId { get; set; }

        public int CompetencyLvl { get; set; }

        [Required]
        public string CompetencyComment { get; set; }

        public virtual Competency Competency { get; set; }

        public virtual Profile Profile { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeekPlatform.Models
{
    public partial class Competency
    {
        public Competency()
        {
            MemberCompetency = new HashSet<MemberCompetency>();
        }

        public int CompetencyId { get; set; }

        [Required]
        [MaxLength(20)]
        public string CompetencyName { get; set; }

        public virtual ICollection<MemberCompetency> MemberCompetency { get; set; }
    }
}

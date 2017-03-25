using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekPlatform.Models
{
    public partial class Profile
    {
        public Profile()
        {
            CourseEnrollment = new HashSet<CourseEnrollment>();
            HomeworkUpload = new HashSet<HomeworkUpload>();
            MemberCompetency = new HashSet<MemberCompetency>();
        }

        public int ProfileId { get; set; }

        public string Name { get; set; }

        public string PicFileName { get; set; }

        public string TeamMember { get; set; }

        public DateTime MembershipStart { get; set; }

        public int UniStartYear { get; set; }

        public string Major { get; set; }

        public string Workplace { get; set; }
        
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Slack { get; set; }

        public string Skype { get; set; }
        
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<CourseEnrollment> CourseEnrollment { get; set; }

        public virtual ICollection<HomeworkUpload> HomeworkUpload { get; set; }

        public virtual ICollection<MemberCompetency> MemberCompetency { get; set; }
    }
}

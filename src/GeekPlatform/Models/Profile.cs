using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekPlatform.Models
{
    public partial class Profile : IdentityUser<int>
    {
        public Profile()
        {
            CourseEnrollment = new HashSet<CourseEnrollment>();
            HomeworkUpload = new HashSet<HomeworkUpload>();
            MemberCompetency = new HashSet<MemberCompetency>();
        }

        // public virtual TKey Id { get; set; }

        public override string UserName { get => Email; set => Email = value; }

        public string Name { get; set; }

        public string PicFileName { get; set; }

        public string TeamMember { get; set; }

        public DateTime MembershipStart { get; set; }

        public int UniStartYear { get; set; }

        public string Major { get; set; }

        public string Workplace { get; set; }

        // public virtual string Emal { get; set; }

        // public virtual string PhoneNumber { get; set; }

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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekPlatform.Models
{
    public partial class CourseThematics
    {
        public CourseThematics()
        {
            HomeworkUpload = new HashSet<HomeworkUpload>();
            ThematicsAttachment = new HashSet<ThematicsAttachment>();
        }

        // Composite Key
        public int CourseId { get; set; }

        // Composite Key
        public byte WeekNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime ActualDate { get; set; }

        [Required, MaxLength(40)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string HomeworkDescription { get; set; }

        [InverseProperty("CourseThematics")]
        public virtual ICollection<HomeworkUpload> HomeworkUpload { get; set; }

        [InverseProperty("CourseThematics")]
        public virtual ICollection<ThematicsAttachment> ThematicsAttachment { get; set; }

        public virtual Course Course { get; set; }
    }
}

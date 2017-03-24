using System;
using System.Collections.Generic;

namespace GeekPlatform.Models
{
    public partial class CourseThematics
    {
        public CourseThematics()
        {
            HomeworkUpload = new HashSet<HomeworkUpload>();
            ThematicsAttachment = new HashSet<ThematicsAttachment>();
        }

        public int CourseId { get; set; }
        public byte WeekNumber { get; set; }
        public DateTime ActualDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HomeworkDescription { get; set; }

        public virtual ICollection<HomeworkUpload> HomeworkUpload { get; set; }
        public virtual ICollection<ThematicsAttachment> ThematicsAttachment { get; set; }
        public virtual Course Course { get; set; }
    }
}

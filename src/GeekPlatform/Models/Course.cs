using System;
using System.Collections.Generic;

namespace GeekPlatform.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseEnrollment = new HashSet<CourseEnrollment>();
            CourseNews = new HashSet<CourseNews>();
            CourseThematics = new HashSet<CourseThematics>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string DescriptionShort { get; set; }
        public string DescriptionLong { get; set; }
        public string IconFileName { get; set; }
        public bool IsWorkshop { get; set; }
        public bool IsActive { get; set; }
        public bool IsRunning { get; set; }
        public DateTime SignUpDeadline { get; set; }

        public virtual ICollection<CourseEnrollment> CourseEnrollment { get; set; }
        public virtual ICollection<CourseNews> CourseNews { get; set; }
        public virtual ICollection<CourseThematics> CourseThematics { get; set; }
    }
}

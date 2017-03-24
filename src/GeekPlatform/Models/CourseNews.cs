using System;
using System.Collections.Generic;

namespace GeekPlatform.Models
{
    public partial class CourseNews
    {
        public int CourseNewsId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostTime { get; set; }

        public virtual Course Course { get; set; }
    }
}

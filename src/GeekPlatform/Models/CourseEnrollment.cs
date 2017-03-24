using System;
using System.Collections.Generic;

namespace GeekPlatform.Models
{
    public partial class CourseEnrollment
    {
        public int ProfileId { get; set; }
        public int CourseId { get; set; }
        public bool IsInstructor { get; set; }
        public bool IsFinished { get; set; }

        public virtual Course Course { get; set; }
        public virtual Profile Profile { get; set; }
    }
}

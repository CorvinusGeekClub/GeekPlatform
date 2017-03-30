using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace GeekPlatform.Models
{
    public partial class CourseEnrollment
    {
        // Composite Key
        public int ProfileId { get; set; }

        // Composite Key
        public int CourseId { get; set; }

        public bool IsInstructor { get; set; }

        public bool IsFinished { get; set; }

        public virtual Course Course { get; set; }

        public virtual Profile Profile { get; set; }
    }
}

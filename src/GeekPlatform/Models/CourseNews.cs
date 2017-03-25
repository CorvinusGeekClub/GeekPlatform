using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeekPlatform.Models
{
    public partial class CourseNews
    {
        public int CourseNewsId { get; set; }

        public int CourseId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime PostTime { get; set; }

        public virtual Course Course { get; set; }
    }
}

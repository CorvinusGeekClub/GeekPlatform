using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekPlatform.Models
{
    public partial class HomeworkUpload
    {
        public int HomeworkUploadId { get; set; }

        public int CourseId { get; set; }

        public byte WeekNumber { get; set; }

        public int ProfileId { get; set; }

        [Required, MaxLength(128)]
        public string UploadFileName { get; set; }

        public DateTime UploadDateTime { get; set; }

        [Required]
        public string Comment { get; set; }

        public bool IsActive { get; set; }

        public virtual Profile Profile { get; set; }

        [ForeignKey("CourseId,WeekNumber")]
        public virtual CourseThematics CourseThematics { get; set; }
    }
}

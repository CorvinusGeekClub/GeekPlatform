using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekPlatform.Models
{
    public partial class ThematicsAttachment
    {
        public int ThematicsAttachmentId { get; set; }

        public int CourseId { get; set; }

        public byte WeekNumber { get; set; }

        public bool IsHomework { get; set; }

        [Required]
        public string AttachmentFileName { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("CourseId,WeekNumber")]
        public virtual CourseThematics CourseThematics { get; set; }
    }
}

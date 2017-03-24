using System;
using System.Collections.Generic;

namespace GeekPlatform.Models
{
    public partial class ThematicsAttachment
    {
        public int ThematicsAttachmentId { get; set; }
        public int CourseId { get; set; }
        public byte WeekNumber { get; set; }
        public bool IsHomework { get; set; }
        public string AttachmentFileName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual CourseThematics CourseThematics { get; set; }
    }
}

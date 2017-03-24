using System;
using System.Collections.Generic;

namespace GeekPlatform.Models
{
    public partial class HomeworkUpload
    {
        public int HomeworkUploadId { get; set; }
        public int CourseId { get; set; }
        public byte WeekNumber { get; set; }
        public int ProfileId { get; set; }
        public string UploadFileName { get; set; }
        public DateTime UploadDateTime { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual CourseThematics CourseThematics { get; set; }
    }
}

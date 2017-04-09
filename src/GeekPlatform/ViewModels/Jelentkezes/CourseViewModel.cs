using GeekPlatform.Models;
using System;
using System.Linq;

namespace GeekPlatform.ViewModels.Jelentkezes
{
    public class CourseViewModel
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public  bool IsWorkshop { get; set; }
        public bool IsEnrolled { get; set; }
    }
}
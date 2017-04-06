using GeekPlatform.Models;
using System;
using System.Linq;

namespace GeekPlatform.ViewModels.Jelentkezes
{
    public class CourseViewModel
    {
        public CourseViewModel(Course c, Profile p)
        {
            CourseName = c.CourseName;
            Instructor = string.Join(", ", c.CourseEnrollment.Where(d => d.IsInstructor).Select(d => d.Profile.Name));
            ImgUrl = c.IconFileName;
            Description = c.DescriptionShort;
            CourseId = c.CourseId;
            IsWorkshop = c.IsWorkshop;
            IsEnrolled = c.CourseEnrollment.Any(a => a.Profile == p);
        }
        public string CourseName { get; }
        public string Instructor { get; }
        public string ImgUrl { get; }
        public string Description { get; }
        public int CourseId { get; }
        public  bool IsWorkshop { get; }
        public bool IsEnrolled { get; }
    }
}
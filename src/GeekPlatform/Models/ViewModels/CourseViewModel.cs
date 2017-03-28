using GeekPlatform.Models;
using System;
using System.Linq;

namespace GeekPlatform.Models.ViewModels
{
    public class CourseViewModel
    {
        public CourseViewModel(Course c)
        {
            CourseName = c.CourseName;
            Instructor = string.Join(", ", c.CourseEnrollment.Where(d => d.IsInstructor).Select(d => d.Profile.Name));
            ImgUrl = c.IconFileName;
            Description = c.DescriptionShort;
            CourseId = c.CourseId;
        }
        public string CourseName { get; }
        public string Instructor { get; }
        public string ImgUrl { get; }
        public string Description { get; }
        public int CourseId { get; }
    }
}
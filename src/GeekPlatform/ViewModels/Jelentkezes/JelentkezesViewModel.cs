using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GeekPlatform.Models;

namespace GeekPlatform.ViewModels.Jelentkezes
{
    public class JelentkezesViewModel : ViewModelBase
    {
        public JelentkezesViewModel(IEnumerable<Course> courselist, bool enrolled, Profile p)
        {
            Courses = courselist.Select(x => new CourseViewModel(x, p)).ToList();
            Enrolled = enrolled;
        }
        public IList<CourseViewModel> Courses { get; }
        public bool Enrolled { get; }
    }

}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.Models.ViewModels
{
    public class JelekezesViewModel : ViewModelBase
    {
        public JelekezesViewModel(IEnumerable<Course> courselist)
        {
            Courses = courselist.Select(x => new CourseViewModel(x)).ToList();
        }
        public IList<CourseViewModel> Courses { get; }
    }

}

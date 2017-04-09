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
        public IEnumerable<CourseViewModel> Courses { get; set; }
        public bool Enrolled { get; set; }
    }

}

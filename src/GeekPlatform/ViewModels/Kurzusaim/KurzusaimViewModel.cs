using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;

namespace GeekPlatform.ViewModels.Kurzusaim
{
    public class KurzusaimViewModel : ViewModelBase
    {
        public KurzusaimViewModel(IEnumerable<Course> courseList,Profile user) : base(user)
        {
            
        }
    }
}

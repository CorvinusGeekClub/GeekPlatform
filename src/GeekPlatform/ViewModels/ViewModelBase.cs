using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;

namespace GeekPlatform.ViewModels
{
    public class ViewModelBase
    {
        public String FelhasznaloNev { get; }

        public ViewModelBase(Profile user)
        {
            FelhasznaloNev = user.Name;
        }
    }
}

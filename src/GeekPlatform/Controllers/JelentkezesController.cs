using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using GeekPlatform.Models;
using GeekPlatform.ViewModels.Jelentkezes;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class JelentkezesController : Controller
    {

        private IServiceProvider _serviceProvider;

        public JelentkezesController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            using (var context = _serviceProvider.GetRequiredService<GeekDatabaseContext>())
            {
                var vm = new JelentkezesViewModel(context.Course.ToList());
                return View(vm);
            }

           
        }
    }
}

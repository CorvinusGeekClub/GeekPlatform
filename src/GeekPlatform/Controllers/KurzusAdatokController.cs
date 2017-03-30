using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

using GeekPlatform.Models;
using GeekPlatform.ViewModels.KurzusAdatok;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class KurzusAdatokController : Controller
    {
        private IServiceProvider _serviceProvider;

        public KurzusAdatokController(IServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }

        // GET: /<controller>/
        public IActionResult Aktiv()
        {
            return View();
        }
        public IActionResult Passziv()
        {
            GeekDatabaseContext context = _serviceProvider.GetRequiredService<GeekDatabaseContext>();
            IEnumerable<Course> model = context.Course.Where(c => !c.IsRunning);
            KurzusAdatokViewModel viewModel = new KurzusAdatokViewModel(model);
            return View(viewModel);
        }
    }
}

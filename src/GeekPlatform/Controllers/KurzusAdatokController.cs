using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using GeekPlatform.Models;
using GeekPlatform.ViewModels.KurzusAdatok;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekPlatform.Controllers
{
    [Authorize]
    public class KurzusAdatokController : Controller
    {
        private IServiceProvider _serviceProvider;

        public KurzusAdatokController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        // GET: /<controller>/
        public IActionResult Aktiv()
        {
            return View();
        }

        // GET: /KurzusAdatok/Passziv/id
        public IActionResult Passziv(int? id)
        {
            GeekDatabaseContext context = _serviceProvider.GetRequiredService<GeekDatabaseContext>();
            if (!id.HasValue)
            {
                return BadRequest();
            }

            Course kurzus = context.Course.Where(c => c.IsActive && !c.IsRunning && c.CourseId == id).FirstOrDefault();

            if (kurzus == null)
            {
                return NotFound();
            }

            IEnumerable<CourseEnrollment> jelentkezesek = context.CourseEnrollment
                .Include(ce => ce.Course)
                .Include(ce => ce.Profile);
            // TODO tematikak = ...
            KurzusAdatokViewModel viewModel = new KurzusAdatokViewModel(kurzus, jelentkezesek);
            return View(viewModel);

        }
    }
}

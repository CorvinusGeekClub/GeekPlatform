using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using GeekPlatform.Services;
using GeekPlatform.ViewModels.Esemenyek;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GeekPlatform.Controllers
{
    public class EsemenyekController : ControllerBase
    {
        private readonly FacebookService _facebookService;

        public EsemenyekController(FacebookService facebookService, UserManager<Profile> userManager, GeekDatabaseContext dbContext)
            : base(userManager, dbContext)
        {
            _facebookService = facebookService;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _facebookService.GetEventsAsync("corvinusgeekclub");
            EsemenyekViewModel vm = new EsemenyekViewModel
            {
                Esemenyek = events.Select(fbe => new EsemenyViewModel
                {
                    Id = fbe.Id,
                    Cim = fbe.Name,
                    CoverUrl = fbe.Cover?.Url,
                    EndTime = fbe.EndTime,
                    Helyszin = fbe.Place?.Name,
                    Leiras = fbe.Description,
                    StartTime = fbe.StartTime
                })
            };
            return View(vm);
        }
    }
}
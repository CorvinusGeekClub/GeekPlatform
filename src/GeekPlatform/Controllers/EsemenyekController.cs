using GeekPlatform.Models;
using GeekPlatform.ViewModels.Esemenyek;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GeekPlatform.Controllers
{
    public class EsemenyekController : ControllerBase
    {
        public EsemenyekController(UserManager<Profile> userManager, GeekDatabaseContext dbContext)
            : base(userManager, dbContext)
        {
        }

        public IActionResult Index()
        {
            EsemenyekViewModel vm = new EsemenyekViewModel();
            return View(vm);
        }
    }
}
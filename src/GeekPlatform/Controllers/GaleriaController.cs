using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeekPlatform.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            return
                Redirect(
                    "https://photos.google.com/share/AF1QipN6kywYu5mSfr66frMQ6tea4kwPhmkC_PxCyiLgTbUK1rMWpKlDtUma_wbGeRc39g?key=cE5wMXdoR1J6UGJVZG9NQ051UTF1Y2phazBNM3F3");
        }
    }
}
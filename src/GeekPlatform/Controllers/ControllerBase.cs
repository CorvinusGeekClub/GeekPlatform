using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using GeekPlatform.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GeekPlatform.Controllers
{
    public class ControllerBase : Controller
    {
        private readonly UserManager<Profile> _userManager;

        protected GeekDatabaseContext DbContext { get; }

        protected new Profile User { get; private set; }

        public ControllerBase(UserManager<Profile> userManager, GeekDatabaseContext dbContext)
        {
            _userManager = userManager;
            DbContext = dbContext;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            User = null;
            if (base.User?.Identity != null && base.User.Identity.IsAuthenticated)
            {
                User = await _userManager.GetUserAsync(base.User);
            }

            await base.OnActionExecutionAsync(context, next);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);

            var controller = ((Controller) context.Controller);
            var model = controller.ViewData.Model as ViewModelBase;

            if (model != null)
            {
                model.User = User;
                model.ControllerNev = controller.RouteData.Values["controller"].ToString();
            }
        }
    }
}

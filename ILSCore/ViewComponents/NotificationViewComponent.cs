using ILS.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILS_Core.ViewComponents
{
    public class NotificationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(NotificationViewModel model)
        {
            return View(model);
        }
    }
}

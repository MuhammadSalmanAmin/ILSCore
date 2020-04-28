using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ILS;
using Microsoft.AspNetCore.Mvc;

namespace ILS_Core.Controllers
{
    public class CageController : Controller
    {
        public IActionResult Index()
        {
            return View("Cage");
        }

        public IActionResult AddCage(AddEditCageViewModel model)
        {
            return View();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ILS.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using ILS.Services.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ILS.Controllers
{
    public class PartsController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<PartsController> _logger;
        private readonly IPartsService _partService;
        private IWebHostEnvironment _hostingEnvironment;
        public PartsController(IWebHostEnvironment environment, ILogger<PartsController> logger,IConfiguration configuration, IPartsService partService)
        {
            _configuration = configuration;
            _hostingEnvironment = environment;
            _partService = partService;
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View("PartsGrid", new PartsViewModel());
        }

        [HttpGet]
        public JsonResult GetPartsList()
        {
            var list = _partService.GetPartsList();
            var result = Json(list);

            return result;
        }


        public ActionResult AddParts()
        {
            ViewBag.PageMode = "Add";
            return View(LoadData());
        }

        [HttpPost]
        public ActionResult AddParts(AddPartViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TempData.Put("Message", new NotificationViewModel() { Message = "Part added succesfully.", MessageType = NotificationType.success });

                    var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads");

                    if (model.PictureInfo.Length > 0)
                    {
                        var filePath = Path.Combine(uploads, model.PictureInfo.FileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            model.PictureInfo.CopyToAsync(fileStream);
                        }
                    }

                   
                    _partService.AddParts(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.PageMode = "Add";

                    ModelState.AddModelError("", "There are errors, please  correct them to continue!");
                    model = LoadData();
                    return View("AddParts", model);
                }
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
        public AddPartViewModel LoadData()
        {
            AddPartViewModel vm = new AddPartViewModel();
            vm.PartCategoryItems = _partService.GetPartsCategory().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.CategoryId,
                Text = c.Description
            });
            vm.PartTypeItems = _partService.GetPartType().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.PartType,
                Text = c.PartTypeDescription
            });
            vm.CurrencyItems = _partService.GetCurrency().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description
            });

            vm.UnitItems = _partService.GetUnitItems().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description

            });
            vm.MaterialCategoryItems = _partService.GetMaterialcCategoryItems().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description

            });
            return vm;
        }

        public IActionResult EditPart(string id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetPartType()
        {

            var list = _partService.GetPartType().ToViewModel();

            return Json(list);
        }

        [HttpPost]
        public JsonResult GetPartCategory()
        {

            return Json(_partService.GetPartType().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.PartType,
                Text = c.PartTypeDescription
            }));

        }

        [HttpGet]
        public JsonResult GetGroupInfo()
        {
            return Json(new { data = _partService.GetGroupInfo().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetCageInfo()
        {
            return Json(new { data = _partService.GetCageInfo().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetVendorInfo()
        {
            return Json(new { data = _partService.GetCageInfo().ToViewModel() });
        }

    }
}
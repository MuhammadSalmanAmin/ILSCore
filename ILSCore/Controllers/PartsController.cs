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
        private readonly ILogger<PartsController> _logger;
        private readonly IPartsService _partService;
        private IWebHostEnvironment _hostingEnvironment;
        public PartsController(IWebHostEnvironment environment, ILogger<PartsController> logger, IPartsService partService)
        {
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

                    var folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads");
                    if (model.PictureInfo.Length > 0)
                    {
                        var filePath = Path.Combine(folderPath, model.PictureInfo.FileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            model.PictureInfo.CopyToAsync(fileStream);
                        }
                    }

                    model.PictureFileName = model.PictureInfo.FileName;
                   
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

            vm.APItems = _partService.GetAPItemsList().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description
            });

            vm.ACItems = _partService.GetACItemsList().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description
            });

            vm.ASCItems = _partService.GetASCItemsList().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description
            });

            vm.ShelfLifeItems = _partService.GetShelfLifeItems().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description
            });

            vm.LeadTimeItems = _partService.GetLeadTimeItems().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description
            });

            vm.OSIItems = _partService.GetOSIItems().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description
            });

            vm.UnitCubeItems = _partService.GetUnitCubeItems().ToViewModel().Select(c => new SelectListItem
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

        [HttpGet]
        public JsonResult GetMECInfo()
        {
            return Json(new { data = _partService.GetMECInfo().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetANCInfo()
        {
            return Json(new { data = _partService.GetANCInfo().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetAPPInfo()
        {
            return Json(new { data = _partService.GetAPPInfo().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetCustodyInfo()
        {
            return Json(new { data = _partService.GetCustodyInfo().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetSMCInfo()
        {
            return Json(new { data = _partService.GetSMCInfo().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetDerivativeInfo()
        {
            return Json(new { data = _partService.GetDerivativeItems().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetSMICInfo()
        {
            return Json(new { data = _partService.GetSMICItems().ToViewModel() });
        }

        [HttpGet]
        public JsonResult GetTSSInfo()
        {
            return Json(new { data = _partService.GetTSSItems().ToViewModel() });
        }

    }
}
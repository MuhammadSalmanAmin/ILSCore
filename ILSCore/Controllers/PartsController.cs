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
using Newtonsoft.Json;
using System.Data;

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
            var list = _partService.GetPartsList().ToPartsModelList();
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
                    model.PictureFileName = $"{DateTime.Now.ToString("yyyymmddhhmiss")}{ model.PictureInfo.FileName}";

                    _partService.AddParts(model);

                    var folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads");
                    if (model.PictureInfo.Length > 0)
                    {
                        var filePath = Path.Combine(folderPath, model.PictureFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            model.PictureInfo.CopyToAsync(fileStream);
                        }
                    }

                    TempData.Put("Message", new NotificationViewModel() { Message = $"Part '{model.PartName}' added succesfully.", MessageType = NotificationType.success });
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
            catch (Exception ex)
            {
                TempData.Put("Message", new NotificationViewModel() { Message = ex.ToString(), MessageType = NotificationType.error });
                return View("AddParts", model);
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

            vm.SecurityItems = _partService.GetSecurityItems().ToViewModel().Select(c => new SelectListItem
            {
                Value = c.ID,
                Text = c.Description
            });


            return vm;
        }

        public IActionResult Edit(string id)
        {
            var partDetails = _partService.GetPartById(Convert.ToInt32(id));
            if (partDetails != null)
            {
                var model = LoadData();

                var partViewModel = partDetails.ToViewModel();
                partViewModel.PartCategoryItems = model.PartCategoryItems;
                partViewModel.PartTypeItems = model.PartTypeItems;
                partViewModel.CurrencyItems = model.CurrencyItems;
                partViewModel.UnitItems = model.UnitItems;
                partViewModel.MaterialCategoryItems = model.MaterialCategoryItems;
                partViewModel.APItems = model.APItems;
                partViewModel.ACItems = model.ACItems;
                partViewModel.ASCItems = model.ASCItems;
                partViewModel.ShelfLifeItems = model.ShelfLifeItems;
                partViewModel.LeadTimeItems = model.LeadTimeItems;
                partViewModel.OSIItems = model.OSIItems;
                partViewModel.UnitCubeItems = model.UnitCubeItems;
                partViewModel.SecurityItems = model.SecurityItems;


                var folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads");

                partViewModel.PictureFileName = $"\\Uploads\\{partViewModel.PictureFileName}";

                var cageInfo = _partService.GetCageInfo(Convert.ToInt32(partViewModel.ManufacturerId)).FirstOrDefault();

                if (cageInfo != null)
                {
                    partViewModel.ManufacturerName = cageInfo.ManufacturerName;
                    partViewModel.CageCode = model.GroupModelId;
                }

                return View("AddParts", partViewModel);
            }
            else
            {
                TempData.Put("Message", new NotificationViewModel() { Message = "Part not found.", MessageType = NotificationType.error });
            }
            return View();
        }


        #region Helper Functions
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

        [HttpGet]
        public JsonResult GetSLAInfo()
        {
            return Json(new { data = _partService.GetSLAInfo().ToViewModel() });
        }

        #endregion

        [HttpGet]
        public JsonResult GetChildren(string id)
        {
            var items = new List<NewJSTreeVM>();

            {
                NewJSTreeVM model = new NewJSTreeVM()
                {
                    id = "2",
                    text = "Root node",
                    children = new List<JsTreeViewModel>()
                    {
                        new JsTreeViewModel(){id="4",text="Child Node 1",children = true},
                        new JsTreeViewModel(){id="5",text="Child Node 2",children = true},
                    }
                };

                items.Add(model);

            }
            // set items in here
            var dataa = JsonConvert.SerializeObject(items);

            return Json(items);
        }
        [HttpGet]
        public JsonResult GetRoot(string id)
        {
            var items = new List<NewJSTreeVM>();
            NewJSTreeVM rootModel = new NewJSTreeVM();
            string parentId = string.Empty;
            bool isChildren = false;


            if (id.Contains("##"))
            {
                parentId = id;
                isChildren = true;
                id = id.Split("##")[1];
            }

            DataTable dt = _partService.GetTreeViewData(id);

            if (dt != null && dt.Rows.Count > 0)
            {
                if (!isChildren)
                {
                    rootModel = new NewJSTreeVM()
                    {
                          
                        id = dt.Rows[0]["parentPartId"]?.ToString(),
                        text = dt.Rows[0]["parentName"]?.ToString(),
                        children = new List<JsTreeViewModel>()
                    };
                }
                else
                {
                    rootModel = new NewJSTreeVM()
                    {
                        id = parentId,
                        text = dt.Rows[0]["parentName"]?.ToString(),
                        children = new List<JsTreeViewModel>()
                    };
                }

                foreach (var rows in dt.Select("LEVEL = '0'"))
                {
                    string text = string.Empty;
                    if (dt.Select("parentPartId = '" + rows["childPartId"]?.ToString() + "'").Any())
                    {
                        text = dt.Select("parentPartId = '" + rows["childPartId"]?.ToString() + "'").FirstOrDefault()["parentName"]?.ToString();
                    }
                    else
                    {
                        text = _partService.GetPartById(Convert.ToInt32(rows["childPartId"]?.ToString()))?.PartName;
                    }

                    rootModel.children.Add(new JsTreeViewModel()
                    {
                         
                        id = dt.Rows[0]["parentPartId"]?.ToString() + "##" + rows["childPartId"]?.ToString() + "##",
                        children = dt.Select("parentPartId = '" + rows["childPartId"]?.ToString() + "'").Any() ? true : false,
                        text = text
                    });
                }
            }
            else
            {
                rootModel = new NewJSTreeVM()
                {
                    id = id,
                    text = "No Part",
                    children = null
                };
            }

            items.Add(rootModel);

            return Json(items);
        }

        public ActionResult TreeView(string id)
        {
            TreeViewModel treeViewModel = new TreeViewModel()
            {
                Key = id
            };
            return View("TreeView", treeViewModel);
        }

        [HttpGet]
        public JsonResult GetPartsData()
        {
            var result = _partService.GetPartsData();
            return Json(result);
        }

        public ActionResult GetAssociatedPartView()
        {
            return View("PartsList");
        }

        public ActionResult GetGridDataForParts(string id)
        {
            var result = _partService.GetChildPartList(id, false);
            ViewData["ParentId"] = id;
            return Json(new { data = result });
        }

        public ActionResult AddEditChildPart(string id)
        {
            ViewData["ParentId"] = id;
            return View("AddEditChildPart");
        }

        public ActionResult EditChildPart(string id)
        {
            ViewBag.PageMode = "Edit";
            ViewData["ParentId"] = id;
            return View("AddEditChildPart");
        }

        public ActionResult ViewChildPart(string id)
        {
            ViewBag.PageMode = "View";
            ViewData["ParentId"] = id;
            return View("AddEditChildPart");
        }

        public ActionResult GetAssociatedPartsData(string id)
        {
            ViewData["ParentId"] = id;
            var result = _partService.GetChildPartList(id, true);
            return Json(new { data = result });
        }

        [HttpPost]
        public JsonResult LinkPart(string quantity,string parentPartId,string childPartId)
        {
            var result = _partService.LinkPart(quantity, parentPartId, childPartId);
            return Json(result);
        }

        [HttpPost]
        public JsonResult DeletePart(string id)
        {
            var result = _partService.DeletePart(id);
            TempData.Put("Message", new NotificationViewModel() { Message = "Part deleted successfully.", MessageType = NotificationType.success });
            return Json(result);
        }

        
    }

    public class TreeViewModel
    {
        public string Key { get; set; }
    }
}
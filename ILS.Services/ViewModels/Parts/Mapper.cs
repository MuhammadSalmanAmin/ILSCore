using ILS.DAL.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ILS
{
    public static class Mapper
    {
        public static List<PartsViewModel> ToPartsModelList(this List<MimsCParts> entityList)
        {

            var partModelList = new List<PartsViewModel>();

            foreach (var entity in entityList)
            {
                var partModel = new PartsViewModel()
                {
                    PartId = entity.PartId,
                    Currency = entity.Currency != null ? entity.Currency.ToString() : "",
                    ManufacturerCategory = entity.Mcat,
                    ManufacturerId = entity.ManId,
                    PartCategory = entity.PartCat,
                    PartName = entity.PartName,
                    PartNo = entity.PartNo,
                    PartType = entity.PartType,
                    UnitPrice = entity.UnitPrice
                };

                partModelList.Add(partModel);
            }

            return partModelList;
        }

        public static AddPartViewModel ToViewModel(this MimsCParts entity)
        {
            var partModel = new AddPartViewModel()
            {
                ManufacturerId = Convert.ToString(entity.ManId),
                MaterialCategoryId = entity.Mcat,
                PartCategoryId = entity.PartCat,
                PartTypeId = entity.PartType,
                AC = entity.Ac is null ? string.Empty : Convert.ToString(entity.Ac),
                ANC = entity.Anc is null ? string.Empty : Convert.ToString(entity.Anc),
                AP = entity.Ap is null ? string.Empty : Convert.ToString(entity.Ap),
                APP = entity.App is null ? string.Empty : Convert.ToString(entity.App),
                ASC = entity.Asc is null ? string.Empty : Convert.ToString(entity.Asc),
                Currency = entity.Currency is null ? string.Empty : Convert.ToString(entity.Currency),
                CustodyId = entity.CustodyId is null ? string.Empty : Convert.ToString(entity.CustodyId),
                Derivative = entity.DerivativeId is null ? string.Empty : Convert.ToString(entity.DerivativeId),
                GroupModelId = entity.HZECode is null ? string.Empty : Convert.ToString(entity.HZECode),
                PartMEC = entity.PartMec is null ? string.Empty : Convert.ToString(entity.PartMec),
                OSIId = entity.Osi is null ? string.Empty : Convert.ToString(entity.Osi),
                SecurityId = entity.DocSecId is null ? string.Empty : Convert.ToString(entity.DocSecId),
                ShelfLifeId = entity.ShelfLifeId is null ? string.Empty : Convert.ToString(entity.ShelfLifeId),
                SLA = entity.SlaId is null ? string.Empty : Convert.ToString(entity.SlaId),
                SMC = entity.Smc is null ? string.Empty : Convert.ToString(entity.Smc),
                SMIC = entity.Smic is null ? string.Empty : Convert.ToString(entity.Smic),
                LeadTimeId = entity.LeadTimeId is null ? string.Empty : Convert.ToString(entity.LeadTimeId),
                TSS = entity.TssId is null ? string.Empty : Convert.ToString(entity.TssId),
                UnitCubeId = entity.UnitCube is null ? string.Empty : Convert.ToString(entity.UnitCube),

                PartName = entity.PartName,
                PartNumber = entity.PartNo,

                UnitPrice = entity.UnitPrice ?? 0,
                Length = entity.Length ?? 0,
                Width = entity.Width ?? 0,
                Height = entity.Height ?? 0,
                MTBF = entity.Mtbf ?? 0,
                BRF = entity.Brf ?? 0,
                Diameter = entity.Diameter is null ? 0 : Convert.ToDecimal(entity.Diameter),
                PartCharacteristics = entity.PartCharacteristics,
                PictureFileName = entity.PictureFileName,
                SMR = entity.Smr,

            
                CreationDateTime = entity.DateAdded,
                ModifiedDateTime = entity.DateUpdated,

                MMTR = entity.Mmtr ?? 0,
                OldNSN = entity.OldNsn,
                NSN = entity.TempNsn,
                OldSMIC = entity.OldSmic is null ? string.Empty : Convert.ToString(entity.OldSmic)
            };

            return partModel;
        }


        public static List<PartTypeViewModel> ToViewModel(this List<MimsCParttype> partType)
        {
            var mappedList = new List<PartTypeViewModel>();

            foreach (var type in partType)
            {
                PartTypeViewModel newPart = new PartTypeViewModel()
                {
                    PartType = type.PartType,
                    PartTypeDescription = type.TypeDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<GroupInfoViewModel> ToViewModel(this List<MimsXGroup> partType)
        {
            var mappedList = new List<GroupInfoViewModel>();

            foreach (var type in partType)
            {
                GroupInfoViewModel newPart = new GroupInfoViewModel()
                {
                    Id = type.GroupId.ToString(),
                    Code = type.GrouopCode,
                    Description = type.GroupDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<PartCategoryViewModel> ToViewModel(this List<MimsCPartcat> partCategory)
        {
            var mappedList = new List<PartCategoryViewModel>();

            foreach (var type in partCategory)
            {
                PartCategoryViewModel newPart = new PartCategoryViewModel()
                {
                    CategoryId = type.PartCat,
                    Description = type.PartcatDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<PartListViewModel> ToViewModel(dynamic partCategory)
        {
            var mappedList = new List<PartListViewModel>();

            foreach (var type in partCategory)
            {
                PartListViewModel newPart = new PartListViewModel()
                {
                    ManufacturerName = type.manufacturerName
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<CurrencyViewModel> ToViewModel(this List<MimsXCurrency> partCategory)
        {
            var mappedList = new List<CurrencyViewModel>();

            foreach (var type in partCategory)
            {
                CurrencyViewModel newPart = new CurrencyViewModel()
                {
                    ID = type.CurrencyId.ToString(),
                    Description = type.CurrName
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<UnitItemsViewModel> ToViewModel(this List<MimsXUom> partCategory)
        {
            var mappedList = new List<UnitItemsViewModel>();

            foreach (var type in partCategory)
            {
                UnitItemsViewModel newPart = new UnitItemsViewModel()
                {
                    ID = type.UomId.ToString(),
                    Description = type.UomName
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<CageViewModel> ToViewModel(this List<MimsCCage> partCategory)
        {
            var mappedList = new List<CageViewModel>();

            foreach (var type in partCategory)
            {
                CageViewModel newPart = new CageViewModel()
                {
                    Cageid = type.Cage,
                    ManufacturerCode = type.ManCode,
                    ManufacturerName = type.ManufacturerName,
                    ManufacturerId = type.ManId.ToString()
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<VendorViewModel> ToViewModel(this List<MimsCPartvendorlist> partCategory)
        {
            var mappedList = new List<VendorViewModel>();

            foreach (var type in partCategory)
            {
                VendorViewModel newPart = new VendorViewModel()
                {
                    PartId = type.PartId.ToString(),
                    VendorId = type.VendorId.ToString()
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<MaterialCategoryViewModel> ToViewModel(this List<MimsCMcat> partCategory)
        {
            var mappedList = new List<MaterialCategoryViewModel>();

            foreach (var type in partCategory)
            {
                MaterialCategoryViewModel newPart = new MaterialCategoryViewModel()
                {
                    ID = type.Mcat,
                    Description = type.McatDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<MECViewModel> ToViewModel(this List<MimsXMec> mecList)
        {
            var mappedList = new List<MECViewModel>();

            foreach (var mec in mecList)
            {
                MECViewModel newPart = new MECViewModel()
                {
                    Id = mec.Mec.ToString(),
                    Description = mec.MecDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<APViewModel> ToViewModel(this List<MimsXAp> apList)
        {
            var mappedList = new List<APViewModel>();

            foreach (var ap in apList)
            {
                APViewModel newPart = new APViewModel()
                {
                    ID = ap.ApId.ToString(),
                    Description = ap.ApName + " || " + ap.ApDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<ACViewModel> ToViewModel(this List<MimsXAc> acList)
        {
            var mappedList = new List<ACViewModel>();

            foreach (var ac in acList)
            {
                ACViewModel acModel = new ACViewModel()
                {
                    ID = ac.AcId.ToString(),
                    Description = ac.AcName + " || " + ac.AcDesc
                };

                mappedList.Add(acModel);
            }

            return mappedList;
        }

        public static List<ASCViewModel> ToViewModel(this List<MimsXAsc> acList)
        {
            var mappedList = new List<ASCViewModel>();

            foreach (var ac in acList)
            {
                ASCViewModel acModel = new ASCViewModel()
                {
                    ID = ac.AscId.ToString(),
                    Description = ac.AscName + " || " + ac.AscDesc
                };

                mappedList.Add(acModel);
            }

            return mappedList;
        }

        public static List<ANCViewModel> ToViewModel(this List<MimsXAnc> ancList)
        {
            var mappedList = new List<ANCViewModel>();

            foreach (var anc in ancList)
            {
                ANCViewModel newPart = new ANCViewModel()
                {
                    ID = anc.AncId.ToString(),
                    Name = anc.AncName,
                    Description = anc.AncDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<APPViewModel> ToViewModel(this List<MimsXApp> appList)
        {
            var mappedList = new List<APPViewModel>();

            foreach (var anc in appList)
            {
                APPViewModel newPart = new APPViewModel()
                {
                    ID = anc.AppId.ToString(),
                    Code = anc.AppCode,
                    Description = anc.AppDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<CustodyViewModel> ToViewModel(this List<MimsXCustody> custodyList)
        {
            var mappedList = new List<CustodyViewModel>();

            foreach (var anc in custodyList)
            {
                CustodyViewModel newPart = new CustodyViewModel()
                {
                    ID = anc.CustodyId.ToString(),
                    Code = anc.CustodyCode,
                    Description = anc.CustodyDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<SMCViewModel> ToViewModel(this List<MimsXSmc> custodyList)
        {
            var mappedList = new List<SMCViewModel>();

            foreach (var anc in custodyList)
            {
                SMCViewModel newPart = new SMCViewModel()
                {
                    ID = anc.SmcId.ToString(),
                    Code = anc.SmcCode,
                    Description = anc.SmcDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<ShelfLifeViewModel> ToViewModel(this List<MimsXShelflife> shelfLifeItems)
        {
            var mappedList = new List<ShelfLifeViewModel>();

            foreach (var ac in shelfLifeItems)
            {
                ShelfLifeViewModel acModel = new ShelfLifeViewModel()
                {
                    ID = ac.SlId.ToString(),
                    Description = ac.SlCode + " || " + ac.SlDesc
                };

                mappedList.Add(acModel);
            }


            return mappedList;
        }


        public static List<DerivativeViewModel> ToViewModel(this List<MimsXDerivative> custodyList)
        {
            var mappedList = new List<DerivativeViewModel>();

            foreach (var anc in custodyList)
            {
                DerivativeViewModel newPart = new DerivativeViewModel()
                {
                    ID = anc.DerivativeId.ToString(),
                    Code = anc.DerivativeCode,
                    Description = anc.DerivativeDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }


        public static List<SMICViewModel> ToViewModel(this List<MimsXSmic> custodyList)
        {
            var mappedList = new List<SMICViewModel>();

            foreach (var anc in custodyList)
            {
                SMICViewModel newPart = new SMICViewModel()
                {
                    ID = anc.SmicId.ToString(),
                    Code = anc.SmicCode,
                    Description = anc.SmicDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<TSSViewModel> ToViewModel(this List<MimsXTss> custodyList)
        {
            var mappedList = new List<TSSViewModel>();

            foreach (var anc in custodyList)
            {
                TSSViewModel newPart = new TSSViewModel()
                {
                    ID = anc.TssId.ToString(),
                    Code = anc.TssCode,
                    Description = anc.TssDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }

        public static List<OSIViewModel> ToViewModel(this List<MimsXOsi> custodyList)
        {
            var mappedList = new List<OSIViewModel>();

            foreach (var ac in custodyList)
            {
                OSIViewModel acModel = new OSIViewModel()
                {
                    ID = ac.OsiId.ToString(),
                    Description = ac.OsiCode + " || " + ac.OsiDesc
                };

                mappedList.Add(acModel);
            }


            return mappedList;
        }

        public static List<LeadTimeViewModel> ToViewModel(this List<MimsXTimeperiod> shelfLifeItems)
        {
            var mappedList = new List<LeadTimeViewModel>();

            foreach (var ac in shelfLifeItems)
            {
                LeadTimeViewModel acModel = new LeadTimeViewModel()
                {
                    ID = ac.TimeperiodId.ToString(),
                    Description = ac.TimeperiodCode + " || " + ac.TimeperiodDesc
                };

                mappedList.Add(acModel);
            }


            return mappedList;
        }

        public static List<SecurityViewModel> ToViewModel(this List<MimsXSecurity> shelfLifeItems)
        {
            var mappedList = new List<SecurityViewModel>();

            foreach (var ac in shelfLifeItems)
            {
                SecurityViewModel acModel = new SecurityViewModel()
                {
                    ID = ac.SecurityId.ToString(),
                    Description = ac.SecurityCode + " || " + ac.SecurityDesc
                };

                mappedList.Add(acModel);
            }


            return mappedList;
        }

        public static List<SLAViewModel> ToViewModel(this List<MimsXSla> custodyList)
        {
            var mappedList = new List<SLAViewModel>();

            foreach (var anc in custodyList)
            {
                SLAViewModel newPart = new SLAViewModel()
                {
                    ID = anc.SlaId.ToString(),
                    Code = anc.SlaCode,
                    Description = anc.SlaDesc
                };

                mappedList.Add(newPart);
            }

            return mappedList;
        }
    }
}

public static class TempDataExtensions
{
    public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
    {
        tempData[key] = JsonConvert.SerializeObject(value);
    }

    public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
    {
        object o;
        tempData.TryGetValue(key, out o);
        return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
    }
}
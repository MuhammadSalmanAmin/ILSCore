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
                    ID = type.CurrCode,
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
                   VendorId =   type.VendorId.ToString()
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
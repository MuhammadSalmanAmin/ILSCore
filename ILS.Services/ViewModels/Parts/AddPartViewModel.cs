using ILS.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ILS
{
    public class AddPartViewModel
    {


        [DisplayName("Manufacturer Id")]
        public string ManufacturerId { get; set; }

        //[Required]
        //[StringLength(1)]
        //[RegularExpression(Regex.AlphabetsOnly)]
        [DisplayName("Part Type")]
        public string PartType { get; set; }

        public IFormFile PictureInfo { get; set; }

        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("Part Category")]
        public IEnumerable<SelectListItem> PartCategory { get; set; }

        //[Required]
        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("Part Category Id")]
        public string PartCategoryId { get; set; }


        //[Required]
        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("Part Type Id")]
        public string PartTypeId { get; set; }



        //[Required]
        //[StringLength(1)]
        //[RegularExpression(Regex.AlphabetsOnly)]
        [DisplayName("Material Category")]
        public string MaterialCategoryId { get; set; }

        //[Required]
        //[StringLength(60,MinimumLength =2)]
        //[RegularExpression(Regex.AlphanumericOnly)]
        [DisplayName("Part Number")]
        public string PartNumber { get; set; }

        //[StringLength(13)]
        //[RegularExpression(Regex.AlphanumericOnly)]
        [DisplayName("NSN")]
        public string NSN { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        //[RegularExpression(Regex.AlphanumericOnly)]
        [DisplayName("Part Name")]
        public string PartName { get; set; }

        //[StringLength(2000)]
        //[RegularExpression(Regex.AlphanumericOnly)]
        [DisplayName("Part Characteristic")]
        public string PartCharacteristics { get; set; }

        //[StringLength(1000)]
        //[RegularExpression(Regex.AlphanumericOnly)]
        [DisplayName("Picture File Name")]
        public string PictureFileName { get; set; }

        //[RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }


        [DisplayName("Currency")]
        public string Currency { get; set; }

        ////  [StringLength(10)]
        //  [RegularExpression(Regex.AlphanumericOnly)]
        [DisplayName("SMR")]
        public string SMR { get; set; }

        ////[RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("BRF")]
        public decimal BRF { get; set; }

        [DisplayName("Unit Of Item")]
        public string UnitOfItem { get; set; }

        // [RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("Length")]
        public decimal Length { get; set; }

        //[RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("Width")]
        public decimal Width { get; set; }

        //[RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("Height")]
        public decimal Height { get; set; }

        // [RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("Weight")]
        public decimal Weight { get; set; }

        //[RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("MTBF")]
        public decimal MTBF { get; set; }

        //[RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("MMTR")]
        public decimal MMTR { get; set; }

        //[RegularExpression(Regex.DecimalWithTwoPrecision)]
        [DisplayName("Diameter")]
        public decimal Diameter { get; set; }


        [DisplayName("Vendor Name")]
        public string VendorName { get; set; }


        //[StringLength(13)]
        //[RegularExpression(Regex.AlphanumericOnly)]
        [DisplayName("Old NSN")]
        public string OldNSN { get; set; }

        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("Part MEC")]
        public string PartMEC { get; set; }

        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("HZE Code")]
        public string HZECode { get; set; }


        //[StringLength(60)]
        //[RegularExpression(Regex.AlphanumericOnly)]
        [DisplayName("PHST Code")]
        public string PHSTCode { get; set; }


        [DisplayName("Shelf Life Id")]
        public string ShelfLifeId { get; set; }

        [DisplayName("Derivative")]
        public string Derivative { get; set; }

        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("AP")]
        public string AP { get; set; }

        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("AC")]
        public string AC { get; set; }

        [RegularExpression(Regex.NumbersOnly)]
        [DisplayName("ASC")]
        public string ASC { get; set; }

        [DisplayName("SC")]
        public string SC { get; set; }
        [DisplayName("SMC")]
        public string SMC { get; set; }

        [DisplayName("SMIC")]
        public string SMIC { get; set; }

        [DisplayName("Lead Time")]
        public string LeadTimeId { get; set; }

        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("ANC")]
        public string ANC { get; set; }

        //[RegularExpression(Regex.NumbersOnly)]
        [DisplayName("APP")]
        public string APP { get; set; }

        [DisplayName("Custody Id")]
        public string CustodyId { get; set; }

        [RegularExpression(Regex.NumbersOnly)]
        [DisplayName("Doc SEC ID")]
        public string DocSecId { get; set; }

        [DisplayName("Manufacturer Name")]
        public string ManufacturerName { get; set; }

        [DisplayName("Cage Code")]
        public string CageCode { get; set; }

        [DisplayName("TSS")]
        public string TSS { get; set; }

        [DisplayName("SLA")]
        public string SLA { get; set; }

        [DisplayName("Old SMIC")]
        public string OldSMIC { get; set; }

        [DisplayName("OSI")]
        public string OSIId { get; set; }

        [DisplayName("Unit Cube")]
        public string UnitCubeId { get; set; }

        public string GroupModelId { get; set; }
        public List<GroupInfoViewModel> GroupModel { get; set; }

        public IEnumerable<SelectListItem> PartCategoryItems { get; set; }
        public IEnumerable<SelectListItem> PartTypeItems { get; set; }

        public IEnumerable<SelectListItem> CurrencyItems { get; set; }
        public IEnumerable<SelectListItem> UnitItems { get; set; }

        public IEnumerable<SelectListItem> MaterialCategoryItems { get; set; }

        public IEnumerable<SelectListItem> APItems { get; set; }
        public IEnumerable<SelectListItem> ACItems { get; set; }
        public IEnumerable<SelectListItem> ASCItems { get; set; }
        public IEnumerable<SelectListItem> ShelfLifeItems { get; set; }
        public IEnumerable<SelectListItem> LeadTimeItems { get; set; }
        public IEnumerable<SelectListItem> OSIItems { get; set; }

        public IEnumerable<SelectListItem> UnitCubeItems { get; set; }
        public List<CageViewModel> CageDetails { get; set; }

        public List<CageViewModel> VendorDetails { get; set; }

        public DateTime? CreationDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }

    }


    public class PartCategoryViewModel
    {
        public string CategoryId { get; set; }
        public string Description { get; set; }
    }

    public class CurrencyViewModel
    {
        public string ID { get; set; }
        public string Description { get; set; }
    }

    public class UnitItemsViewModel
    {
        public string ID { get; set; }
        public string Description { get; set; }
    }

    public class MaterialCategoryViewModel
    {
        public string ID { get; set; }
        public string Description { get; set; }
    }

    public class MECViewModel
    {
        public string Id { get; set; }
        public string Description { get; set; }
    }

    public class APViewModel
    {
        public string ID { get; set; }
        public string Description { get; set; }
    }

    public class ACViewModel
    {
        public string ID { get; set; }
        public string Description { get; set; }
    }

    public class ASCViewModel
    {
        public string ID { get; set; }
        public string Description { get; set; }
    }

    public class ANCViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class APPViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class CustodyViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class SMCViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class ShelfLifeViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class DerivativeViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class SMICViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class TSSViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class OSIViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class LeadTimeViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class UnitCubeViewModel
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
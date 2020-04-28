using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCamsParts
    {
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string Nsn { get; set; }
        public string UnitOfItem { get; set; }
        public decimal UnitPrice { get; set; }
        public string VendorNo { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string OLevel { get; set; }
        public string DLevel { get; set; }
        public int? TorQty40 { get; set; }
        public int? PorQty40 { get; set; }
        public int? TorQty2y { get; set; }
        public int? PorQty2y { get; set; }
        public string PartCharacteristic { get; set; }
        public string Smr { get; set; }
        public decimal Brf { get; set; }
        public string OldNsn { get; set; }
        public float Diameter { get; set; }
        public string PictureFileName { get; set; }
        public int Mtbf { get; set; }
        public string PmsCCode { get; set; }
        public string TempNsn { get; set; }
        public int UomId { get; set; }
        public string Mcat { get; set; }
        public string PartType { get; set; }
        public int Mec { get; set; }
        public int GroupId { get; set; }
        public int CurrencyId { get; set; }
        public int SlId { get; set; }
        public string PhstCode { get; set; }
        public string ManufacturerNo { get; set; }
        public string Cage { get; set; }
        public string ManufacturerName { get; set; }
        public long ManId { get; set; }
    }
}

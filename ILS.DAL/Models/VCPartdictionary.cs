using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCPartdictionary
    {
        public long PartId { get; set; }
        public long ManId { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string ManCode { get; set; }
        public string Cage { get; set; }
        public string ManufacturerName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddDate { get; set; }
        public string LeditedBy { get; set; }
        public DateTime? LeditedDate { get; set; }
        public int? IsVendor { get; set; }
        public string Remarks { get; set; }
        public string Mcat { get; set; }
        public string McatDesc { get; set; }
        public string PartType { get; set; }
        public string TypeDesc { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Mtbf { get; set; }
        public decimal? Mmtr { get; set; }
        public string PartCharacteristics { get; set; }
        public string Model { get; set; }
        public int? TrId { get; set; }
        public string PartCode { get; set; }
        public int? PersonId { get; set; }
        public int? RevisionNo { get; set; }
        public int? LastUpdateby { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string TempNsn { get; set; }
        public int? UnitOfItem { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Currency { get; set; }
        public string Smr { get; set; }
        public decimal? Brf { get; set; }
        public int? Ap { get; set; }
        public int? Ac { get; set; }
        public string PhstCode { get; set; }
        public int? Asc { get; set; }
        public int? Anc { get; set; }
        public int? App { get; set; }
        public string OldNsn { get; set; }
        public float? Diameter { get; set; }
        public string PictureFileName { get; set; }
        public int? HZECode { get; set; }
        public int? CustodyId { get; set; }
        public int? DocSecId { get; set; }
        public int? SmcId { get; set; }
        public int? TssId { get; set; }
        public int? SlaId { get; set; }
        public int? ShelfLifeId { get; set; }
        public int? DerivativeId { get; set; }
        public int? LeadTimeId { get; set; }
        public int? Smic { get; set; }
        public int? OldSmic { get; set; }
        public int? Osi { get; set; }
        public int? UnitCube { get; set; }
        public string PmsCCode { get; set; }
        public string PartCat { get; set; }
        public int CpartCount { get; set; }
        public int TotalCparts { get; set; }
    }
}

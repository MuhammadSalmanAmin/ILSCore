using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VMTaskParts
    {
        public string PmsNo { get; set; }
        public string MopNo { get; set; }
        public long PartId { get; set; }
        public string DocNo { get; set; }
        public float Qty { get; set; }
        public long ManId { get; set; }
        public string PartType { get; set; }
        public string PartCat { get; set; }
        public string Mcat { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Mtbf { get; set; }
        public decimal? Mmtr { get; set; }
        public string PartCharacteristics { get; set; }
        public string Model { get; set; }
        public string Nsn { get; set; }
        public string UnitOfItem { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Currency { get; set; }
        public string VendorNo { get; set; }
        public string OLevel { get; set; }
        public string DLevel { get; set; }
        public int? PartMec { get; set; }
        public int? TorQty40 { get; set; }
        public int? PorQty40 { get; set; }
        public int? TorQty2y { get; set; }
        public int? PorQty2y { get; set; }
        public string Smr { get; set; }
        public decimal? Brf { get; set; }
        public string Ap { get; set; }
        public string Ac { get; set; }
        public string PhstCode { get; set; }
        public string Asc { get; set; }
        public string Anc { get; set; }
        public string App { get; set; }
        public string OldNsn { get; set; }
        public float? Diameter { get; set; }
        public string PictureFileName { get; set; }
        public string HZECode { get; set; }
        public string CustodyId { get; set; }
        public string DocSecId { get; set; }
        public string SmcId { get; set; }
        public string TssId { get; set; }
        public string SlaId { get; set; }
        public string ShelfLifeId { get; set; }
        public string DerivativeId { get; set; }
        public string LeadTimeId { get; set; }
        public string Smic { get; set; }
        public string OldSmic { get; set; }
        public string Osi { get; set; }
        public string UnitCube { get; set; }
        public string PmsCCode { get; set; }
        public string PartCode { get; set; }
        public short? PermanentData { get; set; }
    }
}

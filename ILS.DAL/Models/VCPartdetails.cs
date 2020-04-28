using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCPartdetails
    {
        public long PartId { get; set; }
        public long ManId { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string ManCode { get; set; }
        public string Cage { get; set; }
        public string ManufacturerName { get; set; }
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
        public string PartCode { get; set; }
        public string Model { get; set; }
        public int? PersonId { get; set; }
        public int? RevisionNo { get; set; }
        public int? LastUpdateby { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}

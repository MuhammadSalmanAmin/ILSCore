using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCPartinfo
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
        public decimal? Nrc { get; set; }
        public decimal? PriceBuy { get; set; }
        public decimal? SpefRep { get; set; }
        public decimal? DisposalCost { get; set; }
        public decimal? EolSalv { get; set; }
        public decimal? EolEnvCln { get; set; }
        public decimal? UcIncr { get; set; }
        public decimal? UcTotal { get; set; }
        public int? RefYear { get; set; }
        public decimal? Rr { get; set; }
        public decimal? LotSize { get; set; }
        public decimal? Scc { get; set; }
        public int? Currency { get; set; }
        public decimal? MiFailR { get; set; }
        public decimal? Rip { get; set; }
        public decimal? RtOk { get; set; }
        public int? Plt { get; set; }
        public int? Rlt { get; set; }
        public int? Rcto { get; set; }
        public int? Rcti { get; set; }
        public int? Rctd { get; set; }
        public int? Rctc { get; set; }
        public double? WtInc { get; set; }
        public double? WtTotal { get; set; }
        public int? Scl { get; set; }
        public string CurrCode { get; set; }
        public string CurrName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCPartdetails
    {
        public long PartId { get; set; }
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

        public virtual MimsCParts Part { get; set; }
    }
}

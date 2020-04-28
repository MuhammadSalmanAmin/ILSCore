using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsIBins
    {
        public int? RackId { get; set; }
        public int BinId { get; set; }
        public string BinNo { get; set; }
        public string BinDesc { get; set; }

        public virtual MimsIRacks Rack { get; set; }
    }
}

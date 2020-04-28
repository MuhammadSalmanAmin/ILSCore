using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class CamsAplPartsList
    {
        public string AplNo { get; set; }
        public string ManufacturerNo { get; set; }
        public string PartNo { get; set; }
        public string TpiNo { get; set; }
        public string DrawingNo { get; set; }
        public string PositionNo { get; set; }
        public string PageNo { get; set; }
        public short? Qty { get; set; }
        public string Smr { get; set; }
    }
}

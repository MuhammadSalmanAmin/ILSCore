using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsRRequsition
    {
        public int ReqId { get; set; }
        public string ReqNo { get; set; }
        public int? SiteNo { get; set; }
        public string Eswbs { get; set; }
        public string PmsNo { get; set; }
        public string MopNo { get; set; }
        public string ReqRemarks { get; set; }

        public virtual MimsMTaskmaster MimsMTaskmaster { get; set; }
    }
}

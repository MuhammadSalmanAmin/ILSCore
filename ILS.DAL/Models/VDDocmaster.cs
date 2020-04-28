using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VDDocmaster
    {
        public int DocId { get; set; }
        public string DocNo { get; set; }
        public int? DocType { get; set; }
        public string DocTypeDesc { get; set; }
        public string DocName { get; set; }
        public string DocFile { get; set; }
        public string DocRemarks { get; set; }
    }
}

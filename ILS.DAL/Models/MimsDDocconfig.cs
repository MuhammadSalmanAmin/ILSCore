using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsDDocconfig
    {
        public int SiteNo { get; set; }
        public string Eswbs { get; set; }
        public int DocId { get; set; }
        public string Remarks { get; set; }

        public virtual MimsDDocmaster Doc { get; set; }
    }
}

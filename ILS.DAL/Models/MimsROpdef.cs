using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsROpdef
    {
        public int OpdefId { get; set; }
        public int? SiteNo { get; set; }
        public string Eswbs { get; set; }
        public string OpdefNo { get; set; }
        public string OpdefCat { get; set; }
        public DateTime? DefectDate { get; set; }
        public DateTime? OpdefDate { get; set; }
        public string DefectDetails { get; set; }
        public string DefectRemarks { get; set; }

        public virtual MimsROpdefcat OpdefCatNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsMEswbspms
    {
        public int SiteNo { get; set; }
        public string Eswbs { get; set; }
        public string PmsNo { get; set; }
        public string MopNo { get; set; }
        public int? Applicable { get; set; }
        public string Remarks { get; set; }
        public int? Period { get; set; }
        public int? PeriodCode { get; set; }
        public int? PeriodHour { get; set; }

        public virtual MimsXYesno ApplicableNavigation { get; set; }
        public virtual MimsMTaskmaster MimsMTaskmaster { get; set; }
        public virtual MimsXTimeperiod PeriodCodeNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXTimeperiod
    {
        public MimsXTimeperiod()
        {
            MimsCParts = new HashSet<MimsCParts>();
            MimsMEswbspms = new HashSet<MimsMEswbspms>();
            MimsMTaskmaster = new HashSet<MimsMTaskmaster>();
        }

        public string TimeperiodCode { get; set; }
        public string TimeperiodDesc { get; set; }
        public int TimeperiodId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
        public virtual ICollection<MimsMEswbspms> MimsMEswbspms { get; set; }
        public virtual ICollection<MimsMTaskmaster> MimsMTaskmaster { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsMTaskParts
    {
        public string PmsNo { get; set; }
        public string MopNo { get; set; }
        public long PartId { get; set; }
        public string DocNo { get; set; }
        public string Nsn { get; set; }
        public float Qty { get; set; }
        public short? PermanentData { get; set; }
        public int? UpdateStatus { get; set; }
        public int? UpdateRevision { get; set; }

        public virtual MimsCParts Part { get; set; }
        public virtual MimsMPms PmsNoNavigation { get; set; }
    }
}

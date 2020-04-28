using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCCparts
    {
        public long Part { get; set; }
        public long PartId { get; set; }
        public int? Qty { get; set; }
        public int? IsApl { get; set; }
        public int? IsSnsl { get; set; }

        public virtual MimsXYesno IsAplNavigation { get; set; }
        public virtual MimsXYesno IsSnslNavigation { get; set; }
        public virtual MimsCParts Part1 { get; set; }
        public virtual MimsCParts PartNavigation { get; set; }
    }
}

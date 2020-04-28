using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCPartvendors
    {
        public long PartId { get; set; }
        public long VendorId { get; set; }
        public int? Active { get; set; }

        public virtual MimsXYesno ActiveNavigation { get; set; }
        public virtual MimsCParts Part { get; set; }
        public virtual MimsCVendors Vendor { get; set; }
    }
}

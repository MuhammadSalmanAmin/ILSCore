using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsWorkorderType
    {
        public MimsWorkorderType()
        {
            MimsWWorkorder = new HashSet<MimsWWorkorder>();
        }

        public int WoTypeId { get; set; }
        public string WoTypeName { get; set; }

        public virtual ICollection<MimsWWorkorder> MimsWWorkorder { get; set; }
    }
}

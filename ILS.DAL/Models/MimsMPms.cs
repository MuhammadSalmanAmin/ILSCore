using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsMPms
    {
        public MimsMPms()
        {
            MimsCUnitconfig = new HashSet<MimsCUnitconfig>();
            MimsMTaskParts = new HashSet<MimsMTaskParts>();
            MimsMTaskmaster = new HashSet<MimsMTaskmaster>();
        }

        public string PmsNo { get; set; }
        public string PmsDesc { get; set; }
        public long? PartId { get; set; }

        public virtual MimsCParts Part { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfig { get; set; }
        public virtual ICollection<MimsMTaskParts> MimsMTaskParts { get; set; }
        public virtual ICollection<MimsMTaskmaster> MimsMTaskmaster { get; set; }
    }
}

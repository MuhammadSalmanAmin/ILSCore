using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXUom
    {
        public MimsXUom()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string UomName { get; set; }
        public string UomDesc { get; set; }
        public int UomId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}

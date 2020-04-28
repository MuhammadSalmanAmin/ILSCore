using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXUom
    {
        public MimsXUom()
        {
            MimsCPartsUnitCubeNavigation = new HashSet<MimsCParts>();
            MimsCPartsUnitOfItemNavigation = new HashSet<MimsCParts>();
        }

        public string UomName { get; set; }
        public string UomDesc { get; set; }
        public int UomId { get; set; }

        public virtual ICollection<MimsCParts> MimsCPartsUnitCubeNavigation { get; set; }
        public virtual ICollection<MimsCParts> MimsCPartsUnitOfItemNavigation { get; set; }
    }
}

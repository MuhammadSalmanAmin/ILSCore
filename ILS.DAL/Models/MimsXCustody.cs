using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXCustody
    {
        public MimsXCustody()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string CustodyCode { get; set; }
        public string CustodyDesc { get; set; }
        public int CustodyId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}

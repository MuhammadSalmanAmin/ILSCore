using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXDerivative
    {
        public MimsXDerivative()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string DerivativeCode { get; set; }
        public string DerivativeDesc { get; set; }
        public int DerivativeId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}

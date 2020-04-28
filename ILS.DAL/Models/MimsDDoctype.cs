using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsDDoctype
    {
        public MimsDDoctype()
        {
            MimsDDocmaster = new HashSet<MimsDDocmaster>();
        }

        public int DocTypeId { get; set; }
        public string DocTypeDesc { get; set; }

        public virtual ICollection<MimsDDocmaster> MimsDDocmaster { get; set; }
    }
}

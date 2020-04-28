using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsROpdefcat
    {
        public MimsROpdefcat()
        {
            MimsROpdef = new HashSet<MimsROpdef>();
        }

        public string OpdefCatNo { get; set; }
        public string OpdefCatDesc { get; set; }

        public virtual ICollection<MimsROpdef> MimsROpdef { get; set; }
    }
}

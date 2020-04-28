using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsDDocmaster
    {
        public MimsDDocmaster()
        {
            MimsDDocconfig = new HashSet<MimsDDocconfig>();
        }

        public int DocId { get; set; }
        public string DocNo { get; set; }
        public int? DocType { get; set; }
        public string DocName { get; set; }
        public string DocFile { get; set; }
        public string DocRemarks { get; set; }

        public virtual MimsDDoctype DocTypeNavigation { get; set; }
        public virtual ICollection<MimsDDocconfig> MimsDDocconfig { get; set; }
    }
}

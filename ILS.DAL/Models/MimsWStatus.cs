using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsWStatus
    {
        public MimsWStatus()
        {
            MimsWWorkorder = new HashSet<MimsWWorkorder>();
        }

        public int StatusId { get; set; }
        public string StatusDesc { get; set; }
        public string StatusCode { get; set; }

        public virtual ICollection<MimsWWorkorder> MimsWWorkorder { get; set; }
    }
}

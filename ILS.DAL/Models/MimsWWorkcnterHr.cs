using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsWWorkcnterHr
    {
        public int PersonId { get; set; }
        public int AttachWorkCenter { get; set; }
        public int BornWorkCenter { get; set; }

        public virtual MimsWWorkcenters AttachWorkCenterNavigation { get; set; }
        public virtual MimsHPerson Person { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsWWorkcenters
    {
        public MimsWWorkcenters()
        {
            MimsWWorkcnterHr = new HashSet<MimsWWorkcnterHr>();
        }

        public int WorkCenterId { get; set; }
        public string WorkCenterNo { get; set; }
        public string WorkCenterName { get; set; }
        public int? WorkCenterType { get; set; }
        public string WorkCenterDesc { get; set; }
        public decimal? WorlCenterArea { get; set; }
        public string WorkCenterLoc { get; set; }
        public decimal? WorkCenterLat { get; set; }
        public decimal? WorkCenterLong { get; set; }
        public byte[] WorkCenterPic { get; set; }
        public byte[] WorkCenterMap { get; set; }

        public virtual ICollection<MimsWWorkcnterHr> MimsWWorkcnterHr { get; set; }
    }
}

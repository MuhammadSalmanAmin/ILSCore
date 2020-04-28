using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsHRankType
    {
        public MimsHRankType()
        {
            MimsHRanks = new HashSet<MimsHRanks>();
        }

        public int RankType { get; set; }
        public string RankTypeName { get; set; }

        public virtual ICollection<MimsHRanks> MimsHRanks { get; set; }
    }
}

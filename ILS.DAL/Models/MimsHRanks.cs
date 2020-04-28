using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsHRanks
    {
        public MimsHRanks()
        {
            MimsHPerson = new HashSet<MimsHPerson>();
        }

        public int RankId { get; set; }
        public string RankName { get; set; }
        public string RankGrade { get; set; }
        public int? RankType { get; set; }

        public virtual MimsHRankType RankTypeNavigation { get; set; }
        public virtual ICollection<MimsHPerson> MimsHPerson { get; set; }
    }
}

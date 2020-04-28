using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCCountry
    {
        public MimsCCountry()
        {
            MimsCCage = new HashSet<MimsCCage>();
        }

        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<MimsCCage> MimsCCage { get; set; }
    }
}

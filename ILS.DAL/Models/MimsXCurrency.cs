using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXCurrency
    {
        public MimsXCurrency()
        {
            MimsCParts = new HashSet<MimsCParts>();
        }

        public string CurrCode { get; set; }
        public string CurrName { get; set; }
        public decimal? CurrConvRate { get; set; }
        public int CurrencyId { get; set; }

        public virtual ICollection<MimsCParts> MimsCParts { get; set; }
    }
}

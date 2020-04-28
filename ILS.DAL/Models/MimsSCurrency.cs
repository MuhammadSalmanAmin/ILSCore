using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsSCurrency
    {
        public int CurrencyId { get; set; }
        public string CurrCode { get; set; }
        public string CurrName { get; set; }
        public decimal? CurrConvRate { get; set; }
    }
}

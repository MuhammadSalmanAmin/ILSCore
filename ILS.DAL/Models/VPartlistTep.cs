using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VPartlistTep
    {
        public long PartId { get; set; }
        public short? Qty { get; set; }
        public long Part { get; set; }
    }
}

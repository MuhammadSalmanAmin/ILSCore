using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VMPms
    {
        public long PartId { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string Model { get; set; }
        public string PmsNo { get; set; }
    }
}

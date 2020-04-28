using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCCparts
    {
        public long Part { get; set; }
        public long ManId { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string PartType { get; set; }
        public string Mcat { get; set; }
        public string Model { get; set; }
        public long CmanId { get; set; }
        public string CpartNo { get; set; }
        public string CpartName { get; set; }
        public string Cmcat { get; set; }
        public string CpartType { get; set; }
        public string Cmodel { get; set; }
        public string TypeDesc { get; set; }
        public string CtypeDesc { get; set; }
        public long PartId { get; set; }
        public int? Qty { get; set; }
        public int? IsApl { get; set; }
        public int? IsSnsl { get; set; }
        public string ManCode { get; set; }
        public string Cage { get; set; }
        public string ManufacturerName { get; set; }
        public string ChildMancode { get; set; }
        public string ChildCage { get; set; }
        public string ChildManufacturer { get; set; }
    }
}

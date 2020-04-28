using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VCEqpConfig
    {
        public long? Endpart { get; set; }
        public long? Part { get; set; }
        public long? Ppart { get; set; }
        public string Eswbs { get; set; }
        public string Peswbs { get; set; }
        public string Configid { get; set; }
        public string Pconfigid { get; set; }
        public string Configno { get; set; }
        public string Pconfigno { get; set; }
        public string Configno2 { get; set; }
        public string Pconfigno2 { get; set; }
        public string Partdesc { get; set; }
        public int Ind { get; set; }
        public int Pchildcount { get; set; }
        public int Indchildcount { get; set; }
        public long Trid { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string Cage { get; set; }
        public string ManufacturerName { get; set; }
        public string Country { get; set; }
        public string McatDesc { get; set; }
        public string TypeDesc { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal Mtbf { get; set; }
        public decimal Mmtr { get; set; }
        public string PartCharacteristics { get; set; }
        public string Model { get; set; }
    }
}

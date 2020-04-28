using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCamsConfigurations
    {
        public string Swbs { get; set; }
        public string SiteNo { get; set; }
        public string LocationNo { get; set; }
        public string ParentSwbs { get; set; }
        public string SystemName { get; set; }
        public string ItemSerialNo { get; set; }
        public short? EquipmentPopulation { get; set; }
        public string AplNo { get; set; }
        public int? Mec { get; set; }
        public short? AnnualOperationRequirement { get; set; }
        public string PmsNo { get; set; }
        public int? Mainsystemnumber { get; set; }
        public int? Systemnumber { get; set; }
        public int? Subsystemnumber { get; set; }
        public int? Equipmentnumber { get; set; }
        public int? Equipmentsequencenumber { get; set; }
        public int? Levelnumber { get; set; }
        public int? Levelsequencenumber { get; set; }
        public string PartNo { get; set; }
        public int? Printorder { get; set; }
        public int? Printindent { get; set; }
        public string SwbsOrder { get; set; }
        public string UpkeepCode { get; set; }
        public DateTime? StartDate { get; set; }
        public string DrawingNo { get; set; }
        public short? NoOfChange { get; set; }
        public short? GroupNo { get; set; }
        public string Repairable { get; set; }
        public string CidPage { get; set; }
        public string MajorEquip { get; set; }
        public string ConfigStatus { get; set; }
        public string CidReport { get; set; }
        public string MecReport { get; set; }
        public string CedaReport { get; set; }
        public int? CobQty { get; set; }
        public int? PndQty { get; set; }
        public int? JnbQty { get; set; }
        public int? FmgQty { get; set; }
        public string Csr { get; set; }
        public string RhRec { get; set; }
        public string Mea { get; set; }
        public string Vol { get; set; }
        public int UpdateStatus { get; set; }
        public int UpdateRevision { get; set; }
    }
}

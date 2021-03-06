﻿using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCUnitconfig
    {
        public int SiteNo { get; set; }
        public string Eswbs { get; set; }
        public string Peswbs { get; set; }
        public string Nomenclature { get; set; }
        public long? Partid { get; set; }
        public int? Qty { get; set; }
        public long? Endpart { get; set; }
        public string LocNo { get; set; }
        public int? Mec { get; set; }
        public int? UpkeepCode { get; set; }
        public string DrawingNo { get; set; }
        public short? NoOfChange { get; set; }
        public int? Repairable { get; set; }
        public string Configid { get; set; }
        public string Pconfigid { get; set; }
        public string Configno { get; set; }
        public string Pconfigno { get; set; }
        public string Configno2 { get; set; }
        public string Pconfigno2 { get; set; }
        public string PmsNo { get; set; }
        public string ItemSerialNo { get; set; }
        public short? AnnualOperationRequirement { get; set; }
        public int? Mainsystemnumber { get; set; }
        public int? Systemnumber { get; set; }
        public int? Subsystemnumber { get; set; }
        public int? Equipmentnumber { get; set; }
        public int? Equipmentsequencenumber { get; set; }
        public int? Levelnumber { get; set; }
        public int? Levelsequencenumber { get; set; }
        public int? Printorder { get; set; }
        public int? Printindent { get; set; }
        public string SwbsOrder { get; set; }
        public DateTime? StartDate { get; set; }
        public short? GroupNo { get; set; }
        public string CidPage { get; set; }
        public int? MajorEquip { get; set; }
        public string ConfigStatus { get; set; }
        public int? CidReport { get; set; }
        public int? MecReport { get; set; }
        public int? CedaReport { get; set; }
        public int? CobQty { get; set; }
        public int? PndQty { get; set; }
        public int? JnbQty { get; set; }
        public int? FmgQty { get; set; }
        public int? Csr { get; set; }
        public int RhRec { get; set; }
        public string Mea { get; set; }
        public string Vol { get; set; }

        public virtual MimsXYesno CedaReportNavigation { get; set; }
        public virtual MimsXYesno CidReportNavigation { get; set; }
        public virtual MimsXYesno CsrNavigation { get; set; }
        public virtual MimsCParts EndpartNavigation { get; set; }
        public virtual MimsXYesno MajorEquipNavigation { get; set; }
        public virtual MimsXCmec MecNavigation { get; set; }
        public virtual MimsXYesno MecReportNavigation { get; set; }
        public virtual MimsCParts Part { get; set; }
        public virtual MimsMPms PmsNoNavigation { get; set; }
        public virtual MimsXYesno RepairableNavigation { get; set; }
        public virtual MimsXUpkeep UpkeepCodeNavigation { get; set; }
    }
}

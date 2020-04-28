using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class VMTaskmaster
    {
        public long PartId { get; set; }
        public string PartName { get; set; }
        public string PmsNo { get; set; }
        public string DocNo { get; set; }
        public string MopNo { get; set; }
        public string Jic { get; set; }
        public string Description { get; set; }
        public string ByWhom { get; set; }
        public int? Period { get; set; }
        public string PeriodCode { get; set; }
        public int? PeriodHour { get; set; }
        public DateTime? Duedate { get; set; }
        public long? NumberOfPeriodDate { get; set; }
        public int? NumberOfManEl { get; set; }
        public int? NumberOfManMc { get; set; }
        public int? NumberOfManEe { get; set; }
        public float? ManHourEl { get; set; }
        public float? ManHourMc { get; set; }
        public float? ManHourEe { get; set; }
        public float? ElapsedTime { get; set; }
        public string SafetyPrecaution { get; set; }
        public string TaskProcedure { get; set; }
        public string UpkeepCode { get; set; }
        public int? Report { get; set; }
        public int? Reportline { get; set; }
        public string Alias { get; set; }
        public string AliasSwbs { get; set; }
        public string TmlReq { get; set; }
        public string RepairablePoolReq { get; set; }
        public string DrydockReq { get; set; }
        public string Removal { get; set; }
        public string Remark { get; set; }
        public string TaskEssentialNo { get; set; }
        public string RefitPk { get; set; }
        public string Mtr { get; set; }
        public string ExceptMop { get; set; }
        public int? UpdateStatus { get; set; }
        public int? UpdateRevision { get; set; }
    }
}

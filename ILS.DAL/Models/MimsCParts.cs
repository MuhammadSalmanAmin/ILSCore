using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsCParts
    {
        public MimsCParts()
        {
            MimsCApl = new HashSet<MimsCApl>();
            MimsCCpartsPart1 = new HashSet<MimsCCparts>();
            MimsCCpartsPartNavigation = new HashSet<MimsCCparts>();
            MimsCEqpConfig_1Navigation = new HashSet<MimsCEqpConfig>();
            MimsCEqpConfig_2Navigation = new HashSet<MimsCEqpConfig>();
            MimsCEqpConfig_3Navigation = new HashSet<MimsCEqpConfig>();
            MimsCPartvendorlist = new HashSet<MimsCPartvendorlist>();
            MimsCPartvendors = new HashSet<MimsCPartvendors>();
            MimsCUnitconfigEndpartNavigation = new HashSet<MimsCUnitconfig>();
            MimsCUnitconfigPart = new HashSet<MimsCUnitconfig>();
            MimsIDemands = new HashSet<MimsIDemands>();
            MimsMPms = new HashSet<MimsMPms>();
            MimsMTaskParts = new HashSet<MimsMTaskParts>();
        }

        public long ManId { get; set; }
        public string PartType { get; set; }
        public string PartCat { get; set; }
        public string Mcat { get; set; }
        public string PartNo { get; set; }
        public string TempNsn { get; set; }
        public string PartName { get; set; }
        public string PartCharacteristics { get; set; }
        public string PictureFileName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Currency { get; set; }
        public string Smr { get; set; }
        public decimal? Brf { get; set; }
        public int? UnitOfItem { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Mtbf { get; set; }
        public decimal? Mmtr { get; set; }
        public float? Diameter { get; set; }
        public string VendorNo { get; set; }
        public string OldNsn { get; set; }
        public int? PartMec { get; set; }
        public int? HZECode { get; set; }
        public string PhstCode { get; set; }
        public int? ShelfLifeId { get; set; }
        public int? Ap { get; set; }
        public int? Ac { get; set; }
        public int? Asc { get; set; }
        public int? Anc { get; set; }
        public int? App { get; set; }
        public int? CustodyId { get; set; }
        public int? DocSecId { get; set; }
        public int? SmcId { get; set; }
        public int? TssId { get; set; }
        public int? SlaId { get; set; }
        public int? DerivativeId { get; set; }
        public int? LeadTimeId { get; set; }
        public int? Smic { get; set; }
        public int? OldSmic { get; set; }
        public int? Osi { get; set; }
        public int? UnitCube { get; set; }
        public string PartCode { get; set; }
        public string PmsCCode { get; set; }
        public byte[] PartImg { get; set; }
        public string Model { get; set; }
        public int? TrId { get; set; }
        public int? PersonId { get; set; }
        public int? RevisionNo { get; set; }
        public int? LastUpdateby { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string OLevel { get; set; }
        public string DLevel { get; set; }
        public int? TorQty40 { get; set; }
        public int? PorQty40 { get; set; }
        public int? TorQty2y { get; set; }
        public int? PorQty2y { get; set; }
        public long PartId { get; set; }

        public virtual MimsXAc AcNavigation { get; set; }
        public virtual MimsXAnc AncNavigation { get; set; }
        public virtual MimsXAp ApNavigation { get; set; }
        public virtual MimsXApp AppNavigation { get; set; }
        public virtual MimsXAsc AscNavigation { get; set; }
        public virtual MimsXCurrency CurrencyNavigation { get; set; }
        public virtual MimsXCustody Custody { get; set; }
        public virtual MimsXDerivative Derivative { get; set; }
        public virtual MimsXSecurity DocSec { get; set; }
        public virtual MimsXGroup HZECodeNavigation { get; set; }
        public virtual MimsXTimeperiod LeadTime { get; set; }
        public virtual MimsCCage Man { get; set; }
        public virtual MimsCMcat McatNavigation { get; set; }
        public virtual MimsXSmic OldSmicNavigation { get; set; }
        public virtual MimsXOsi OsiNavigation { get; set; }
        public virtual MimsCPartcat PartCatNavigation { get; set; }
        public virtual MimsXMec PartMecNavigation { get; set; }
        public virtual MimsCParttype PartTypeNavigation { get; set; }
        public virtual MimsXShelflife ShelfLife { get; set; }
        public virtual MimsXSla Sla { get; set; }
        public virtual MimsXSmc Smc { get; set; }
        public virtual MimsXSmic SmicNavigation { get; set; }
        public virtual MimsXTss Tss { get; set; }
        public virtual MimsXUom UnitCubeNavigation { get; set; }
        public virtual MimsXUom UnitOfItemNavigation { get; set; }
        public virtual MimsCPartdetails MimsCPartdetails { get; set; }
        public virtual ICollection<MimsCApl> MimsCApl { get; set; }
        public virtual ICollection<MimsCCparts> MimsCCpartsPart1 { get; set; }
        public virtual ICollection<MimsCCparts> MimsCCpartsPartNavigation { get; set; }
        public virtual ICollection<MimsCEqpConfig> MimsCEqpConfig_1Navigation { get; set; }
        public virtual ICollection<MimsCEqpConfig> MimsCEqpConfig_2Navigation { get; set; }
        public virtual ICollection<MimsCEqpConfig> MimsCEqpConfig_3Navigation { get; set; }
        public virtual ICollection<MimsCPartvendorlist> MimsCPartvendorlist { get; set; }
        public virtual ICollection<MimsCPartvendors> MimsCPartvendors { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfigEndpartNavigation { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfigPart { get; set; }
        public virtual ICollection<MimsIDemands> MimsIDemands { get; set; }
        public virtual ICollection<MimsMPms> MimsMPms { get; set; }
        public virtual ICollection<MimsMTaskParts> MimsMTaskParts { get; set; }
    }
}

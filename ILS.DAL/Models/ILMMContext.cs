using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ILS.DAL.Models
{
    public partial class ILMMContext : DbContext
    {
        public ILMMContext()
        {
        }

        public ILMMContext(DbContextOptions<ILMMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CamsAplPartsList> CamsAplPartsList { get; set; }
        public virtual DbSet<CamsApls> CamsApls { get; set; }
        public virtual DbSet<CamsManufacturers> CamsManufacturers { get; set; }
        public virtual DbSet<CamsParts> CamsParts { get; set; }
        public virtual DbSet<CamsTaskParts> CamsTaskParts { get; set; }
        public virtual DbSet<CamsTasks> CamsTasks { get; set; }
        public virtual DbSet<MimsACommand> MimsACommand { get; set; }
        public virtual DbSet<MimsASiteStat> MimsASiteStat { get; set; }
        public virtual DbSet<MimsASites> MimsASites { get; set; }
        public virtual DbSet<MimsATcommand> MimsATcommand { get; set; }
        public virtual DbSet<MimsCApl> MimsCApl { get; set; }
        public virtual DbSet<MimsCCage> MimsCCage { get; set; }
        public virtual DbSet<MimsCCountry> MimsCCountry { get; set; }
        public virtual DbSet<MimsCCparts> MimsCCparts { get; set; }
        public virtual DbSet<MimsCEqpConfig> MimsCEqpConfig { get; set; }
        public virtual DbSet<MimsCEqpConfig2> MimsCEqpConfig2 { get; set; }
        public virtual DbSet<MimsCMasterconfig> MimsCMasterconfig { get; set; }
        public virtual DbSet<MimsCMcat> MimsCMcat { get; set; }
        public virtual DbSet<MimsCPartcat> MimsCPartcat { get; set; }
        public virtual DbSet<MimsCPartdetails> MimsCPartdetails { get; set; }
        public virtual DbSet<MimsCParts> MimsCParts { get; set; }
        public virtual DbSet<MimsCParttype> MimsCParttype { get; set; }
        public virtual DbSet<MimsCPartvendorlist> MimsCPartvendorlist { get; set; }
        public virtual DbSet<MimsCPartvendors> MimsCPartvendors { get; set; }
        public virtual DbSet<MimsCUnitconfig> MimsCUnitconfig { get; set; }
        public virtual DbSet<MimsCVendors> MimsCVendors { get; set; }
        public virtual DbSet<MimsCamsConfigurations> MimsCamsConfigurations { get; set; }
        public virtual DbSet<MimsDDocconfig> MimsDDocconfig { get; set; }
        public virtual DbSet<MimsDDocmaster> MimsDDocmaster { get; set; }
        public virtual DbSet<MimsDDoctype> MimsDDoctype { get; set; }
        public virtual DbSet<MimsHPerson> MimsHPerson { get; set; }
        public virtual DbSet<MimsHRankType> MimsHRankType { get; set; }
        public virtual DbSet<MimsHRanks> MimsHRanks { get; set; }
        public virtual DbSet<MimsHSkilledhr> MimsHSkilledhr { get; set; }
        public virtual DbSet<MimsHSkills> MimsHSkills { get; set; }
        public virtual DbSet<MimsIBins> MimsIBins { get; set; }
        public virtual DbSet<MimsIDemandissued> MimsIDemandissued { get; set; }
        public virtual DbSet<MimsIDemands> MimsIDemands { get; set; }
        public virtual DbSet<MimsIDepot> MimsIDepot { get; set; }
        public virtual DbSet<MimsIGroup> MimsIGroup { get; set; }
        public virtual DbSet<MimsIInventory> MimsIInventory { get; set; }
        public virtual DbSet<MimsIRacks> MimsIRacks { get; set; }
        public virtual DbSet<MimsIWarehouse> MimsIWarehouse { get; set; }
        public virtual DbSet<MimsMDoccat> MimsMDoccat { get; set; }
        public virtual DbSet<MimsMEswbspms> MimsMEswbspms { get; set; }
        public virtual DbSet<MimsMPms> MimsMPms { get; set; }
        public virtual DbSet<MimsMTaskParts> MimsMTaskParts { get; set; }
        public virtual DbSet<MimsMTaskmaster> MimsMTaskmaster { get; set; }
        public virtual DbSet<MimsROpdef> MimsROpdef { get; set; }
        public virtual DbSet<MimsROpdefcat> MimsROpdefcat { get; set; }
        public virtual DbSet<MimsRRequsition> MimsRRequsition { get; set; }
        public virtual DbSet<MimsSCurrency> MimsSCurrency { get; set; }
        public virtual DbSet<MimsWStatus> MimsWStatus { get; set; }
        public virtual DbSet<MimsWWorkcenters> MimsWWorkcenters { get; set; }
        public virtual DbSet<MimsWWorkcnterHr> MimsWWorkcnterHr { get; set; }
        public virtual DbSet<MimsWWorkorder> MimsWWorkorder { get; set; }
        public virtual DbSet<MimsWoWorkcenters> MimsWoWorkcenters { get; set; }
        public virtual DbSet<MimsWorkorderType> MimsWorkorderType { get; set; }
        public virtual DbSet<MimsXAc> MimsXAc { get; set; }
        public virtual DbSet<MimsXAnc> MimsXAnc { get; set; }
        public virtual DbSet<MimsXAp> MimsXAp { get; set; }
        public virtual DbSet<MimsXApp> MimsXApp { get; set; }
        public virtual DbSet<MimsXAsc> MimsXAsc { get; set; }
        public virtual DbSet<MimsXCmec> MimsXCmec { get; set; }
        public virtual DbSet<MimsXCurrency> MimsXCurrency { get; set; }
        public virtual DbSet<MimsXCustody> MimsXCustody { get; set; }
        public virtual DbSet<MimsXDemandStatus> MimsXDemandStatus { get; set; }
        public virtual DbSet<MimsXDemandtype> MimsXDemandtype { get; set; }
        public virtual DbSet<MimsXDerivative> MimsXDerivative { get; set; }
        public virtual DbSet<MimsXGroup> MimsXGroup { get; set; }
        public virtual DbSet<MimsXMec> MimsXMec { get; set; }
        public virtual DbSet<MimsXOsi> MimsXOsi { get; set; }
        public virtual DbSet<MimsXSecurity> MimsXSecurity { get; set; }
        public virtual DbSet<MimsXShelflife> MimsXShelflife { get; set; }
        public virtual DbSet<MimsXSla> MimsXSla { get; set; }
        public virtual DbSet<MimsXSmc> MimsXSmc { get; set; }
        public virtual DbSet<MimsXSmic> MimsXSmic { get; set; }
        public virtual DbSet<MimsXTimeperiod> MimsXTimeperiod { get; set; }
        public virtual DbSet<MimsXTss> MimsXTss { get; set; }
        public virtual DbSet<MimsXUom> MimsXUom { get; set; }
        public virtual DbSet<MimsXUpkeep> MimsXUpkeep { get; set; }
        public virtual DbSet<MimsXYesno> MimsXYesno { get; set; }
        public virtual DbSet<VASiteStat> VASiteStat { get; set; }
        public virtual DbSet<VCApl> VCApl { get; set; }
        public virtual DbSet<VCConfigSystems> VCConfigSystems { get; set; }
        public virtual DbSet<VCCpartCount> VCCpartCount { get; set; }
        public virtual DbSet<VCCparts> VCCparts { get; set; }
        public virtual DbSet<VCEqpConfig> VCEqpConfig { get; set; }
        public virtual DbSet<VCPartdetails> VCPartdetails { get; set; }
        public virtual DbSet<VCPartdictionary> VCPartdictionary { get; set; }
        public virtual DbSet<VCPartinfo> VCPartinfo { get; set; }
        public virtual DbSet<VCUconfigSystemchilds> VCUconfigSystemchilds { get; set; }
        public virtual DbSet<VCUconigChildcount> VCUconigChildcount { get; set; }
        public virtual DbSet<VCUnitconfig> VCUnitconfig { get; set; }
        public virtual DbSet<VCamsParts> VCamsParts { get; set; }
        public virtual DbSet<VCasaplparts> VCasaplparts { get; set; }
        public virtual DbSet<VDDocconfig> VDDocconfig { get; set; }
        public virtual DbSet<VDDocmaster> VDDocmaster { get; set; }
        public virtual DbSet<VMPms> VMPms { get; set; }
        public virtual DbSet<VMTaskParts> VMTaskParts { get; set; }
        public virtual DbSet<VMTaskmaster> VMTaskmaster { get; set; }
        public virtual DbSet<VPartlistTep> VPartlistTep { get; set; }
        public virtual DbSet<VUconfigSystemchilds> VUconfigSystemchilds { get; set; }
        public virtual DbSet<View1> View1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ILMM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CamsAplPartsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMS_APL_PARTS_LIST");

                entity.Property(e => e.AplNo)
                    .IsRequired()
                    .HasColumnName("APL_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingNo)
                    .HasColumnName("DRAWING_NO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerNo)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PageNo)
                    .HasColumnName("PAGE_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionNo)
                    .HasColumnName("POSITION_NO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Smr)
                    .HasColumnName("SMR")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TpiNo)
                    .IsRequired()
                    .HasColumnName("TPI_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CamsApls>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMS_APLS");

                entity.Property(e => e.AplName)
                    .HasColumnName("APL_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AplNo)
                    .IsRequired()
                    .HasColumnName("APL_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AplPartno)
                    .HasColumnName("APL_PARTNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clsgrp)
                    .HasColumnName("CLSGRP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerNo)
                    .HasColumnName("MANUFACTURER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Niin)
                    .HasColumnName("NIIN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Nsn)
                    .HasColumnName("NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CamsManufacturers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMS_MANUFACTURERS");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerImg)
                    .HasColumnName("MANUFACTURER_IMG")
                    .HasColumnType("image");

                entity.Property(e => e.ManufacturerMap)
                    .HasColumnName("MANUFACTURER_MAP")
                    .HasColumnType("image");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerNo)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .HasColumnName("TEL_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateRevision).HasColumnName("UPDATE_REVISION");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("UPDATE_STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VendorNo)
                    .HasColumnName("VENDOR_NO")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CamsParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMS_PARTS");

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Anc)
                    .HasColumnName("ANC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ap)
                    .HasColumnName("AP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.App)
                    .HasColumnName("APP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asc)
                    .HasColumnName("ASC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Brf)
                    .HasColumnName("BRF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustodyId)
                    .HasColumnName("CUSTODY_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DLevel)
                    .HasColumnName("D_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DerivativeId)
                    .HasColumnName("DERIVATIVE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Diameter).HasColumnName("DIAMETER");

                entity.Property(e => e.DocSecId)
                    .HasColumnName("DOC_SEC_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HZECode)
                    .HasColumnName("H_Z_E_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.LeadTimeId)
                    .HasColumnName("LEAD_TIME_ID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.ManufacturerNo)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Mcat)
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mtbf).HasColumnName("MTBF");

                entity.Property(e => e.Nsn)
                    .IsRequired()
                    .HasColumnName("NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OLevel)
                    .HasColumnName("O_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OldNsn)
                    .HasColumnName("OLD_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OldSmic)
                    .HasColumnName("OLD_SMIC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Osi)
                    .HasColumnName("OSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartCharacteristic)
                    .HasColumnName("PART_CHARACTERISTIC")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PartMec).HasColumnName("PART_MEC");

                entity.Property(e => e.PartName)
                    .HasColumnName("PART_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhstCode)
                    .HasColumnName("PHST_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasColumnName("PICTURE_FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PmsCCode)
                    .HasColumnName("PMS_C_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PorQty2y).HasColumnName("POR_QTY2Y");

                entity.Property(e => e.PorQty40).HasColumnName("POR_QTY40");

                entity.Property(e => e.ShelfLifeId)
                    .HasColumnName("SHELF_LIFE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SlaId)
                    .HasColumnName("SLA_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SmcId)
                    .HasColumnName("SMC_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Smic)
                    .HasColumnName("SMIC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Smr)
                    .HasColumnName("SMR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TempNsn)
                    .HasColumnName("TEMP_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TorQty2y).HasColumnName("TOR_QTY2Y");

                entity.Property(e => e.TorQty40).HasColumnName("TOR_QTY40");

                entity.Property(e => e.TotOnboardPop)
                    .HasColumnName("TOT_ONBOARD_POP")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TotSsPop)
                    .HasColumnName("TOT_SS_POP")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TssId)
                    .HasColumnName("TSS_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCube)
                    .HasColumnName("UNIT_CUBE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfItem)
                    .HasColumnName("UNIT_OF_ITEM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.UpdateRevision).HasColumnName("UPDATE_REVISION");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("UPDATE_STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VendorNo)
                    .HasColumnName("VENDOR_NO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");

                entity.Property(e => e.Width).HasColumnName("WIDTH");
            });

            modelBuilder.Entity<CamsTaskParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMS_TASK_PARTS");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MopNo)
                    .IsRequired()
                    .HasColumnName("MOP_NO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nsn)
                    .IsRequired()
                    .HasColumnName("NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PermanentData).HasColumnName("PERMANENT_DATA");

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.SiteNo)
                    .IsRequired()
                    .HasColumnName("SITE_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Swbs)
                    .IsRequired()
                    .HasColumnName("SWBS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateRevision).HasColumnName("UPDATE_REVISION");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("UPDATE_STATUS")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CamsTasks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMS_TASKS");

                entity.Property(e => e.Alias)
                    .HasColumnName("ALIAS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AliasSwbs)
                    .HasColumnName("ALIAS_SWBS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ByWhom)
                    .HasColumnName("BY_WHOM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DrydockReq)
                    .HasColumnName("DRYDOCK_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Duedate)
                    .HasColumnName("DUEDATE")
                    .HasColumnType("date");

                entity.Property(e => e.ElapsedTime).HasColumnName("ELAPSED_TIME");

                entity.Property(e => e.ExceptMop)
                    .HasColumnName("EXCEPT_MOP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Jic)
                    .HasColumnName("JIC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ManHourEe).HasColumnName("MAN_HOUR_EE");

                entity.Property(e => e.ManHourEl).HasColumnName("MAN_HOUR_EL");

                entity.Property(e => e.ManHourMc).HasColumnName("MAN_HOUR_MC");

                entity.Property(e => e.MopNo)
                    .IsRequired()
                    .HasColumnName("MOP_NO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mtr)
                    .HasColumnName("MTR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfManEe).HasColumnName("NUMBER_OF_MAN_EE");

                entity.Property(e => e.NumberOfManEl).HasColumnName("NUMBER_OF_MAN_EL");

                entity.Property(e => e.NumberOfManMc).HasColumnName("NUMBER_OF_MAN_MC");

                entity.Property(e => e.NumberOfPeriodDate).HasColumnName("NUMBER_OF_PERIOD_DATE");

                entity.Property(e => e.Period).HasColumnName("PERIOD");

                entity.Property(e => e.PeriodCode)
                    .HasColumnName("PERIOD_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodHour).HasColumnName("PERIOD_HOUR");

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.RefitPk)
                    .HasColumnName("REFIT_PK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Removal)
                    .HasColumnName("REMOVAL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RepairablePoolReq)
                    .HasColumnName("REPAIRABLE_POOL_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Report).HasColumnName("REPORT");

                entity.Property(e => e.Reportline).HasColumnName("REPORTLINE");

                entity.Property(e => e.SafetyPrecaution)
                    .HasColumnName("SAFETY_PRECAUTION")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo)
                    .IsRequired()
                    .HasColumnName("SITE_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Swbs)
                    .IsRequired()
                    .HasColumnName("SWBS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TaskEssentialNo)
                    .HasColumnName("TASK_ESSENTIAL_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TaskProcedure)
                    .HasColumnName("TASK_PROCEDURE")
                    .IsUnicode(false);

                entity.Property(e => e.TmlReq)
                    .HasColumnName("TML_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsACommand>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MIMS_A_COMMAND");

                entity.Property(e => e.CommandId).HasColumnName("COMMAND_ID");

                entity.Property(e => e.CommandName)
                    .HasColumnName("COMMAND_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsASiteStat>(entity =>
            {
                entity.HasKey(e => e.SiteNo);

                entity.ToTable("MIMS_A_SITE_STAT");

                entity.Property(e => e.SiteNo)
                    .HasColumnName("SITE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpsAvailability)
                    .HasColumnName("OPS_AVAILABILITY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpsDefect).HasColumnName("OPS_DEFECT");

                entity.Property(e => e.OpsReadiness)
                    .HasColumnName("OPS_READINESS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCommand).HasColumnName("TYPE_COMMAND");
            });

            modelBuilder.Entity<MimsASites>(entity =>
            {
                entity.HasKey(e => e.SiteNo);

                entity.ToTable("MIMS_A_SITES");

                entity.Property(e => e.SiteNo)
                    .HasColumnName("SITE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Configured).HasColumnName("CONFIGURED");

                entity.Property(e => e.InductionDate)
                    .HasColumnName("INDUCTION_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SiteName)
                    .HasColumnName("SITE_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SitePic)
                    .HasColumnName("SITE_PIC")
                    .HasColumnType("image");

                entity.Property(e => e.SiteType)
                    .HasColumnName("SITE_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsATcommand>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MIMS_A_TCOMMAND");

                entity.Property(e => e.Command).HasColumnName("COMMAND");

                entity.Property(e => e.TypeCommand).HasColumnName("TYPE_COMMAND");

                entity.Property(e => e.TypeCommandName)
                    .HasColumnName("TYPE_COMMAND_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsCApl>(entity =>
            {
                entity.HasKey(e => e.AplId);

                entity.ToTable("MIMS_C_APL");

                entity.Property(e => e.AplId).HasColumnName("APL_ID");

                entity.Property(e => e.Apl)
                    .HasColumnName("APL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AplpartId).HasColumnName("APLPART_ID");

                entity.HasOne(d => d.Aplpart)
                    .WithMany(p => p.MimsCApl)
                    .HasForeignKey(d => d.AplpartId)
                    .HasConstraintName("FK_MIMS_C_APL_MIMS_C_PARTS");
            });

            modelBuilder.Entity<MimsCCage>(entity =>
            {
                entity.HasKey(e => e.ManId);

                entity.ToTable("MIMS_C_CAGE");

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.AddBy)
                    .HasColumnName("ADD_BY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate)
                    .HasColumnName("ADD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsVendor).HasColumnName("IS_VENDOR");

                entity.Property(e => e.LeditedBy)
                    .HasColumnName("LEDITED_BY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LeditedDate)
                    .HasColumnName("LEDITED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ManCode)
                    .HasColumnName("MAN_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.MimsCCage)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_MIMS_C_CAGE_MIMS_C_COUNTRY");
            });

            modelBuilder.Entity<MimsCCountry>(entity =>
            {
                entity.HasKey(e => e.CountryName);

                entity.ToTable("MIMS_C_COUNTRY");

                entity.Property(e => e.CountryName)
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("COUNTRY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsCCparts>(entity =>
            {
                entity.HasKey(e => new { e.Part, e.PartId });

                entity.ToTable("MIMS_C_CPARTS");

                entity.Property(e => e.Part).HasColumnName("PART");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.IsApl).HasColumnName("IS_APL");

                entity.Property(e => e.IsSnsl).HasColumnName("IS_SNSL");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.HasOne(d => d.IsAplNavigation)
                    .WithMany(p => p.MimsCCpartsIsAplNavigation)
                    .HasForeignKey(d => d.IsApl)
                    .HasConstraintName("FK_MIMS_C_CPARTS_MIMS_X_YESNO");

                entity.HasOne(d => d.IsSnslNavigation)
                    .WithMany(p => p.MimsCCpartsIsSnslNavigation)
                    .HasForeignKey(d => d.IsSnsl)
                    .HasConstraintName("FK_MIMS_C_CPARTS_MIMS_X_YESNO1");

                entity.HasOne(d => d.PartNavigation)
                    .WithMany(p => p.MimsCCparts)
                    .HasForeignKey(d => d.Part)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_CPARTS_MIMS_C_PARTS");
            });

            modelBuilder.Entity<MimsCEqpConfig>(entity =>
            {
                entity.HasKey(e => new { e._1, e._2, e._3 });

                entity.ToTable("MIMS_C_EQP_CONFIG");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e.Trid)
                    .HasColumnName("TRID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e._10)
                    .HasColumnName("10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._11)
                    .HasColumnName("11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._12)
                    .HasColumnName("12")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e._13).HasColumnName("13");

                entity.Property(e => e._14).HasColumnName("14");

                entity.Property(e => e._15).HasColumnName("15");

                entity.Property(e => e._4)
                    .HasColumnName("4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._5)
                    .HasColumnName("5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._6)
                    .HasColumnName("6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._7)
                    .HasColumnName("7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._8)
                    .HasColumnName("8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._9)
                    .HasColumnName("9")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d._1Navigation)
                    .WithMany(p => p.MimsCEqpConfig_1Navigation)
                    .HasForeignKey(d => d._1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_EQP_CONFIG_MIMS_C_PARTS");

                entity.HasOne(d => d._2Navigation)
                    .WithMany(p => p.MimsCEqpConfig_2Navigation)
                    .HasForeignKey(d => d._2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_EQP_CONFIG_MIMS_C_PARTS1");

                entity.HasOne(d => d._3Navigation)
                    .WithMany(p => p.MimsCEqpConfig_3Navigation)
                    .HasForeignKey(d => d._3)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_EQP_CONFIG_MIMS_C_PARTS2");
            });

            modelBuilder.Entity<MimsCEqpConfig2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MIMS_C_EQP_CONFIG2");

                entity.Property(e => e.Configid)
                    .HasColumnName("CONFIGID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Configno)
                    .HasColumnName("CONFIGNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Configno2)
                    .HasColumnName("CONFIGNO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endpart)
                    .HasColumnName("ENDPART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eswbs)
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Indcount).HasColumnName("INDCOUNT");

                entity.Property(e => e.Indlevel).HasColumnName("INDLEVEL");

                entity.Property(e => e.Part)
                    .HasColumnName("PART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartName)
                    .HasColumnName("PART_NAME")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Pchiildcount).HasColumnName("PCHIILDCOUNT");

                entity.Property(e => e.Pconfigid)
                    .HasColumnName("PCONFIGID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pconfigno)
                    .HasColumnName("PCONFIGNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pconfigno2)
                    .HasColumnName("PCONFIGNO2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Peswbs)
                    .HasColumnName("PESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppart)
                    .HasColumnName("PPART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trid).HasColumnName("TRID");
            });

            modelBuilder.Entity<MimsCMasterconfig>(entity =>
            {
                entity.HasKey(e => e.Eswbs);

                entity.ToTable("MIMS_C_MASTERCONFIG");

                entity.Property(e => e.Eswbs)
                    .HasColumnName("ESWBS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Applicable).HasColumnName("APPLICABLE");

                entity.Property(e => e.Nomenclature)
                    .HasColumnName("NOMENCLATURE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Peswbs)
                    .HasColumnName("PESWBS")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsCMcat>(entity =>
            {
                entity.HasKey(e => e.Mcat);

                entity.ToTable("MIMS_C_MCAT");

                entity.Property(e => e.Mcat)
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.McatDesc)
                    .IsRequired()
                    .HasColumnName("MCAT_DESC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsCPartcat>(entity =>
            {
                entity.HasKey(e => e.PartCat);

                entity.ToTable("MIMS_C_PARTCAT");

                entity.Property(e => e.PartCat)
                    .HasColumnName("PART_CAT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PartcatDesc)
                    .HasColumnName("PARTCAT_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsCPartdetails>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("MIMS_C_PARTDETAILS");

                entity.Property(e => e.PartId)
                    .HasColumnName("PART_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Currency).HasColumnName("CURRENCY");

                entity.Property(e => e.DisposalCost)
                    .HasColumnName("DISPOSAL_COST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EolEnvCln)
                    .HasColumnName("EOL_ENV_CLN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EolSalv)
                    .HasColumnName("EOL_SALV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotSize)
                    .HasColumnName("LOT_SIZE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MiFailR)
                    .HasColumnName("MI_FAIL_R")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Plt).HasColumnName("PLT");

                entity.Property(e => e.PriceBuy)
                    .HasColumnName("PRICE_BUY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rctc).HasColumnName("RCTC");

                entity.Property(e => e.Rctd).HasColumnName("RCTD");

                entity.Property(e => e.Rcti).HasColumnName("RCTI");

                entity.Property(e => e.Rcto).HasColumnName("RCTO");

                entity.Property(e => e.RefYear).HasColumnName("REF_YEAR");

                entity.Property(e => e.Rip)
                    .HasColumnName("RIP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rlt).HasColumnName("RLT");

                entity.Property(e => e.Rr)
                    .HasColumnName("RR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RtOk)
                    .HasColumnName("RT_OK")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Scc)
                    .HasColumnName("SCC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Scl).HasColumnName("SCL");

                entity.Property(e => e.SpefRep)
                    .HasColumnName("SPEF_REP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UcIncr)
                    .HasColumnName("UC_INCR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UcTotal)
                    .HasColumnName("UC_TOTAL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WtInc).HasColumnName("WT_INC");

                entity.Property(e => e.WtTotal).HasColumnName("WT_TOTAL");

                entity.HasOne(d => d.Part)
                    .WithOne(p => p.MimsCPartdetails)
                    .HasForeignKey<MimsCPartdetails>(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_PARTDETAILS_MIMS_C_PARTS");
            });

            modelBuilder.Entity<MimsCParts>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("MIMS_C_PARTS");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.Ac).HasColumnName("AC");

                entity.Property(e => e.Anc).HasColumnName("ANC");

                entity.Property(e => e.Ap).HasColumnName("AP");

                entity.Property(e => e.App).HasColumnName("APP");

                entity.Property(e => e.Asc).HasColumnName("ASC");

                entity.Property(e => e.Brf)
                    .HasColumnName("BRF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency).HasColumnName("CURRENCY");

                entity.Property(e => e.CustodyId).HasColumnName("CUSTODY_ID");

                entity.Property(e => e.DLevel)
                    .HasColumnName("D_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateAdded)
                    .HasColumnName("DATE_ADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("DATE_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DerivativeId).HasColumnName("DERIVATIVE_ID");

                entity.Property(e => e.Diameter).HasColumnName("DIAMETER");

                entity.Property(e => e.DocSecId).HasColumnName("DOC_SEC_ID");

                entity.Property(e => e.HZECode).HasColumnName("H_Z_E_CODE");

                entity.Property(e => e.Height)
                    .HasColumnName("HEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdateby).HasColumnName("LAST_UPDATEBY");

                entity.Property(e => e.LeadTimeId).HasColumnName("LEAD_TIME_ID");

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.Mcat)
                    .IsRequired()
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mmtr)
                    .HasColumnName("MMTR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mtbf)
                    .HasColumnName("MTBF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OLevel)
                    .HasColumnName("O_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OldNsn)
                    .HasColumnName("OLD_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OldSmic).HasColumnName("OLD_SMIC");

                entity.Property(e => e.Osi).HasColumnName("OSI");

                entity.Property(e => e.PartCat)
                    .HasColumnName("PART_CAT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PartCharacteristics)
                    .HasColumnName("PART_CHARACTERISTICS")
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasColumnName("PART_CODE")
                    .HasMaxLength(49)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(concat([MAN_ID],'-',[PART_ID]))");

                entity.Property(e => e.PartImg)
                    .HasColumnName("PART_IMG")
                    .HasColumnType("image");

                entity.Property(e => e.PartMec).HasColumnName("PART_MEC");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .IsRequired()
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PhstCode)
                    .HasColumnName("PHST_CODE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasColumnName("PICTURE_FILE_NAME")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PmsCCode)
                    .HasColumnName("PMS_C_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PorQty2y).HasColumnName("POR_QTY2Y");

                entity.Property(e => e.PorQty40).HasColumnName("POR_QTY40");

                entity.Property(e => e.RevisionNo).HasColumnName("REVISION_NO");

                entity.Property(e => e.ShelfLifeId).HasColumnName("SHELF_LIFE_ID");

                entity.Property(e => e.SlaId).HasColumnName("SLA_ID");

                entity.Property(e => e.SmcId).HasColumnName("SMC_ID");

                entity.Property(e => e.Smic).HasColumnName("SMIC");

                entity.Property(e => e.Smr)
                    .HasColumnName("SMR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TempNsn)
                    .HasColumnName("TEMP_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TorQty2y).HasColumnName("TOR_QTY2Y");

                entity.Property(e => e.TorQty40).HasColumnName("TOR_QTY40");

                entity.Property(e => e.TrId).HasColumnName("TR_ID");

                entity.Property(e => e.TssId).HasColumnName("TSS_ID");

                entity.Property(e => e.UnitCube).HasColumnName("UNIT_CUBE");

                entity.Property(e => e.UnitOfItem).HasColumnName("UNIT_OF_ITEM");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.VendorNo)
                    .HasColumnName("VENDOR_NO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AcNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.Ac)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_AC");

                entity.HasOne(d => d.AncNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.Anc)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_ANC");

                entity.HasOne(d => d.ApNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.Ap)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_AP");

                entity.HasOne(d => d.AppNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.App)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_APP");

                entity.HasOne(d => d.AscNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.Asc)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_ASC");

                entity.HasOne(d => d.CurrencyNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.Currency)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_CURRENCY");

                entity.HasOne(d => d.Custody)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.CustodyId)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_CUSTODY");

                entity.HasOne(d => d.Derivative)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.DerivativeId)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_DERIVATIVE");

                entity.HasOne(d => d.DocSec)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.DocSecId)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_SECURITY");

                entity.HasOne(d => d.HZECodeNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.HZECode)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_GROUP");

                entity.HasOne(d => d.LeadTime)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.LeadTimeId)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_TIMEPERIOD");

                entity.HasOne(d => d.Man)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.ManId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_C_CAGE");

                entity.HasOne(d => d.McatNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.Mcat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_C_MCAT");

                entity.HasOne(d => d.OsiNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.Osi)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_OSI");

                entity.HasOne(d => d.PartCatNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.PartCat)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_C_PARTCAT");

                entity.HasOne(d => d.PartMecNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.PartMec)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_MEC");

                entity.HasOne(d => d.PartTypeNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.PartType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_C_PARTTYPE");

                entity.HasOne(d => d.ShelfLife)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.ShelfLifeId)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_SHELFLIFE");

                entity.HasOne(d => d.Sla)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.SlaId)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_SLA");

                entity.HasOne(d => d.Smc)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.SmcId)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_SMC");

                entity.HasOne(d => d.SmicNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.Smic)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_SMIC");

                entity.HasOne(d => d.Tss)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.TssId)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_TSS");

                entity.HasOne(d => d.UnitCubeNavigation)
                    .WithMany(p => p.MimsCParts)
                    .HasForeignKey(d => d.UnitCube)
                    .HasConstraintName("FK_MIMS_C_PARTS_MIMS_X_UOM");
            });

            modelBuilder.Entity<MimsCParttype>(entity =>
            {
                entity.HasKey(e => e.PartType);

                entity.ToTable("MIMS_C_PARTTYPE");

                entity.Property(e => e.PartType)
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeDesc)
                    .HasColumnName("TYPE_DESC")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsCPartvendorlist>(entity =>
            {
                entity.HasKey(e => new { e.PartId, e.VendorId });

                entity.ToTable("MIMS_C_PARTVENDORLIST");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.HasOne(d => d.ActiveNavigation)
                    .WithMany(p => p.MimsCPartvendorlist)
                    .HasForeignKey(d => d.Active)
                    .HasConstraintName("FK_MIMS_C_PARTVENDORLIST_MIMS_X_YESNO");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.MimsCPartvendorlist)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_PARTVENDORLIST_MIMS_C_PARTS");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.MimsCPartvendorlist)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_PARTVENDORLIST_MIMS_C_VENDORS");
            });

            modelBuilder.Entity<MimsCPartvendors>(entity =>
            {
                entity.HasKey(e => new { e.PartId, e.VendorId });

                entity.ToTable("MIMS_C_PARTVENDORS");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.HasOne(d => d.ActiveNavigation)
                    .WithMany(p => p.MimsCPartvendors)
                    .HasForeignKey(d => d.Active)
                    .HasConstraintName("FK_MIMS_C_PARTVENDORS_MIMS_X_YESNO");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.MimsCPartvendors)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_PARTVENDORS_MIMS_C_PARTS");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.MimsCPartvendors)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_C_PARTVENDORS_MIMS_C_VENDORS");
            });

            modelBuilder.Entity<MimsCUnitconfig>(entity =>
            {
                entity.HasKey(e => new { e.SiteNo, e.Eswbs });

                entity.ToTable("MIMS_C_UNITCONFIG");

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");

                entity.Property(e => e.Eswbs)
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualOperationRequirement).HasColumnName("ANNUAL_OPERATION_REQUIREMENT");

                entity.Property(e => e.CedaReport).HasColumnName("CEDA_REPORT");

                entity.Property(e => e.CidPage)
                    .HasColumnName("CID_PAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CidReport).HasColumnName("CID_REPORT");

                entity.Property(e => e.CobQty).HasColumnName("COB_QTY");

                entity.Property(e => e.ConfigStatus)
                    .HasColumnName("CONFIG_STATUS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Configid)
                    .HasColumnName("CONFIGID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Configno)
                    .HasColumnName("CONFIGNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Configno2)
                    .HasColumnName("CONFIGNO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Csr).HasColumnName("CSR");

                entity.Property(e => e.DrawingNo)
                    .HasColumnName("DRAWING_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Endpart).HasColumnName("ENDPART");

                entity.Property(e => e.Equipmentnumber).HasColumnName("EQUIPMENTNUMBER");

                entity.Property(e => e.Equipmentsequencenumber).HasColumnName("EQUIPMENTSEQUENCENUMBER");

                entity.Property(e => e.FmgQty).HasColumnName("FMG_QTY");

                entity.Property(e => e.GroupNo)
                    .HasColumnName("GROUP_NO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemSerialNo)
                    .HasColumnName("ITEM_SERIAL_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JnbQty).HasColumnName("JNB_QTY");

                entity.Property(e => e.Levelnumber).HasColumnName("LEVELNUMBER");

                entity.Property(e => e.Levelsequencenumber).HasColumnName("LEVELSEQUENCENUMBER");

                entity.Property(e => e.LocNo)
                    .HasColumnName("LOC_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mainsystemnumber).HasColumnName("MAINSYSTEMNUMBER");

                entity.Property(e => e.MajorEquip).HasColumnName("MAJOR_EQUIP");

                entity.Property(e => e.Mea)
                    .IsRequired()
                    .HasColumnName("MEA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Mec).HasColumnName("MEC");

                entity.Property(e => e.MecReport).HasColumnName("MEC_REPORT");

                entity.Property(e => e.NoOfChange).HasColumnName("NO_OF_CHANGE");

                entity.Property(e => e.Nomenclature)
                    .HasColumnName("NOMENCLATURE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Partid).HasColumnName("PARTID");

                entity.Property(e => e.Pconfigid)
                    .HasColumnName("PCONFIGID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pconfigno)
                    .HasColumnName("PCONFIGNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pconfigno2)
                    .HasColumnName("PCONFIGNO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Peswbs)
                    .HasColumnName("PESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PndQty).HasColumnName("PND_QTY");

                entity.Property(e => e.Printindent).HasColumnName("PRINTINDENT");

                entity.Property(e => e.Printorder).HasColumnName("PRINTORDER");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Repairable).HasColumnName("REPAIRABLE");

                entity.Property(e => e.RhRec)
                    .HasColumnName("RH_REC")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Subsystemnumber).HasColumnName("SUBSYSTEMNUMBER");

                entity.Property(e => e.SwbsOrder)
                    .HasColumnName("SWBS_ORDER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Systemnumber).HasColumnName("SYSTEMNUMBER");

                entity.Property(e => e.UpkeepCode).HasColumnName("UPKEEP_CODE");

                entity.Property(e => e.Vol)
                    .HasColumnName("VOL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CedaReportNavigation)
                    .WithMany(p => p.MimsCUnitconfigCedaReportNavigation)
                    .HasForeignKey(d => d.CedaReport)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_X_YESNO5");

                entity.HasOne(d => d.CidReportNavigation)
                    .WithMany(p => p.MimsCUnitconfigCidReportNavigation)
                    .HasForeignKey(d => d.CidReport)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_X_YESNO3");

                entity.HasOne(d => d.CsrNavigation)
                    .WithMany(p => p.MimsCUnitconfigCsrNavigation)
                    .HasForeignKey(d => d.Csr)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_X_YESNO6");

                entity.HasOne(d => d.EndpartNavigation)
                    .WithMany(p => p.MimsCUnitconfigEndpartNavigation)
                    .HasForeignKey(d => d.Endpart)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_C_PARTS1");

                entity.HasOne(d => d.MajorEquipNavigation)
                    .WithMany(p => p.MimsCUnitconfigMajorEquipNavigation)
                    .HasForeignKey(d => d.MajorEquip)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_X_YESNO1");

                entity.HasOne(d => d.MecNavigation)
                    .WithMany(p => p.MimsCUnitconfig)
                    .HasForeignKey(d => d.Mec)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_X_CMEC");

                entity.HasOne(d => d.MecReportNavigation)
                    .WithMany(p => p.MimsCUnitconfigMecReportNavigation)
                    .HasForeignKey(d => d.MecReport)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_X_YESNO4");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.MimsCUnitconfigPart)
                    .HasForeignKey(d => d.Partid)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_C_PARTS");

                entity.HasOne(d => d.PmsNoNavigation)
                    .WithMany(p => p.MimsCUnitconfig)
                    .HasForeignKey(d => d.PmsNo)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_M_PMS");

                entity.HasOne(d => d.RepairableNavigation)
                    .WithMany(p => p.MimsCUnitconfigRepairableNavigation)
                    .HasForeignKey(d => d.Repairable)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_X_YESNO");

                entity.HasOne(d => d.UpkeepCodeNavigation)
                    .WithMany(p => p.MimsCUnitconfig)
                    .HasForeignKey(d => d.UpkeepCode)
                    .HasConstraintName("FK_MIMS_C_UNITCONFIG_MIMS_X_UPKEEP");
            });

            modelBuilder.Entity<MimsCVendors>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK_MIMS_C_VENDOR");

                entity.ToTable("MIMS_C_VENDORS");

                entity.Property(e => e.VendorId)
                    .HasColumnName("VENDOR_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddBy)
                    .HasColumnName("ADD_BY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate)
                    .HasColumnName("ADD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.LeditedBy)
                    .HasColumnName("LEDITED_BY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LeditedDate)
                    .HasColumnName("LEDITED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasColumnName("VENDOR_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VendorLat)
                    .HasColumnName("VENDOR_LAT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VendorLong)
                    .HasColumnName("VENDOR_LONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VendorMap)
                    .HasColumnName("VENDOR_MAP")
                    .HasColumnType("image");

                entity.Property(e => e.VendorName)
                    .HasColumnName("VENDOR_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsCamsConfigurations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MIMS_CAMS_CONFIGURATIONS");

                entity.Property(e => e.AnnualOperationRequirement).HasColumnName("ANNUAL_OPERATION_REQUIREMENT");

                entity.Property(e => e.AplNo)
                    .IsRequired()
                    .HasColumnName("APL_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CedaReport)
                    .HasColumnName("CEDA_REPORT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CidPage)
                    .HasColumnName("CID_PAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CidReport)
                    .HasColumnName("CID_REPORT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CobQty).HasColumnName("COB_QTY");

                entity.Property(e => e.ConfigStatus)
                    .HasColumnName("CONFIG_STATUS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Csr)
                    .HasColumnName("CSR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingNo)
                    .HasColumnName("DRAWING_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentPopulation).HasColumnName("EQUIPMENT_POPULATION");

                entity.Property(e => e.Equipmentnumber).HasColumnName("EQUIPMENTNUMBER");

                entity.Property(e => e.Equipmentsequencenumber).HasColumnName("EQUIPMENTSEQUENCENUMBER");

                entity.Property(e => e.FmgQty).HasColumnName("FMG_QTY");

                entity.Property(e => e.GroupNo)
                    .HasColumnName("GROUP_NO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemSerialNo)
                    .HasColumnName("ITEM_SERIAL_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JnbQty).HasColumnName("JNB_QTY");

                entity.Property(e => e.Levelnumber).HasColumnName("LEVELNUMBER");

                entity.Property(e => e.Levelsequencenumber).HasColumnName("LEVELSEQUENCENUMBER");

                entity.Property(e => e.LocationNo)
                    .IsRequired()
                    .HasColumnName("LOCATION_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mainsystemnumber).HasColumnName("MAINSYSTEMNUMBER");

                entity.Property(e => e.MajorEquip)
                    .HasColumnName("MAJOR_EQUIP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mea)
                    .IsRequired()
                    .HasColumnName("MEA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Mec).HasColumnName("MEC");

                entity.Property(e => e.MecReport)
                    .HasColumnName("MEC_REPORT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfChange).HasColumnName("NO_OF_CHANGE");

                entity.Property(e => e.ParentSwbs)
                    .IsRequired()
                    .HasColumnName("PARENT_SWBS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("PART_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PndQty).HasColumnName("PND_QTY");

                entity.Property(e => e.Printindent).HasColumnName("PRINTINDENT");

                entity.Property(e => e.Printorder).HasColumnName("PRINTORDER");

                entity.Property(e => e.Repairable)
                    .HasColumnName("REPAIRABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RhRec)
                    .IsRequired()
                    .HasColumnName("RH_REC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SiteNo)
                    .IsRequired()
                    .HasColumnName("SITE_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Subsystemnumber).HasColumnName("SUBSYSTEMNUMBER");

                entity.Property(e => e.Swbs)
                    .IsRequired()
                    .HasColumnName("SWBS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SwbsOrder)
                    .HasColumnName("SWBS_ORDER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasColumnName("SYSTEM_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Systemnumber).HasColumnName("SYSTEMNUMBER");

                entity.Property(e => e.UpdateRevision).HasColumnName("UPDATE_REVISION");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("UPDATE_STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpkeepCode)
                    .HasColumnName("UPKEEP_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vol)
                    .HasColumnName("VOL")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsDDocconfig>(entity =>
            {
                entity.HasKey(e => new { e.SiteNo, e.Eswbs, e.DocId });

                entity.ToTable("MIMS_D_DOCCONFIG");

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");

                entity.Property(e => e.Eswbs)
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.MimsDDocconfig)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_D_DOCCONFIG_MIMS_D_DOCMASTER");
            });

            modelBuilder.Entity<MimsDDocmaster>(entity =>
            {
                entity.HasKey(e => e.DocId)
                    .HasName("PK_MIJMS_D_DOCMASTER");

                entity.ToTable("MIMS_D_DOCMASTER");

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.DocFile)
                    .HasColumnName("DOC_FILE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasColumnName("DOC_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocRemarks)
                    .HasColumnName("DOC_REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocType).HasColumnName("DOC_TYPE");

                entity.HasOne(d => d.DocTypeNavigation)
                    .WithMany(p => p.MimsDDocmaster)
                    .HasForeignKey(d => d.DocType)
                    .HasConstraintName("FK_MIMS_D_DOCMASTER_MIMS_D_DOCTYPE");
            });

            modelBuilder.Entity<MimsDDoctype>(entity =>
            {
                entity.HasKey(e => e.DocTypeId)
                    .HasName("PK_MIMS_C_DOCTYPE");

                entity.ToTable("MIMS_D_DOCTYPE");

                entity.Property(e => e.DocTypeId).HasColumnName("DOC_TYPE_ID");

                entity.Property(e => e.DocTypeDesc)
                    .HasColumnName("DOC_TYPE_DESC")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsHPerson>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("MIMS_H_PERSON");

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fi1).HasColumnName("FI1");

                entity.Property(e => e.Fi2).HasColumnName("FI2");

                entity.Property(e => e.Fi3).HasColumnName("FI3");

                entity.Property(e => e.Fname)
                    .HasColumnName("FNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fv1)
                    .HasColumnName("FV1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fv2)
                    .HasColumnName("FV2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonPic)
                    .HasColumnName("PERSON_PIC")
                    .HasColumnType("image");

                entity.Property(e => e.Pno)
                    .HasColumnName("PNO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RankId).HasColumnName("RANK_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.MimsHPerson)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_MIMS_H_PERSON_MIMS_H_RANKS");
            });

            modelBuilder.Entity<MimsHRankType>(entity =>
            {
                entity.HasKey(e => e.RankType);

                entity.ToTable("MIMS_H_RANK_TYPE");

                entity.Property(e => e.RankType).HasColumnName("RANK_TYPE");

                entity.Property(e => e.RankTypeName)
                    .HasColumnName("RANK_TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsHRanks>(entity =>
            {
                entity.HasKey(e => e.RankId);

                entity.ToTable("MIMS_H_RANKS");

                entity.Property(e => e.RankId).HasColumnName("RANK_ID");

                entity.Property(e => e.RankGrade)
                    .HasColumnName("RANK_GRADE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RankName)
                    .HasColumnName("RANK_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RankType).HasColumnName("RANK_TYPE");

                entity.HasOne(d => d.RankTypeNavigation)
                    .WithMany(p => p.MimsHRanks)
                    .HasForeignKey(d => d.RankType)
                    .HasConstraintName("FK_MIMS_H_RANKS_MIMS_H_RANK_TYPE");
            });

            modelBuilder.Entity<MimsHSkilledhr>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.SkillCode });

                entity.ToTable("MIMS_H_SKILLEDHR");

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.SkillCode)
                    .HasColumnName("SKILL_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SkillLevel).HasColumnName("SKILL_LEVEL");
            });

            modelBuilder.Entity<MimsHSkills>(entity =>
            {
                entity.HasKey(e => e.SkillCode);

                entity.ToTable("MIMS_H_SKILLS");

                entity.Property(e => e.SkillCode)
                    .HasColumnName("SKILL_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SkillDescription)
                    .HasColumnName("SKILL_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SkillName)
                    .HasColumnName("SKILL_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsIBins>(entity =>
            {
                entity.HasKey(e => e.BinId);

                entity.ToTable("MIMS_I_BINS");

                entity.Property(e => e.BinId).HasColumnName("BIN_ID");

                entity.Property(e => e.BinDesc)
                    .HasColumnName("BIN_DESC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BinNo)
                    .HasColumnName("BIN_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RackId).HasColumnName("RACK_ID");

                entity.HasOne(d => d.Rack)
                    .WithMany(p => p.MimsIBins)
                    .HasForeignKey(d => d.RackId)
                    .HasConstraintName("FK_MIMS_I_BINS_MIMS_I_RACKS");
            });

            modelBuilder.Entity<MimsIDemandissued>(entity =>
            {
                entity.HasKey(e => e.DemandId);

                entity.ToTable("MIMS_I_DEMANDISSUED");

                entity.Property(e => e.DemandId)
                    .HasColumnName("DEMAND_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsReceived).HasColumnName("IS_RECEIVED");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("ISSUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IssueQty)
                    .HasColumnName("ISSUE_QTY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate)
                    .HasColumnName("RECEIVED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Demand)
                    .WithOne(p => p.MimsIDemandissued)
                    .HasForeignKey<MimsIDemandissued>(d => d.DemandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_I_DEMANDISSUED_MIMS_I_DEMANDS");
            });

            modelBuilder.Entity<MimsIDemands>(entity =>
            {
                entity.HasKey(e => e.DemandId)
                    .HasName("PK_MIMS_I_DEMAND");

                entity.ToTable("MIMS_I_DEMANDS");

                entity.Property(e => e.DemandId).HasColumnName("DEMAND_ID");

                entity.Property(e => e.DemandDate)
                    .HasColumnName("DEMAND_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DemandNo)
                    .HasColumnName("DEMAND_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DemandTypeId).HasColumnName("DEMAND_TYPE_ID");

                entity.Property(e => e.DemandeeUnit).HasColumnName("DEMANDEE_UNIT");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Refernce)
                    .HasColumnName("REFERNCE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("STATUS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.Property(e => e.UomId)
                    .HasColumnName("UOM_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.DemandType)
                    .WithMany(p => p.MimsIDemands)
                    .HasForeignKey(d => d.DemandTypeId)
                    .HasConstraintName("FK_MIMS_I_DEMAND_MIMS_X_DEMANDTYPE");

                entity.HasOne(d => d.DemandeeUnitNavigation)
                    .WithMany(p => p.MimsIDemandsDemandeeUnitNavigation)
                    .HasForeignKey(d => d.DemandeeUnit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_I_DEMAND_MIMS_A_SITES1");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.MimsIDemands)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("FK_MIMS_I_DEMAND_MIMS_C_PARTS");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MimsIDemands)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MIMS_I_DEMAND_MIMS_X_DEMAND_STATUS");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MimsIDemandsUnit)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_MIMS_I_DEMAND_MIMS_A_SITES");
            });

            modelBuilder.Entity<MimsIDepot>(entity =>
            {
                entity.HasKey(e => e.DeoptId);

                entity.ToTable("MIMS_I_DEPOT");

                entity.Property(e => e.DeoptId).HasColumnName("DEOPT_ID");

                entity.Property(e => e.DeoptLat)
                    .HasColumnName("DEOPT_LAT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DepotArea)
                    .HasColumnName("DEPOT_AREA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepotCo).HasColumnName("DEPOT_CO");

                entity.Property(e => e.DepotCode)
                    .HasColumnName("DEPOT_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepotDesc)
                    .HasColumnName("DEPOT_DESC")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepotImage)
                    .HasColumnName("DEPOT_IMAGE")
                    .HasColumnType("image");

                entity.Property(e => e.DepotLoc)
                    .HasColumnName("DEPOT_LOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepotLong)
                    .HasColumnName("DEPOT_LONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DepotMapLoc)
                    .HasColumnName("DEPOT_MAP_LOC")
                    .HasColumnType("image");

                entity.Property(e => e.DepotName)
                    .HasColumnName("DEPOT_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepotUnit).HasColumnName("DEPOT_UNIT");

                entity.HasOne(d => d.DepotCoNavigation)
                    .WithMany(p => p.MimsIDepot)
                    .HasForeignKey(d => d.DepotCo)
                    .HasConstraintName("FK_MIMS_I_DEPOT_MIMS_H_PERSON");

                entity.HasOne(d => d.DepotUnitNavigation)
                    .WithMany(p => p.MimsIDepot)
                    .HasForeignKey(d => d.DepotUnit)
                    .HasConstraintName("FK_MIMS_I_DEPOT_MIMS_A_SITES");
            });

            modelBuilder.Entity<MimsIGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("MIMS_I_GROUP");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");

                entity.Property(e => e.GroupDesc)
                    .HasColumnName("GROUP_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupOfficer).HasColumnName("GROUP_OFFICER");

                entity.Property(e => e.Reamrks)
                    .HasColumnName("REAMRKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Depot)
                    .WithMany(p => p.MimsIGroup)
                    .HasForeignKey(d => d.DepotId)
                    .HasConstraintName("FK_MIMS_I_GROUP_MIMS_I_DEPOT");

                entity.HasOne(d => d.GroupOfficerNavigation)
                    .WithMany(p => p.MimsIGroup)
                    .HasForeignKey(d => d.GroupOfficer)
                    .HasConstraintName("FK_MIMS_I_GROUP_MIMS_H_PERSON");
            });

            modelBuilder.Entity<MimsIInventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MIMS_I_INVENTORY");

                entity.Property(e => e.BinId).HasColumnName("BIN_ID");

                entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RackId).HasColumnName("RACK_ID");

                entity.Property(e => e.WarehouseId).HasColumnName("WAREHOUSE_ID");

                entity.HasOne(d => d.Bin)
                    .WithMany()
                    .HasForeignKey(d => d.BinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_I_INVENTORY_MIMS_I_BINS");

                entity.HasOne(d => d.Depot)
                    .WithMany()
                    .HasForeignKey(d => d.DepotId)
                    .HasConstraintName("FK_MIMS_I_INVENTORY_MIMS_I_DEPOT");

                entity.HasOne(d => d.Group)
                    .WithMany()
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_MIMS_I_INVENTORY_MIMS_I_GROUP");

                entity.HasOne(d => d.Rack)
                    .WithMany()
                    .HasForeignKey(d => d.RackId)
                    .HasConstraintName("FK_MIMS_I_INVENTORY_MIMS_I_RACKS");

                entity.HasOne(d => d.Warehouse)
                    .WithMany()
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_MIMS_I_INVENTORY_MIMS_I_WAREHOUSE");
            });

            modelBuilder.Entity<MimsIRacks>(entity =>
            {
                entity.HasKey(e => e.RackId);

                entity.ToTable("MIMS_I_RACKS");

                entity.Property(e => e.RackId).HasColumnName("RACK_ID");

                entity.Property(e => e.RackDesc)
                    .HasColumnName("RACK_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RackLoc)
                    .HasColumnName("RACK_LOC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RackNo)
                    .HasColumnName("RACK_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RackRemarks)
                    .HasColumnName("RACK_REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseId).HasColumnName("WAREHOUSE_ID");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.MimsIRacks)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_MIMS_I_RACKS_MIMS_I_WAREHOUSE");
            });

            modelBuilder.Entity<MimsIWarehouse>(entity =>
            {
                entity.HasKey(e => e.WarehouseId);

                entity.ToTable("MIMS_I_WAREHOUSE");

                entity.Property(e => e.WarehouseId).HasColumnName("WAREHOUSE_ID");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.WarehouseDesc)
                    .HasColumnName("WAREHOUSE_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseName)
                    .HasColumnName("WAREHOUSE_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseOic).HasColumnName("WAREHOUSE_OIC");

                entity.Property(e => e.WarehouseRemarks)
                    .HasColumnName("WAREHOUSE_REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MimsIWarehouse)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_MIMS_I_WAREHOUSE_MIMS_I_GROUP");

                entity.HasOne(d => d.WarehouseOicNavigation)
                    .WithMany(p => p.MimsIWarehouse)
                    .HasForeignKey(d => d.WarehouseOic)
                    .HasConstraintName("FK_MIMS_I_WAREHOUSE_MIMS_H_PERSON");
            });

            modelBuilder.Entity<MimsMDoccat>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK_MIMS_C_DOCCAT");

                entity.ToTable("MIMS_M_DOCCAT");

                entity.Property(e => e.CatId)
                    .HasColumnName("CAT_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CatName)
                    .HasColumnName("CAT_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsMEswbspms>(entity =>
            {
                entity.HasKey(e => new { e.SiteNo, e.Eswbs, e.PmsNo, e.MopNo });

                entity.ToTable("MIMS_M_ESWBSPMS");

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");

                entity.Property(e => e.Eswbs)
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MopNo)
                    .HasColumnName("MOP_NO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Applicable).HasColumnName("APPLICABLE");

                entity.Property(e => e.Period).HasColumnName("PERIOD");

                entity.Property(e => e.PeriodCode).HasColumnName("PERIOD_CODE");

                entity.Property(e => e.PeriodHour).HasColumnName("PERIOD_HOUR");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApplicableNavigation)
                    .WithMany(p => p.MimsMEswbspms)
                    .HasForeignKey(d => d.Applicable)
                    .HasConstraintName("FK_MIMS_M_ESWBSPMS_MIMS_X_YESNO");

                entity.HasOne(d => d.PeriodCodeNavigation)
                    .WithMany(p => p.MimsMEswbspms)
                    .HasForeignKey(d => d.PeriodCode)
                    .HasConstraintName("FK_MIMS_M_ESWBSPMS_MIMS_X_TIMEPERIOD");

                entity.HasOne(d => d.MimsMTaskmaster)
                    .WithMany(p => p.MimsMEswbspms)
                    .HasForeignKey(d => new { d.PmsNo, d.MopNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_M_ESWBSPMS_MIMS_M_PMS");
            });

            modelBuilder.Entity<MimsMPms>(entity =>
            {
                entity.HasKey(e => e.PmsNo);

                entity.ToTable("MIMS_M_PMS");

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PmsDesc)
                    .HasColumnName("PMS_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.MimsMPms)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("FK_MIMS_M_PMS_MIMS_C_PARTS");
            });

            modelBuilder.Entity<MimsMTaskParts>(entity =>
            {
                entity.HasKey(e => new { e.PmsNo, e.MopNo, e.PartId });

                entity.ToTable("MIMS_M_TASK_PARTS");

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MopNo)
                    .HasColumnName("MOP_NO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.DocNo)
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nsn)
                    .HasColumnName("NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentData).HasColumnName("PERMANENT_DATA");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.UpdateRevision)
                    .HasColumnName("UPDATE_REVISION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("UPDATE_STATUS")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.MimsMTaskParts)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_M_TASK_PARTS_MIMS_C_PARTS");

                entity.HasOne(d => d.PmsNoNavigation)
                    .WithMany(p => p.MimsMTaskParts)
                    .HasForeignKey(d => d.PmsNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_M_TASK_PARTS_MIMS_M_PMS");
            });

            modelBuilder.Entity<MimsMTaskmaster>(entity =>
            {
                entity.HasKey(e => new { e.PmsNo, e.MopNo });

                entity.ToTable("MIMS_M_TASKMASTER");

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MopNo)
                    .HasColumnName("MOP_NO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Alias)
                    .HasColumnName("ALIAS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AliasSwbs)
                    .HasColumnName("ALIAS_SWBS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ByWhom)
                    .HasColumnName("BY_WHOM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DrydockReq)
                    .HasColumnName("DRYDOCK_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Duedate)
                    .HasColumnName("DUEDATE")
                    .HasColumnType("date");

                entity.Property(e => e.ElapsedTime).HasColumnName("ELAPSED_TIME");

                entity.Property(e => e.ExceptMop)
                    .HasColumnName("EXCEPT_MOP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Jic)
                    .HasColumnName("JIC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ManHourEe).HasColumnName("MAN_HOUR_EE");

                entity.Property(e => e.ManHourEl).HasColumnName("MAN_HOUR_EL");

                entity.Property(e => e.ManHourMc).HasColumnName("MAN_HOUR_MC");

                entity.Property(e => e.Mtr)
                    .HasColumnName("MTR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfManEe).HasColumnName("NUMBER_OF_MAN_EE");

                entity.Property(e => e.NumberOfManEl).HasColumnName("NUMBER_OF_MAN_EL");

                entity.Property(e => e.NumberOfManMc).HasColumnName("NUMBER_OF_MAN_MC");

                entity.Property(e => e.NumberOfPeriodDate).HasColumnName("NUMBER_OF_PERIOD_DATE");

                entity.Property(e => e.Period).HasColumnName("PERIOD");

                entity.Property(e => e.PeriodCode).HasColumnName("PERIOD_CODE");

                entity.Property(e => e.PeriodHour).HasColumnName("PERIOD_HOUR");

                entity.Property(e => e.RefitPk)
                    .HasColumnName("REFIT_PK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Removal)
                    .HasColumnName("REMOVAL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RepairablePoolReq)
                    .HasColumnName("REPAIRABLE_POOL_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Report).HasColumnName("REPORT");

                entity.Property(e => e.Reportline).HasColumnName("REPORTLINE");

                entity.Property(e => e.SafetyPrecaution)
                    .HasColumnName("SAFETY_PRECAUTION")
                    .IsUnicode(false);

                entity.Property(e => e.TaskEssentialNo)
                    .HasColumnName("TASK_ESSENTIAL_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TaskProcedure)
                    .HasColumnName("TASK_PROCEDURE")
                    .IsUnicode(false);

                entity.Property(e => e.TmlReq)
                    .HasColumnName("TML_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateRevision)
                    .HasColumnName("UPDATE_REVISION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateStatus)
                    .HasColumnName("UPDATE_STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpkeepCode)
                    .HasColumnName("UPKEEP_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.DocNoNavigation)
                    .WithMany(p => p.MimsMTaskmaster)
                    .HasForeignKey(d => d.DocNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_M_TASKMASTER_MIMS_M_DOCCAT");

                entity.HasOne(d => d.PeriodCodeNavigation)
                    .WithMany(p => p.MimsMTaskmaster)
                    .HasForeignKey(d => d.PeriodCode)
                    .HasConstraintName("FK_MIMS_M_TASKMASTER_MIMS_X_TIMEPERIOD");

                entity.HasOne(d => d.PmsNoNavigation)
                    .WithMany(p => p.MimsMTaskmaster)
                    .HasForeignKey(d => d.PmsNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_M_TASKMASTER_MIMS_M_PMS");
            });

            modelBuilder.Entity<MimsROpdef>(entity =>
            {
                entity.HasKey(e => e.OpdefId);

                entity.ToTable("MIMS_R_OPDEF");

                entity.Property(e => e.OpdefId).HasColumnName("OPDEF_ID");

                entity.Property(e => e.DefectDate)
                    .HasColumnName("DEFECT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DefectDetails)
                    .HasColumnName("DEFECT_DETAILS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DefectRemarks)
                    .HasColumnName("DEFECT_REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Eswbs)
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpdefCat)
                    .HasColumnName("OPDEF_CAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OpdefDate)
                    .HasColumnName("OPDEF_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OpdefNo)
                    .HasColumnName("OPDEF_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");

                entity.HasOne(d => d.OpdefCatNavigation)
                    .WithMany(p => p.MimsROpdef)
                    .HasForeignKey(d => d.OpdefCat)
                    .HasConstraintName("FK_MIMS_R_OPDEF_MIMS_R_OPDEFCAT");
            });

            modelBuilder.Entity<MimsROpdefcat>(entity =>
            {
                entity.HasKey(e => e.OpdefCatNo);

                entity.ToTable("MIMS_R_OPDEFCAT");

                entity.Property(e => e.OpdefCatNo)
                    .HasColumnName("OPDEF_CAT_NO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OpdefCatDesc)
                    .HasColumnName("OPDEF_CAT_DESC")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsRRequsition>(entity =>
            {
                entity.HasKey(e => e.ReqId);

                entity.ToTable("MIMS_R_REQUSITION");

                entity.Property(e => e.ReqId).HasColumnName("REQ_ID");

                entity.Property(e => e.Eswbs)
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MopNo)
                    .HasColumnName("MOP_NO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ReqNo)
                    .HasColumnName("REQ_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReqRemarks)
                    .HasColumnName("REQ_REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");

                entity.HasOne(d => d.MimsMTaskmaster)
                    .WithMany(p => p.MimsRRequsition)
                    .HasForeignKey(d => new { d.PmsNo, d.MopNo })
                    .HasConstraintName("FK_MIMS_R_REQUSITION_MIMS_M_TASKMASTER");
            });

            modelBuilder.Entity<MimsSCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PK_MIMS_S_CURRENCY_1");

                entity.ToTable("MIMS_S_CURRENCY");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CURRENCY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrCode)
                    .HasColumnName("CURR_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrConvRate)
                    .HasColumnName("CURR_CONV_RATE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrName)
                    .HasColumnName("CURR_NAME")
                    .HasMaxLength(52)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsWStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("MIMS_W_STATUS");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.StatusCode)
                    .HasColumnName("STATUS_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDesc)
                    .HasColumnName("STATUS_DESC")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsWWorkcenters>(entity =>
            {
                entity.HasKey(e => e.WorkCenterId);

                entity.ToTable("MIMS_W_WORKCENTERS");

                entity.Property(e => e.WorkCenterId).HasColumnName("WORK_CENTER_ID");

                entity.Property(e => e.WorkCenterDesc)
                    .HasColumnName("WORK_CENTER_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterLat)
                    .HasColumnName("WORK_CENTER_LAT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WorkCenterLoc)
                    .HasColumnName("WORK_CENTER_LOC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterLong)
                    .HasColumnName("WORK_CENTER_LONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WorkCenterMap)
                    .HasColumnName("WORK_CENTER_MAP")
                    .HasColumnType("image");

                entity.Property(e => e.WorkCenterName)
                    .HasColumnName("WORK_CENTER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNo)
                    .HasColumnName("WORK_CENTER_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterPic)
                    .HasColumnName("WORK_CENTER_PIC")
                    .HasColumnType("image");

                entity.Property(e => e.WorkCenterType).HasColumnName("WORK_CENTER_TYPE");

                entity.Property(e => e.WorlCenterArea)
                    .HasColumnName("WORL_CENTER_AREA")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MimsWWorkcnterHr>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.AttachWorkCenter });

                entity.ToTable("MIMS_W_WORKCNTER_HR");

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.AttachWorkCenter).HasColumnName("ATTACH_WORK_CENTER");

                entity.Property(e => e.BornWorkCenter).HasColumnName("BORN_WORK_CENTER");

                entity.HasOne(d => d.AttachWorkCenterNavigation)
                    .WithMany(p => p.MimsWWorkcnterHr)
                    .HasForeignKey(d => d.AttachWorkCenter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_W_WORKCNTER_HR_MIMS_W_WORKCENTERS");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MimsWWorkcnterHr)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MIMS_W_WORKCNTER_HR_MIMS_H_PERSON");
            });

            modelBuilder.Entity<MimsWWorkorder>(entity =>
            {
                entity.HasKey(e => e.WorkOrderId);

                entity.ToTable("MIMS_W_WORKORDER");

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WORK_ORDER_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InitiatingUnit).HasColumnName("INITIATING_UNIT");

                entity.Property(e => e.OpdefRequsitionNo)
                    .HasColumnName("OPDEF_REQUSITION_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("WORK_ORDER_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderRemarks)
                    .HasColumnName("WORK_ORDER_REMARKS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderStatus).HasColumnName("WORK_ORDER_STATUS");

                entity.Property(e => e.WorkOrderType).HasColumnName("WORK_ORDER_TYPE");

                entity.HasOne(d => d.InitiatingUnitNavigation)
                    .WithMany(p => p.MimsWWorkorder)
                    .HasForeignKey(d => d.InitiatingUnit)
                    .HasConstraintName("FK_MIMS_W_WORKORDER_MIMS_A_SITES");

                entity.HasOne(d => d.WorkOrderStatusNavigation)
                    .WithMany(p => p.MimsWWorkorder)
                    .HasForeignKey(d => d.WorkOrderStatus)
                    .HasConstraintName("FK_MIMS_W_WORKORDER_MIMS_W_STATUS");

                entity.HasOne(d => d.WorkOrderTypeNavigation)
                    .WithMany(p => p.MimsWWorkorder)
                    .HasForeignKey(d => d.WorkOrderType)
                    .HasConstraintName("FK_MIMS_W_WORKORDER_MIMS_WORKORDER_TYPE");
            });

            modelBuilder.Entity<MimsWoWorkcenters>(entity =>
            {
                entity.HasKey(e => new { e.WoId, e.WcId });

                entity.ToTable("MIMS_WO_WORKCENTERS");

                entity.Property(e => e.WoId).HasColumnName("WO_ID");

                entity.Property(e => e.WcId).HasColumnName("WC_ID");

                entity.Property(e => e.IsKeyShop).HasColumnName("IS_KEY_SHOP");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IsKeyShopNavigation)
                    .WithMany(p => p.MimsWoWorkcenters)
                    .HasForeignKey(d => d.IsKeyShop)
                    .HasConstraintName("FK_MIMS_WO_WORKCENTERS_MIMS_X_YESNO");
            });

            modelBuilder.Entity<MimsWorkorderType>(entity =>
            {
                entity.HasKey(e => e.WoTypeId);

                entity.ToTable("MIMS_WORKORDER_TYPE");

                entity.Property(e => e.WoTypeId)
                    .HasColumnName("WO_TYPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.WoTypeName)
                    .HasColumnName("WO_TYPE_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXAc>(entity =>
            {
                entity.HasKey(e => e.AcId);

                entity.ToTable("MIMS_X_AC");

                entity.Property(e => e.AcId).HasColumnName("AC_ID");

                entity.Property(e => e.AcDesc)
                    .HasColumnName("AC_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AcName)
                    .IsRequired()
                    .HasColumnName("AC_NAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXAnc>(entity =>
            {
                entity.HasKey(e => e.AncId);

                entity.ToTable("MIMS_X_ANC");

                entity.Property(e => e.AncId).HasColumnName("ANC_ID");

                entity.Property(e => e.AncDesc)
                    .HasColumnName("ANC_DESC")
                    .IsUnicode(false);

                entity.Property(e => e.AncName)
                    .IsRequired()
                    .HasColumnName("ANC_NAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXAp>(entity =>
            {
                entity.HasKey(e => e.ApId);

                entity.ToTable("MIMS_X_AP");

                entity.Property(e => e.ApId).HasColumnName("AP_ID");

                entity.Property(e => e.ApDesc)
                    .HasColumnName("AP_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApName)
                    .IsRequired()
                    .HasColumnName("AP_NAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXApp>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("MIMS_X_APP");

                entity.Property(e => e.AppId).HasColumnName("APP_ID");

                entity.Property(e => e.AppCode)
                    .HasColumnName("APP_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppDesc)
                    .HasColumnName("APP_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXAsc>(entity =>
            {
                entity.HasKey(e => e.AscId);

                entity.ToTable("MIMS_X_ASC");

                entity.Property(e => e.AscId).HasColumnName("ASC_ID");

                entity.Property(e => e.AscDesc)
                    .HasColumnName("ASC_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AscName)
                    .IsRequired()
                    .HasColumnName("ASC_NAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXCmec>(entity =>
            {
                entity.HasKey(e => e.Cmec);

                entity.ToTable("MIMS_X_CMEC");

                entity.Property(e => e.Cmec)
                    .HasColumnName("CMEC")
                    .ValueGeneratedNever();

                entity.Property(e => e.CmecDesc)
                    .HasColumnName("CMEC_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PK_MIMS_S_CURRENCY");

                entity.ToTable("MIMS_X_CURRENCY");

                entity.Property(e => e.CurrencyId).HasColumnName("CURRENCY_ID");

                entity.Property(e => e.CurrCode)
                    .HasColumnName("CURR_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrConvRate)
                    .HasColumnName("CURR_CONV_RATE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrName)
                    .HasColumnName("CURR_NAME")
                    .HasMaxLength(52)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXCustody>(entity =>
            {
                entity.HasKey(e => e.CustodyId);

                entity.ToTable("MIMS_X_CUSTODY");

                entity.Property(e => e.CustodyId).HasColumnName("CUSTODY_ID");

                entity.Property(e => e.CustodyCode)
                    .HasColumnName("CUSTODY_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustodyDesc)
                    .HasColumnName("CUSTODY_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXDemandStatus>(entity =>
            {
                entity.HasKey(e => e.DemandStatusId);

                entity.ToTable("MIMS_X_DEMAND_STATUS");

                entity.Property(e => e.DemandStatusId)
                    .HasColumnName("DEMAND_STATUS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DemandStatus)
                    .HasColumnName("DEMAND_STATUS")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXDemandtype>(entity =>
            {
                entity.HasKey(e => e.DemandTypeId);

                entity.ToTable("MIMS_X_DEMANDTYPE");

                entity.Property(e => e.DemandTypeId)
                    .HasColumnName("DEMAND_TYPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DemandTypeName)
                    .HasColumnName("DEMAND_TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXDerivative>(entity =>
            {
                entity.HasKey(e => e.DerivativeId);

                entity.ToTable("MIMS_X_DERIVATIVE");

                entity.Property(e => e.DerivativeId).HasColumnName("DERIVATIVE_ID");

                entity.Property(e => e.DerivativeCode)
                    .HasColumnName("DERIVATIVE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeDesc)
                    .HasColumnName("DERIVATIVE_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_MIMS_X_");

                entity.ToTable("MIMS_X_GROUP");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.GrouopCode)
                    .HasColumnName("GROUOP_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDesc)
                    .HasColumnName("GROUP_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXMec>(entity =>
            {
                entity.HasKey(e => e.Mec);

                entity.ToTable("MIMS_X_MEC");

                entity.Property(e => e.Mec).HasColumnName("MEC");

                entity.Property(e => e.MecDesc)
                    .HasColumnName("MEC_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXOsi>(entity =>
            {
                entity.HasKey(e => e.OsiId);

                entity.ToTable("MIMS_X_OSI");

                entity.Property(e => e.OsiId).HasColumnName("OSI_ID");

                entity.Property(e => e.OsiCode)
                    .HasColumnName("OSI_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OsiDesc)
                    .HasColumnName("OSI_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXSecurity>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.ToTable("MIMS_X_SECURITY");

                entity.Property(e => e.SecurityId).HasColumnName("SECURITY_ID");

                entity.Property(e => e.SecurityCode)
                    .HasColumnName("SECURITY_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityDesc)
                    .HasColumnName("SECURITY_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXShelflife>(entity =>
            {
                entity.HasKey(e => e.SlId);

                entity.ToTable("MIMS_X_SHELFLIFE");

                entity.Property(e => e.SlId).HasColumnName("SL_ID");

                entity.Property(e => e.SlCode)
                    .HasColumnName("SL_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SlDesc)
                    .HasColumnName("SL_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXSla>(entity =>
            {
                entity.HasKey(e => e.SlaId);

                entity.ToTable("MIMS_X_SLA");

                entity.Property(e => e.SlaId).HasColumnName("SLA_ID");

                entity.Property(e => e.SlaCode)
                    .HasColumnName("SLA_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SlaDesc)
                    .HasColumnName("SLA_DESC")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXSmc>(entity =>
            {
                entity.HasKey(e => e.SmcId);

                entity.ToTable("MIMS_X_SMC");

                entity.Property(e => e.SmcId).HasColumnName("SMC_ID");

                entity.Property(e => e.SmcCode)
                    .HasColumnName("SMC_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SmcDesc)
                    .HasColumnName("SMC_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXSmic>(entity =>
            {
                entity.HasKey(e => e.SmicId);

                entity.ToTable("MIMS_X_SMIC");

                entity.Property(e => e.SmicId).HasColumnName("SMIC_ID");

                entity.Property(e => e.SmicCode)
                    .HasColumnName("SMIC_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SmicDesc)
                    .HasColumnName("SMIC_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXTimeperiod>(entity =>
            {
                entity.HasKey(e => e.TimeperiodId)
                    .HasName("PK_MIMS_X_PERIODTIME");

                entity.ToTable("MIMS_X_TIMEPERIOD");

                entity.Property(e => e.TimeperiodId).HasColumnName("TIMEPERIOD_ID");

                entity.Property(e => e.TimeperiodCode)
                    .HasColumnName("TIMEPERIOD_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeperiodDesc)
                    .HasColumnName("TIMEPERIOD_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXTss>(entity =>
            {
                entity.HasKey(e => e.TssId);

                entity.ToTable("MIMS_X_TSS");

                entity.Property(e => e.TssId).HasColumnName("TSS_ID");

                entity.Property(e => e.TssCode)
                    .HasColumnName("TSS_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TssDesc)
                    .HasColumnName("TSS_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXUom>(entity =>
            {
                entity.HasKey(e => e.UomId);

                entity.ToTable("MIMS_X_UOM");

                entity.Property(e => e.UomId).HasColumnName("UOM_ID");

                entity.Property(e => e.UomDesc)
                    .HasColumnName("UOM_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UomName)
                    .IsRequired()
                    .HasColumnName("UOM_NAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXUpkeep>(entity =>
            {
                entity.HasKey(e => e.UpkeepId)
                    .HasName("PK_UMIMS_X_UPKEEP");

                entity.ToTable("MIMS_X_UPKEEP");

                entity.Property(e => e.UpkeepId).HasColumnName("UPKEEP_ID");

                entity.Property(e => e.UpkeepDesc)
                    .HasColumnName("UPKEEP_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpkeepName)
                    .IsRequired()
                    .HasColumnName("UPKEEP_NAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MimsXYesno>(entity =>
            {
                entity.HasKey(e => e.IsId);

                entity.ToTable("MIMS_X_YESNO");

                entity.Property(e => e.IsId)
                    .HasColumnName("IS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsName)
                    .HasColumnName("IS_NAME")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VASiteStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_A_SITE_STAT");

                entity.Property(e => e.CommandName)
                    .HasColumnName("COMMAND_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpsAvailability)
                    .HasColumnName("OPS_AVAILABILITY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpsDefect).HasColumnName("OPS_DEFECT");

                entity.Property(e => e.OpsReadiness)
                    .HasColumnName("OPS_READINESS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SiteName)
                    .HasColumnName("SITE_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCommandName)
                    .HasColumnName("TYPE_COMMAND_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VCApl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_APL");

                entity.Property(e => e.Apl)
                    .HasColumnName("APL")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AplId).HasColumnName("APL_ID");

                entity.Property(e => e.AplpartId).HasColumnName("APLPART_ID");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChildCage)
                    .HasColumnName("CHILD_CAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChildMancode)
                    .HasColumnName("CHILD_MANCODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChildManufacturer)
                    .HasColumnName("CHILD_MANUFACTURER")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CmanId).HasColumnName("CMAN_ID");

                entity.Property(e => e.Cmcat)
                    .IsRequired()
                    .HasColumnName("CMCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cmodel)
                    .HasColumnName("CMODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpartName)
                    .IsRequired()
                    .HasColumnName("CPART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.CpartNo)
                    .IsRequired()
                    .HasColumnName("CPART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CpartType)
                    .IsRequired()
                    .HasColumnName("CPART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtypeDesc)
                    .HasColumnName("CTYPE_DESC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsApl).HasColumnName("IS_APL");

                entity.Property(e => e.IsSnsl).HasColumnName("IS_SNSL");

                entity.Property(e => e.ManCode)
                    .HasColumnName("MAN_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mcat)
                    .IsRequired()
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .IsRequired()
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.TypeDesc)
                    .HasColumnName("TYPE_DESC")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VCConfigSystems>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_CONFIG_SYSTEMS");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Eswbs)
                    .IsRequired()
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSerialNo)
                    .HasColumnName("ITEM_SERIAL_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nomenclature)
                    .HasColumnName("NOMENCLATURE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nsn)
                    .IsRequired()
                    .HasColumnName("NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ParentName)
                    .HasColumnName("PARENT_NAME")
                    .HasMaxLength(303)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Peswbs)
                    .HasColumnName("PESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasColumnName("SITE_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");
            });

            modelBuilder.Entity<VCCpartCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_CPART_COUNT");

                entity.Property(e => e.CpartCount).HasColumnName("CPART_COUNT");

                entity.Property(e => e.Part).HasColumnName("PART");

                entity.Property(e => e.TotalCparts).HasColumnName("TOTAL_CPARTS");
            });

            modelBuilder.Entity<VCCparts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_CPARTS");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChildCage)
                    .HasColumnName("CHILD_CAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChildMancode)
                    .HasColumnName("CHILD_MANCODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChildManufacturer)
                    .HasColumnName("CHILD_MANUFACTURER")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CmanId).HasColumnName("CMAN_ID");

                entity.Property(e => e.Cmcat)
                    .IsRequired()
                    .HasColumnName("CMCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cmodel)
                    .HasColumnName("CMODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpartName)
                    .IsRequired()
                    .HasColumnName("CPART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.CpartNo)
                    .IsRequired()
                    .HasColumnName("CPART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CpartType)
                    .IsRequired()
                    .HasColumnName("CPART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtypeDesc)
                    .HasColumnName("CTYPE_DESC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsApl).HasColumnName("IS_APL");

                entity.Property(e => e.IsSnsl).HasColumnName("IS_SNSL");

                entity.Property(e => e.ManCode)
                    .HasColumnName("MAN_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mcat)
                    .IsRequired()
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Part).HasColumnName("PART");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .IsRequired()
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.TypeDesc)
                    .HasColumnName("TYPE_DESC")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VCEqpConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_EQP_CONFIG");

                entity.Property(e => e.Cage)
                    .IsRequired()
                    .HasColumnName("CAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Configid)
                    .HasColumnName("CONFIGID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Configno)
                    .HasColumnName("CONFIGNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Configno2)
                    .HasColumnName("CONFIGNO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endpart).HasColumnName("ENDPART");

                entity.Property(e => e.Eswbs)
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasColumnName("HEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ind).HasColumnName("IND");

                entity.Property(e => e.Indchildcount).HasColumnName("INDCHILDCOUNT");

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManufacturerName)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.McatDesc)
                    .IsRequired()
                    .HasColumnName("MCAT_DESC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Mmtr)
                    .HasColumnName("MMTR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mtbf)
                    .HasColumnName("MTBF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Part).HasColumnName("PART");

                entity.Property(e => e.PartCharacteristics)
                    .IsRequired()
                    .HasColumnName("PART_CHARACTERISTICS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Partdesc)
                    .IsRequired()
                    .HasColumnName("PARTDESC")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Pchildcount).HasColumnName("PCHILDCOUNT");

                entity.Property(e => e.Pconfigid)
                    .HasColumnName("PCONFIGID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pconfigno)
                    .HasColumnName("PCONFIGNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pconfigno2)
                    .HasColumnName("PCONFIGNO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Peswbs)
                    .HasColumnName("PESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppart).HasColumnName("PPART");

                entity.Property(e => e.Trid).HasColumnName("TRID");

                entity.Property(e => e.TypeDesc)
                    .IsRequired()
                    .HasColumnName("TYPE_DESC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VCPartdetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_PARTDETAILS");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded)
                    .HasColumnName("DATE_ADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("DATE_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Height)
                    .HasColumnName("HEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdateby).HasColumnName("LAST_UPDATEBY");

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManCode)
                    .HasColumnName("MAN_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mcat)
                    .IsRequired()
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.McatDesc)
                    .IsRequired()
                    .HasColumnName("MCAT_DESC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Mmtr)
                    .HasColumnName("MMTR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mtbf)
                    .HasColumnName("MTBF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PartCharacteristics)
                    .HasColumnName("PART_CHARACTERISTICS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasColumnName("PART_CODE")
                    .HasMaxLength(49)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .IsRequired()
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.RevisionNo).HasColumnName("REVISION_NO");

                entity.Property(e => e.TypeDesc)
                    .HasColumnName("TYPE_DESC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VCPartdictionary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_PARTDICTIONARY");

                entity.Property(e => e.Ac).HasColumnName("AC");

                entity.Property(e => e.AddBy)
                    .HasColumnName("ADD_BY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate)
                    .HasColumnName("ADD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Anc).HasColumnName("ANC");

                entity.Property(e => e.Ap).HasColumnName("AP");

                entity.Property(e => e.App).HasColumnName("APP");

                entity.Property(e => e.Asc).HasColumnName("ASC");

                entity.Property(e => e.Brf)
                    .HasColumnName("BRF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpartCount).HasColumnName("CPART_COUNT");

                entity.Property(e => e.Currency).HasColumnName("CURRENCY");

                entity.Property(e => e.CustodyId).HasColumnName("CUSTODY_ID");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("DATE_ADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("DATE_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DerivativeId).HasColumnName("DERIVATIVE_ID");

                entity.Property(e => e.Diameter).HasColumnName("DIAMETER");

                entity.Property(e => e.DocSecId).HasColumnName("DOC_SEC_ID");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HZECode).HasColumnName("H_Z_E_CODE");

                entity.Property(e => e.Height)
                    .HasColumnName("HEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsVendor).HasColumnName("IS_VENDOR");

                entity.Property(e => e.LastUpdateby).HasColumnName("LAST_UPDATEBY");

                entity.Property(e => e.LeadTimeId).HasColumnName("LEAD_TIME_ID");

                entity.Property(e => e.LeditedBy)
                    .HasColumnName("LEDITED_BY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LeditedDate)
                    .HasColumnName("LEDITED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManCode)
                    .HasColumnName("MAN_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mcat)
                    .IsRequired()
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.McatDesc)
                    .IsRequired()
                    .HasColumnName("MCAT_DESC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Mmtr)
                    .HasColumnName("MMTR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mtbf)
                    .HasColumnName("MTBF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OldNsn)
                    .HasColumnName("OLD_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OldSmic).HasColumnName("OLD_SMIC");

                entity.Property(e => e.Osi).HasColumnName("OSI");

                entity.Property(e => e.PartCat)
                    .HasColumnName("PART_CAT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PartCharacteristics)
                    .HasColumnName("PART_CHARACTERISTICS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasColumnName("PART_CODE")
                    .HasMaxLength(49)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .IsRequired()
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.PhstCode)
                    .HasColumnName("PHST_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasColumnName("PICTURE_FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PmsCCode)
                    .HasColumnName("PMS_C_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionNo).HasColumnName("REVISION_NO");

                entity.Property(e => e.ShelfLifeId).HasColumnName("SHELF_LIFE_ID");

                entity.Property(e => e.SlaId).HasColumnName("SLA_ID");

                entity.Property(e => e.SmcId).HasColumnName("SMC_ID");

                entity.Property(e => e.Smic).HasColumnName("SMIC");

                entity.Property(e => e.Smr)
                    .HasColumnName("SMR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempNsn)
                    .HasColumnName("TEMP_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCparts).HasColumnName("TOTAL_CPARTS");

                entity.Property(e => e.TrId).HasColumnName("TR_ID");

                entity.Property(e => e.TssId).HasColumnName("TSS_ID");

                entity.Property(e => e.TypeDesc)
                    .HasColumnName("TYPE_DESC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCube).HasColumnName("UNIT_CUBE");

                entity.Property(e => e.UnitOfItem).HasColumnName("UNIT_OF_ITEM");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VCPartinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_PARTINFO");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .HasColumnName("CURR_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrName)
                    .HasColumnName("CURR_NAME")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.Currency).HasColumnName("CURRENCY");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("DATE_ADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("DATE_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisposalCost)
                    .HasColumnName("DISPOSAL_COST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EolEnvCln)
                    .HasColumnName("EOL_ENV_CLN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EolSalv)
                    .HasColumnName("EOL_SALV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Height)
                    .HasColumnName("HEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdateby).HasColumnName("LAST_UPDATEBY");

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LotSize)
                    .HasColumnName("LOT_SIZE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManCode)
                    .HasColumnName("MAN_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mcat)
                    .IsRequired()
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.McatDesc)
                    .IsRequired()
                    .HasColumnName("MCAT_DESC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MiFailR)
                    .HasColumnName("MI_FAIL_R")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mmtr)
                    .HasColumnName("MMTR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mtbf)
                    .HasColumnName("MTBF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PartCharacteristics)
                    .HasColumnName("PART_CHARACTERISTICS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasColumnName("PART_CODE")
                    .HasMaxLength(49)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .IsRequired()
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PERSON_ID");

                entity.Property(e => e.Plt).HasColumnName("PLT");

                entity.Property(e => e.PriceBuy)
                    .HasColumnName("PRICE_BUY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rctc).HasColumnName("RCTC");

                entity.Property(e => e.Rctd).HasColumnName("RCTD");

                entity.Property(e => e.Rcti).HasColumnName("RCTI");

                entity.Property(e => e.Rcto).HasColumnName("RCTO");

                entity.Property(e => e.RefYear).HasColumnName("REF_YEAR");

                entity.Property(e => e.RevisionNo).HasColumnName("REVISION_NO");

                entity.Property(e => e.Rip)
                    .HasColumnName("RIP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rlt).HasColumnName("RLT");

                entity.Property(e => e.Rr)
                    .HasColumnName("RR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RtOk)
                    .HasColumnName("RT_OK")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Scc)
                    .HasColumnName("SCC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Scl).HasColumnName("SCL");

                entity.Property(e => e.SpefRep)
                    .HasColumnName("SPEF_REP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeDesc)
                    .HasColumnName("TYPE_DESC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UcIncr)
                    .HasColumnName("UC_INCR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UcTotal)
                    .HasColumnName("UC_TOTAL")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WtInc).HasColumnName("WT_INC");

                entity.Property(e => e.WtTotal).HasColumnName("WT_TOTAL");
            });

            modelBuilder.Entity<VCUconfigSystemchilds>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_UCONFIG_SYSTEMCHILDS");

                entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");

                entity.Property(e => e.Eswbs)
                    .IsRequired()
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maxchildindex)
                    .IsRequired()
                    .HasColumnName("MAXCHILDINDEX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nomenclature)
                    .HasColumnName("NOMENCLATURE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Partid).HasColumnName("PARTID");

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");
            });

            modelBuilder.Entity<VCUconigChildcount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_UCONIG_CHILDCOUNT");

                entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");

                entity.Property(e => e.Maxchildindex)
                    .IsRequired()
                    .HasColumnName("MAXCHILDINDEX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Peswbs)
                    .HasColumnName("PESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");
            });

            modelBuilder.Entity<VCUnitconfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_C_UNITCONFIG");

                entity.Property(e => e.AnnualOperationRequirement).HasColumnName("ANNUAL_OPERATION_REQUIREMENT");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CedaReport).HasColumnName("CEDA_REPORT");

                entity.Property(e => e.CidPage)
                    .HasColumnName("CID_PAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CidReport).HasColumnName("CID_REPORT");

                entity.Property(e => e.CobQty).HasColumnName("COB_QTY");

                entity.Property(e => e.ConfigStatus)
                    .HasColumnName("CONFIG_STATUS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Configid)
                    .HasColumnName("CONFIGID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Configno)
                    .HasColumnName("CONFIGNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Configno2)
                    .HasColumnName("CONFIGNO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Csr).HasColumnName("CSR");

                entity.Property(e => e.DrawingNo)
                    .HasColumnName("DRAWING_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Endpart).HasColumnName("ENDPART");

                entity.Property(e => e.Equipmentnumber).HasColumnName("EQUIPMENTNUMBER");

                entity.Property(e => e.Equipmentsequencenumber).HasColumnName("EQUIPMENTSEQUENCENUMBER");

                entity.Property(e => e.Eswbs)
                    .IsRequired()
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FmgQty).HasColumnName("FMG_QTY");

                entity.Property(e => e.GroupNo).HasColumnName("GROUP_NO");

                entity.Property(e => e.Height)
                    .HasColumnName("HEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemSerialNo)
                    .HasColumnName("ITEM_SERIAL_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JnbQty).HasColumnName("JNB_QTY");

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Levelnumber).HasColumnName("LEVELNUMBER");

                entity.Property(e => e.Levelsequencenumber).HasColumnName("LEVELSEQUENCENUMBER");

                entity.Property(e => e.LocNo)
                    .HasColumnName("LOC_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MainEqpt)
                    .HasColumnName("MAIN_EQPT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mainsystemnumber).HasColumnName("MAINSYSTEMNUMBER");

                entity.Property(e => e.MajorEquip).HasColumnName("MAJOR_EQUIP");

                entity.Property(e => e.ManufacturerName)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mcat)
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.McatDesc)
                    .HasColumnName("MCAT_DESC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Mea)
                    .IsRequired()
                    .HasColumnName("MEA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mec).HasColumnName("MEC");

                entity.Property(e => e.MecReport).HasColumnName("MEC_REPORT");

                entity.Property(e => e.Mmtr)
                    .HasColumnName("MMTR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mtbf)
                    .HasColumnName("MTBF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NoOfChange).HasColumnName("NO_OF_CHANGE");

                entity.Property(e => e.Nomenclature)
                    .HasColumnName("NOMENCLATURE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nsn)
                    .IsRequired()
                    .HasColumnName("NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ParentPart)
                    .IsRequired()
                    .HasColumnName("PARENT_PART")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartCharacteristics)
                    .IsRequired()
                    .HasColumnName("PART_CHARACTERISTICS")
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .HasColumnName("PART_CODE")
                    .HasMaxLength(49)
                    .IsUnicode(false);

                entity.Property(e => e.PartName)
                    .HasColumnName("PART_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Partid).HasColumnName("PARTID");

                entity.Property(e => e.Pconfigid)
                    .HasColumnName("PCONFIGID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pconfigno)
                    .HasColumnName("PCONFIGNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pconfigno2)
                    .HasColumnName("PCONFIGNO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Peswbs)
                    .HasColumnName("PESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PmsDesc)
                    .IsRequired()
                    .HasColumnName("PMS_DESC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PmsNo)
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PndQty).HasColumnName("PND_QTY");

                entity.Property(e => e.Printindent).HasColumnName("PRINTINDENT");

                entity.Property(e => e.Printorder).HasColumnName("PRINTORDER");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Repairable).HasColumnName("REPAIRABLE");

                entity.Property(e => e.RhRec).HasColumnName("RH_REC");

                entity.Property(e => e.SiteName)
                    .HasColumnName("SITE_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Subsystemnumber).HasColumnName("SUBSYSTEMNUMBER");

                entity.Property(e => e.SwbsOrder)
                    .HasColumnName("SWBS_ORDER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Systemnumber).HasColumnName("SYSTEMNUMBER");

                entity.Property(e => e.TypeDesc)
                    .HasColumnName("TYPE_DESC")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UpkeepCode).HasColumnName("UPKEEP_CODE");

                entity.Property(e => e.Vol)
                    .HasColumnName("VOL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VCamsParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CAMS_PARTS");

                entity.Property(e => e.Brf)
                    .HasColumnName("BRF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cage)
                    .HasColumnName("CAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnName("CURRENCY_ID");

                entity.Property(e => e.DLevel)
                    .HasColumnName("D_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diameter).HasColumnName("DIAMETER");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("MANUFACTURER_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerNo)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Mcat)
                    .IsRequired()
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mec).HasColumnName("MEC");

                entity.Property(e => e.Mtbf).HasColumnName("MTBF");

                entity.Property(e => e.Nsn)
                    .IsRequired()
                    .HasColumnName("NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OLevel)
                    .HasColumnName("O_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OldNsn)
                    .HasColumnName("OLD_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PartCharacteristic)
                    .HasColumnName("PART_CHARACTERISTIC")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PartName)
                    .HasColumnName("PART_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .IsRequired()
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhstCode)
                    .HasColumnName("PHST_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasColumnName("PICTURE_FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PmsCCode)
                    .HasColumnName("PMS_C_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PorQty2y).HasColumnName("POR_QTY2Y");

                entity.Property(e => e.PorQty40).HasColumnName("POR_QTY40");

                entity.Property(e => e.SlId).HasColumnName("SL_ID");

                entity.Property(e => e.Smr)
                    .HasColumnName("SMR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TempNsn)
                    .HasColumnName("TEMP_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TorQty2y).HasColumnName("TOR_QTY2Y");

                entity.Property(e => e.TorQty40).HasColumnName("TOR_QTY40");

                entity.Property(e => e.UnitOfItem)
                    .HasColumnName("UNIT_OF_ITEM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.UomId).HasColumnName("UOM_id");

                entity.Property(e => e.VendorNo)
                    .HasColumnName("VENDOR_NO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");

                entity.Property(e => e.Width).HasColumnName("WIDTH");
            });

            modelBuilder.Entity<VCasaplparts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CASAPLPARTS");

                entity.Property(e => e.AplNo)
                    .IsRequired()
                    .HasColumnName("APL_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingNo)
                    .HasColumnName("DRAWING_NO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.ManufacturerNo)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PageNo)
                    .HasColumnName("PAGE_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionNo)
                    .HasColumnName("POSITION_NO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Smr)
                    .HasColumnName("SMR")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TpiNo)
                    .IsRequired()
                    .HasColumnName("TPI_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDDocconfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_D_DOCCONFIG");

                entity.Property(e => e.DocFile)
                    .HasColumnName("DOC_FILE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.DocName)
                    .HasColumnName("DOC_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocRemarks)
                    .HasColumnName("DOC_REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocType).HasColumnName("DOC_TYPE");

                entity.Property(e => e.DocTypeDesc)
                    .HasColumnName("DOC_TYPE_DESC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eswbs)
                    .IsRequired()
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");
            });

            modelBuilder.Entity<VDDocmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_D_DOCMASTER");

                entity.Property(e => e.DocFile)
                    .HasColumnName("DOC_FILE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.DocName)
                    .HasColumnName("DOC_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocRemarks)
                    .HasColumnName("DOC_REMARKS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocType).HasColumnName("DOC_TYPE");

                entity.Property(e => e.DocTypeDesc)
                    .HasColumnName("DOC_TYPE_DESC")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VMPms>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M_PMS");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmsNo)
                    .IsRequired()
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VMTaskParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M_TASK_PARTS");

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Anc)
                    .HasColumnName("ANC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ap)
                    .HasColumnName("AP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.App)
                    .HasColumnName("APP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asc)
                    .HasColumnName("ASC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Brf)
                    .HasColumnName("BRF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustodyId)
                    .HasColumnName("CUSTODY_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DLevel)
                    .HasColumnName("D_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DerivativeId)
                    .HasColumnName("DERIVATIVE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Diameter).HasColumnName("DIAMETER");

                entity.Property(e => e.DocNo)
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DocSecId)
                    .HasColumnName("DOC_SEC_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HZECode)
                    .HasColumnName("H_Z_E_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasColumnName("HEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LeadTimeId)
                    .HasColumnName("LEAD_TIME_ID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManId).HasColumnName("MAN_ID");

                entity.Property(e => e.Mcat)
                    .IsRequired()
                    .HasColumnName("MCAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mmtr)
                    .HasColumnName("MMTR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MopNo)
                    .IsRequired()
                    .HasColumnName("MOP_NO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mtbf)
                    .HasColumnName("MTBF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nsn)
                    .HasColumnName("NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OLevel)
                    .HasColumnName("O_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OldNsn)
                    .HasColumnName("OLD_NSN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OldSmic)
                    .HasColumnName("OLD_SMIC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Osi)
                    .HasColumnName("OSI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartCat)
                    .HasColumnName("PART_CAT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PartCharacteristics)
                    .HasColumnName("PART_CHARACTERISTICS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .IsRequired()
                    .HasColumnName("PART_CODE")
                    .HasMaxLength(49)
                    .IsUnicode(false);

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PartMec).HasColumnName("PART_MEC");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartType)
                    .IsRequired()
                    .HasColumnName("PART_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentData).HasColumnName("PERMANENT_DATA");

                entity.Property(e => e.PhstCode)
                    .HasColumnName("PHST_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasColumnName("PICTURE_FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PmsCCode)
                    .HasColumnName("PMS_C_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PmsNo)
                    .IsRequired()
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PorQty2y).HasColumnName("POR_QTY2Y");

                entity.Property(e => e.PorQty40).HasColumnName("POR_QTY40");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.ShelfLifeId)
                    .HasColumnName("SHELF_LIFE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SlaId)
                    .HasColumnName("SLA_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SmcId)
                    .HasColumnName("SMC_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Smic)
                    .HasColumnName("SMIC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Smr)
                    .HasColumnName("SMR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TorQty2y).HasColumnName("TOR_QTY2Y");

                entity.Property(e => e.TorQty40).HasColumnName("TOR_QTY40");

                entity.Property(e => e.TssId)
                    .HasColumnName("TSS_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCube)
                    .HasColumnName("UNIT_CUBE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfItem)
                    .HasColumnName("UNIT_OF_ITEM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("UNIT_PRICE")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.VendorNo)
                    .HasColumnName("VENDOR_NO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VMTaskmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M_TASKMASTER");

                entity.Property(e => e.Alias)
                    .HasColumnName("ALIAS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AliasSwbs)
                    .HasColumnName("ALIAS_SWBS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ByWhom)
                    .HasColumnName("BY_WHOM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("DOC_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DrydockReq)
                    .HasColumnName("DRYDOCK_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Duedate)
                    .HasColumnName("DUEDATE")
                    .HasColumnType("date");

                entity.Property(e => e.ElapsedTime).HasColumnName("ELAPSED_TIME");

                entity.Property(e => e.ExceptMop)
                    .HasColumnName("EXCEPT_MOP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Jic)
                    .HasColumnName("JIC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ManHourEe).HasColumnName("MAN_HOUR_EE");

                entity.Property(e => e.ManHourEl).HasColumnName("MAN_HOUR_EL");

                entity.Property(e => e.ManHourMc).HasColumnName("MAN_HOUR_MC");

                entity.Property(e => e.MopNo)
                    .IsRequired()
                    .HasColumnName("MOP_NO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mtr)
                    .HasColumnName("MTR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfManEe).HasColumnName("NUMBER_OF_MAN_EE");

                entity.Property(e => e.NumberOfManEl).HasColumnName("NUMBER_OF_MAN_EL");

                entity.Property(e => e.NumberOfManMc).HasColumnName("NUMBER_OF_MAN_MC");

                entity.Property(e => e.NumberOfPeriodDate).HasColumnName("NUMBER_OF_PERIOD_DATE");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasColumnName("PART_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.Period).HasColumnName("PERIOD");

                entity.Property(e => e.PeriodCode)
                    .HasColumnName("PERIOD_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodHour).HasColumnName("PERIOD_HOUR");

                entity.Property(e => e.PmsNo)
                    .IsRequired()
                    .HasColumnName("PMS_NO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.RefitPk)
                    .HasColumnName("REFIT_PK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Removal)
                    .HasColumnName("REMOVAL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RepairablePoolReq)
                    .HasColumnName("REPAIRABLE_POOL_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Report).HasColumnName("REPORT");

                entity.Property(e => e.Reportline).HasColumnName("REPORTLINE");

                entity.Property(e => e.SafetyPrecaution)
                    .HasColumnName("SAFETY_PRECAUTION")
                    .IsUnicode(false);

                entity.Property(e => e.TaskEssentialNo)
                    .HasColumnName("TASK_ESSENTIAL_NO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TaskProcedure)
                    .HasColumnName("TASK_PROCEDURE")
                    .IsUnicode(false);

                entity.Property(e => e.TmlReq)
                    .HasColumnName("TML_REQ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateRevision).HasColumnName("UPDATE_REVISION");

                entity.Property(e => e.UpdateStatus).HasColumnName("UPDATE_STATUS");

                entity.Property(e => e.UpkeepCode)
                    .HasColumnName("UPKEEP_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VPartlistTep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PARTLIST_TEP");

                entity.Property(e => e.Part).HasColumnName("PART");

                entity.Property(e => e.PartId).HasColumnName("PART_ID");

                entity.Property(e => e.Qty).HasColumnName("QTY");
            });

            modelBuilder.Entity<VUconfigSystemchilds>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_UCONFIG_SYSTEMCHILDS");

                entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");

                entity.Property(e => e.Eswbs)
                    .IsRequired()
                    .HasColumnName("ESWBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nomenclature)
                    .HasColumnName("NOMENCLATURE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Partid).HasColumnName("PARTID");

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.Command).HasColumnName("COMMAND");

                entity.Property(e => e.CommandId).HasColumnName("COMMAND_ID");

                entity.Property(e => e.CommandName)
                    .HasColumnName("COMMAND_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InductionDate)
                    .HasColumnName("INDUCTION_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OpsAvailability)
                    .HasColumnName("OPS_AVAILABILITY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpsDefect).HasColumnName("OPS_DEFECT");

                entity.Property(e => e.OpsReadiness)
                    .HasColumnName("OPS_READINESS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SiteName)
                    .HasColumnName("SITE_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo).HasColumnName("SITE_NO");

                entity.Property(e => e.SitePic)
                    .HasColumnName("SITE_PIC")
                    .HasColumnType("image");

                entity.Property(e => e.SiteType)
                    .HasColumnName("SITE_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCommand).HasColumnName("TYPE_COMMAND");

                entity.Property(e => e.TypeCommandName)
                    .HasColumnName("TYPE_COMMAND_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

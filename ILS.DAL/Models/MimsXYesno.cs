using System;
using System.Collections.Generic;

namespace ILS.DAL.Models
{
    public partial class MimsXYesno
    {
        public MimsXYesno()
        {
            MimsCCpartsIsAplNavigation = new HashSet<MimsCCparts>();
            MimsCCpartsIsSnslNavigation = new HashSet<MimsCCparts>();
            MimsCPartvendorlist = new HashSet<MimsCPartvendorlist>();
            MimsCPartvendors = new HashSet<MimsCPartvendors>();
            MimsCUnitconfigCedaReportNavigation = new HashSet<MimsCUnitconfig>();
            MimsCUnitconfigCidReportNavigation = new HashSet<MimsCUnitconfig>();
            MimsCUnitconfigCsrNavigation = new HashSet<MimsCUnitconfig>();
            MimsCUnitconfigMajorEquipNavigation = new HashSet<MimsCUnitconfig>();
            MimsCUnitconfigMecReportNavigation = new HashSet<MimsCUnitconfig>();
            MimsCUnitconfigRepairableNavigation = new HashSet<MimsCUnitconfig>();
            MimsMEswbspms = new HashSet<MimsMEswbspms>();
            MimsWoWorkcenters = new HashSet<MimsWoWorkcenters>();
        }

        public int IsId { get; set; }
        public string IsName { get; set; }

        public virtual ICollection<MimsCCparts> MimsCCpartsIsAplNavigation { get; set; }
        public virtual ICollection<MimsCCparts> MimsCCpartsIsSnslNavigation { get; set; }
        public virtual ICollection<MimsCPartvendorlist> MimsCPartvendorlist { get; set; }
        public virtual ICollection<MimsCPartvendors> MimsCPartvendors { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfigCedaReportNavigation { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfigCidReportNavigation { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfigCsrNavigation { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfigMajorEquipNavigation { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfigMecReportNavigation { get; set; }
        public virtual ICollection<MimsCUnitconfig> MimsCUnitconfigRepairableNavigation { get; set; }
        public virtual ICollection<MimsMEswbspms> MimsMEswbspms { get; set; }
        public virtual ICollection<MimsWoWorkcenters> MimsWoWorkcenters { get; set; }
    }
}

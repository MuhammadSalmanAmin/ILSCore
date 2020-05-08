using ILS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ILS.Services
{
    public   interface IPartsService : IDisposable
    {

        public abstract List<CustomClass> GetChildPartList(string parentPartId, bool getChildRECORDS);
        public abstract    void AddParts(AddPartViewModel model);
        public abstract   MimsCParts GetPartById(int id);

        public abstract   List<MimsCParts> GetPartsList();

        public abstract   List<MimsCPartvendorlist> GetVendorList();

        public abstract   List<MimsCParttype> GetPartType();

        public abstract   List<MimsCPartcat> GetPartsCategory();

        public abstract   List<MimsXCurrency> GetCurrency();

        public abstract   List<MimsXUom> GetUnitItems();
        public abstract   List<MimsXGroup> GetGroupInfo();

        public abstract   List<MimsCCage> GetCageInfo(int? id=null);
        public abstract   List<MimsCPartvendors> GetVendorInfo();

        public abstract   List<MimsCMcat> GetMaterialcCategoryItems();

        public abstract   List<MimsXAp> GetAPItemsList();

        public abstract   List<MimsXAc> GetACItemsList();

        public abstract   List<MimsXAsc> GetASCItemsList();
        public abstract   List<MimsXMec> GetMECInfo();

        public abstract   List<MimsXAnc> GetANCInfo();

        public abstract   List<MimsXApp> GetAPPInfo();
        public abstract   List<MimsXCustody> GetCustodyInfo();

        public abstract   List<MimsXSmc> GetSMCInfo();
        public abstract   List<MimsXShelflife> GetShelfLifeItems();
        public abstract   List<MimsXDerivative> GetDerivativeItems();
        public abstract   List<MimsXSmic> GetSMICItems();

        public abstract   List<MimsXTimeperiod> GetLeadTimeItems();
        public abstract   List<MimsXTss> GetTSSItems();
        public abstract   List<MimsXOsi> GetOSIItems();

        public abstract   List<MimsXUom> GetUnitCubeItems();
        public abstract   List<MimsXSecurity> GetSecurityItems();

        public abstract   List<MimsXSla> GetSLAInfo();

        public abstract DataTable GetTreeViewData(string partId);
        public abstract List<CustomClass> GetPartsData(string filter);

        public abstract bool DeletePart(string partId);

        public abstract bool LinkPart(string quantity, string parentPartId, string childPartId);

        public abstract IEnumerable<MimsASites> GetAllSite();
    }
}

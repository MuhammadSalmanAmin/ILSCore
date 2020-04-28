using ILS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ILS.Services
{
    public abstract class IPartsService : IDisposable
    {
        public abstract dynamic GetChildPartList(string parentPartId, bool exclude);

        public abstract void AddParts(AddPartViewModel model);
        public abstract List<MimsCParts> GetPartsList();

        public abstract List<MimsCPartvendorlist> GetVendorList();

        public abstract List<MimsCParttype> GetPartType();

        public abstract List<MimsCPartcat> GetPartsCategory();

        public abstract List<MimsXCurrency> GetCurrency();

        public abstract List<MimsXUom> GetUnitItems();
        public abstract List<MimsXGroup> GetGroupInfo();

        public abstract List<MimsCCage> GetCageInfo();
        public abstract List<MimsCPartvendors> GetVendorInfo();

        public abstract List<MimsCMcat> GetMaterialcCategoryItems();
        public void Dispose()
        {

        }

    }
}

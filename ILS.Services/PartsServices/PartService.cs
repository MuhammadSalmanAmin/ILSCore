using ILS.DAL;
using ILS.DAL.Models;
using ILS.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace ILS.Services
{
    public class PartService : BaseDataAccess, IPartsService
    {
        ILMMContext _context = new ILMMContext();
        BaseDataAccess _baseDataAccess = new BaseDataAccess();
        public void AddParts(AddPartViewModel model)
        {
            model.PartNumber = DateTime.Now.ToString("yyyyMMdd");
            _context.Add(model.ToPartsEntity());
            _context.SaveChanges();
        }

        public MimsCParts GetPartById(int id)
        {
            return _context.MimsCParts.FirstOrDefault(x => x.PartId == id);
        }

        public List<MimsCCage> GetCageInfo(int? id = null)
        {
            return _context.MimsCCage.ToList();
        }

        public List<CustomClass> GetChildPartList(string parentPartId, bool getChildRECORDS)
        {
            long parentId = Convert.ToInt64(parentPartId);


            if (getChildRECORDS)
            {
                var result = from c in _context.MimsCParts
                              join sub in
                              (
                                  from partList in _context.MimsCCparts
                                  join parts in _context.MimsCParts
                                  on partList.Part equals parts.PartId
                                  where parts.PartId == parentId
                                  orderby parts.PartCat
                                  select new
                                  {
                                      parts,
                                      partList,
                                      partList.PartId
                                  }
                               )
                             on c.PartId equals sub.PartId  
                             join manufacturer in _context.MimsCCage on c.ManId equals manufacturer.ManId
                             join partType in _context.MimsCParttype on c.PartType equals partType.PartType

                             select new CustomClass
                             {
                                 ManufacturerName = manufacturer.ManufacturerName,
                                 Description = partType.TypeDesc,
                                 PartNumber = c.PartNo,
                                 PartName = c.PartName,
                                 Quantity = sub.partList.Qty,
                                 PartId = c.PartId.ToString()
                             };

                return result.ToList();
            }
            else
            {
                var result = from parts in _context.MimsCParts
                             where parts.PartId != parentId
                             orderby parts.PartCat
                             join manufacturer in _context.MimsCCage on parts.ManId equals manufacturer.ManId
                             join partType in _context.MimsCParttype on parts.PartType equals partType.PartType

                             select new CustomClass
                             {
                                 ManufacturerName = manufacturer.ManufacturerName,
                                 Description = partType.TypeDesc,
                                 PartNumber = parts.PartNo,
                                 PartName = parts.PartName,
                                 PartId = parts.PartId.ToString()
                             };

                return result.ToList();
            }

        }

        public List<MimsXCurrency> GetCurrency()
        {
            return _context.MimsXCurrency.ToList();
        }

        public List<MimsXGroup> GetGroupInfo()
        {
            return _context.MimsXGroup.ToList();
        }

        public List<MimsCPartcat> GetPartsCategory()
        {
            return _context.MimsCPartcat.ToList();
        }

        public List<MimsCParts> GetPartsList()
        {
            return _context.MimsCParts.ToList();
        }

        public List<MimsCParttype> GetPartType()
        {
            return _context.MimsCParttype.ToList();
        }

        public List<MimsXUom> GetUnitItems()
        {
            return _context.MimsXUom.ToList();
        }

        public List<MimsCPartvendors> GetVendorInfo()
        {
            return _context.MimsCPartvendors.ToList();
        }

        public List<MimsCPartvendorlist> GetVendorList()
        {
            return _context.MimsCPartvendorlist.ToList();
        }

        public List<MimsCMcat> GetMaterialcCategoryItems()
        {
            return _context.MimsCMcat.ToList();
        }

        public List<MimsXMec> GetMECInfo()
        {
            return _context.MimsXMec.ToList();
        }

        public List<MimsXAp> GetAPItemsList()
        {
            return _context.MimsXAp.ToList();
        }

        public List<MimsXAc> GetACItemsList()
        {
            return _context.MimsXAc.ToList();
        }

        public List<MimsXAsc> GetASCItemsList()
        {
            return _context.MimsXAsc.ToList();
        }

        public List<MimsXAnc> GetANCInfo()
        {
            return _context.MimsXAnc.ToList();
        }

        public List<MimsXApp> GetAPPInfo()
        {
            return _context.MimsXApp.ToList();
        }

        public List<MimsXCustody> GetCustodyInfo()
        {
            return _context.MimsXCustody.ToList();
        }

        public List<MimsXSmc> GetSMCInfo()
        {
            return _context.MimsXSmc.ToList();
        }

        public List<MimsXShelflife> GetShelfLifeItems()
        {
            return _context.MimsXShelflife.ToList();
        }

        public List<MimsXDerivative> GetDerivativeItems()
        {
            return _context.MimsXDerivative.ToList();
        }

        public List<MimsXSmic> GetSMICItems()
        {
            return _context.MimsXSmic.ToList();
        }

        public List<MimsXTimeperiod> GetLeadTimeItems()
        {
            return _context.MimsXTimeperiod.ToList();
        }

        public List<MimsXTss> GetTSSItems()
        {
            return _context.MimsXTss.ToList();
        }

        public List<MimsXOsi> GetOSIItems()
        {
            return _context.MimsXOsi.ToList();
        }

        public List<MimsXUom> GetUnitCubeItems()
        {
            return _context.MimsXUom.ToList();
        }

        public List<MimsXSecurity> GetSecurityItems()
        {
            return _context.MimsXSecurity.ToList();
        }

        public List<MimsXSla> GetSLAInfo()
        {
            return _context.MimsXSla.ToList();
        }

        public DataTable GetTreeViewData(string partID)
        {

            DataTable dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=.\\SQLExpress;Database=ILMM;Trusted_Connection=True;"))
            {
                string sql = "spGetTreeViewData";
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@partId", partID);
                    sqlConn.Open();
                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                    {
                        sqlAdapter.Fill(dt);
                    }
                    sqlConn.Close();
                }
            }

            return dt;
        }

        public List<CustomClass> GetPartsData()
        {
            try
            {
                var query = from u in _context.MimsCParts
                            join p in _context.MimsCCparts on u.PartId equals p.Part
                            into gj
                            from x in gj.DefaultIfEmpty()
                            where u.PartType == "A" || u.PartType == "X"
                            join manufacturer in _context.MimsCCage on u.ManId equals manufacturer.ManId
                            join partType in _context.MimsCParttype on u.PartType equals partType.PartType
                            group u by new { u.PartName, u.PartId, manufacturer.ManufacturerName, partType.TypeDesc, u.PartNo } into g
                            select new CustomClass
                            {
                                PartId = g.Key.PartId.ToString(),
                                ManufacturerName = g.Key.ManufacturerName,
                                Description = g.Key.TypeDesc,
                                PartNumber = g.Key.PartNo,
                                PartName = g.Key.PartName,
                                Quantity = g.Count()
                            };

                return query.ToList();
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public bool LinkPart(string quantity, string parentPartId, string childPartId)
        {
            var isAlreadyLinked = _context.MimsCCparts.FirstOrDefault(x => x.Part == Convert.ToInt64(parentPartId) && x.PartId == Convert.ToInt64(childPartId));
            if (isAlreadyLinked != null)
            {
                isAlreadyLinked.Qty = isAlreadyLinked.Qty + Convert.ToInt32(quantity);
                _context.Update(isAlreadyLinked);
            }
            else
            {
                _context.Add(new MimsCCparts()
                {
                    Qty = Convert.ToInt32(quantity),
                    Part = Convert.ToInt64(parentPartId),
                    PartId = Convert.ToInt64(childPartId),
                });
            }
            return _context.SaveChanges() == 1 ? true : false;
        }

        public  bool DeletePart(string partId)
        {
            int id = Convert.ToInt32(partId);
            var part = _context.MimsCParts.FirstOrDefault(x => x.PartId == id);
            _context.Remove(part);
            return _context.SaveChanges() == 1 ? true : false;
        }

        public int GetHashCode()
        {
            return base.GetHashCode();
        }


        public void Dispose()
        {

        }
    }
}

using ILS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ILS.Services
{
    public static class EntityMapper
    {
        public static MimsCParts ToPartsEntity(this AddPartViewModel model)
        {
            MimsCParts entity = new MimsCParts()
            {
                ManId = !String.IsNullOrEmpty(model.ManufacturerId) ? long.Parse(model.ManufacturerId) : 0,
                Mcat = model.MaterialCategoryId,
                PartCat = model.PartCategoryId,
                PartType = model.PartTypeId,
                Ac = !String.IsNullOrEmpty(model.AC) ? Convert.ToInt32(model.AC) : 0,
                Anc = !String.IsNullOrEmpty(model.ANC) ? Convert.ToInt32(model.ANC) : 0,
                Ap = !String.IsNullOrEmpty(model.AP) ? Convert.ToInt32(model.AP) : 0,
                App = !String.IsNullOrEmpty(model.APP) ? Convert.ToInt32(model.APP) : 0,
                Asc = !String.IsNullOrEmpty(model.ASC) ? Convert.ToInt32(model.ASC) : 0,
                Currency = !String.IsNullOrEmpty(model.Currency) ? Convert.ToInt32(model.Currency) : 0,
                CustodyId = !String.IsNullOrEmpty(model.CustodyId) ? Convert.ToInt32(model.CustodyId) : 0,
                DerivativeId = !String.IsNullOrEmpty(model.Derivative) ? Convert.ToInt32(model.Derivative) : 0,
                HZECode = !String.IsNullOrEmpty(model.GroupModelId) ? Convert.ToInt32(model.GroupModelId) : 0,
                PartMec = !String.IsNullOrEmpty(model.PartMEC) ? Convert.ToInt32(model.PartMEC) : 0,
                Osi = !String.IsNullOrEmpty(model.OSIId) ? Convert.ToInt32(model.OSIId) : 0,
                DocSecId = !String.IsNullOrEmpty(model.SecurityId) ? Convert.ToInt32(model.SecurityId) : 0,
                ShelfLifeId = !String.IsNullOrEmpty(model.ShelfLifeId) ? Convert.ToInt32(model.ShelfLifeId) : 0,
                SlaId = !String.IsNullOrEmpty(model.SLA) ? Convert.ToInt32(model.SLA) : 0,
                SmcId = !String.IsNullOrEmpty(model.SMC) ? Convert.ToInt32(model.SMC) : 0,
                Smic = !String.IsNullOrEmpty(model.SMIC) ? Convert.ToInt32(model.SMIC) : 0,
                LeadTimeId = !String.IsNullOrEmpty(model.LeadTimeId) ? Convert.ToInt32(model.LeadTimeId) : 0,
                TssId = !String.IsNullOrEmpty(model.TSS) ? Convert.ToInt32(model.TSS) : 0,
                UnitCube = !String.IsNullOrEmpty(model.UnitCubeId) ? Convert.ToInt32(model.UnitCubeId) : 0,

                PartName = model.PartName,
                PartNo = model.PartNumber,
                PartCode = string.Empty,
                UnitPrice = model.UnitPrice,
                Length = model.Length,
                Width = model.Width,
                Height = model.Height,
                Mtbf = model.MTBF,              
                Brf = model.BRF,
                Diameter = Convert.ToSingle(model.Diameter),
                PartCharacteristics = model.PartCharacteristics,
                PictureFileName = model.PictureFileName,
                Smr = model.SMR,
                

                DateAdded = model.CreationDateTime,
                DateUpdated = model.ModifiedDateTime,
                  
                Mmtr = model.MMTR,
                OldNsn = model.OldNSN,
                OldSmic = !String.IsNullOrEmpty(model.OldSMIC) ? Convert.ToInt32(model.OldSMIC) : 0,

            };

            return entity;
        }
    }
}

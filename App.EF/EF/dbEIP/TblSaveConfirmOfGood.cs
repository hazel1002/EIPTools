using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblSaveConfirmOfGood
    {
        public int CconfirmOfGoodsId { get; set; }
        public int CBuId { get; set; }
        public int CuserId { get; set; }
        public short CconfirmStatus { get; set; }
        public int CdeptId { get; set; }
        public string? CRemark { get; set; }
        public int CgoodsFrontId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

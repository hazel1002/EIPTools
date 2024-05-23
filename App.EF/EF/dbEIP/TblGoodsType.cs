using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblGoodsType
    {
        public int CgoodsTypeId { get; set; }
        public int CBuId { get; set; }
        public string CgoodsType { get; set; } = null!;
        public short Cstatus { get; set; }
        public int CgoodsAmount { get; set; }
        public int Ckeeper { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
    }
}

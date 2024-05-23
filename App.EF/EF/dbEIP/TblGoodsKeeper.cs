using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblGoodsKeeper
    {
        public int CGoodsTypeId { get; set; }
        public int CUserId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int CId { get; set; }
    }
}

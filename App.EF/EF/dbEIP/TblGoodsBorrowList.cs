using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblGoodsBorrowList
    {
        public int Id { get; set; }
        public int CgoodsFrontId { get; set; }
        public int CgoodsId { get; set; }
        public int Camount { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

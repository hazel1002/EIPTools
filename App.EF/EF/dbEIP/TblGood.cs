using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblGood
    {
        public int CgoodsTypeId { get; set; }
        public int CgoodsId { get; set; }
        public short Cstatus { get; set; }
        public string Cgoods { get; set; } = null!;
        public string Cunit { get; set; } = null!;
        public string CgoodsCode { get; set; } = null!;
        public int Cprice { get; set; }
        public int Cstock { get; set; }
        public int CsafetyStock { get; set; }
        public int CmaxApplication { get; set; }
        public int CminiApplication { get; set; }
        public int CuserId { get; set; }
        public string? CPicture { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

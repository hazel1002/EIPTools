using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblGoodsFront
    {
        public int CgoodFrontId { get; set; }
        public int CBuId { get; set; }
        public string? Crecipt { get; set; }
        public bool CisSent { get; set; }
        public string? Cremark { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

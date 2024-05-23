using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPushOfBanner
    {
        public int CBannerId { get; set; }
        public int CDeptId { get; set; }
        public string CDeptName { get; set; } = null!;
        public DateTime CCreateDt { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public short CIsDelete { get; set; }
        public int CCreator { get; set; }
    }
}

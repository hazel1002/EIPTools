using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPushDeptOfBanner
    {
        public int CBannerId { get; set; }
        public int CDeptId { get; set; }
        public DateTime CCreateDt { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public short CIsDelete { get; set; }
        public int CCreator { get; set; }
        public int CPushDeptOfBanner { get; set; }

        public virtual TblBanner CBanner { get; set; } = null!;
        public virtual TblDept CDept { get; set; } = null!;
    }
}

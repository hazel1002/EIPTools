using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblDisplayObject
    {
        public int CDisplayObjectId { get; set; }
        public int CNodeMainId { get; set; }
        public int CDeptId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblNodeMain CNodeMain { get; set; } = null!;
    }
}

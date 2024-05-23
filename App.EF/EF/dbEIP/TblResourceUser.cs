using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblResourceUser
    {
        public int CResourceUserId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int CResourceTypeNameId { get; set; }
        public int CDeptId { get; set; }
        public int CResourceNameId { get; set; }

        public virtual TblDept CDept { get; set; } = null!;
        public virtual TblResource CResourceName { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblResourceTypeUser
    {
        public int CResourceTypeUserId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int CResourceTypeNameId { get; set; }
        public int CDeptId { get; set; }

        public virtual TblDept CDept { get; set; } = null!;
        public virtual TblResourceType CResourceTypeName { get; set; } = null!;
    }
}

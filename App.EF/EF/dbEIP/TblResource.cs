using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblResource
    {
        public TblResource()
        {
            TblResourceKeepers = new HashSet<TblResourceKeeper>();
            TblResourceUsers = new HashSet<TblResourceUser>();
        }

        public int CResourceTypeNameId { get; set; }
        public string CResourceName { get; set; } = null!;
        public int CResourceNameId { get; set; }
        public short CStatus { get; set; }
        public bool CConfirm { get; set; }
        public string? CIllustrate { get; set; }
        public int CDeptId { get; set; }
        public int? CPicture { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public string? CPictureName { get; set; }

        public virtual TblDept CDept { get; set; } = null!;
        public virtual TblResourceType CResourceTypeName { get; set; } = null!;
        public virtual ICollection<TblResourceKeeper> TblResourceKeepers { get; set; }
        public virtual ICollection<TblResourceUser> TblResourceUsers { get; set; }
    }
}

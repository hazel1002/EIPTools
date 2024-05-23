using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblResourceType
    {
        public TblResourceType()
        {
            TblResourceKeepers = new HashSet<TblResourceKeeper>();
            TblResourceTypeUsers = new HashSet<TblResourceTypeUser>();
            TblResources = new HashSet<TblResource>();
        }

        public int CBuId { get; set; }
        public int CResourceTypeNameId { get; set; }
        public string CResourceTypeName { get; set; } = null!;
        public short CStatus { get; set; }
        public int CDeptId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public short CTypeId { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblDept CDept { get; set; } = null!;
        public virtual ICollection<TblResourceKeeper> TblResourceKeepers { get; set; }
        public virtual ICollection<TblResourceTypeUser> TblResourceTypeUsers { get; set; }
        public virtual ICollection<TblResource> TblResources { get; set; }
    }
}

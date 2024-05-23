using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblBanner
    {
        public TblBanner()
        {
            TblPushDeptOfBanners = new HashSet<TblPushDeptOfBanner>();
        }

        public int CBannerId { get; set; }
        public string CBannerName { get; set; } = null!;
        public DateTime COnShelfDate { get; set; }
        public DateTime COffShelfDate { get; set; }
        public string? CUrl { get; set; }
        public short CStatus { get; set; }
        public string? CTransUrl { get; set; }
        public int CPicture { get; set; }
        public bool CIsAppear { get; set; }
        public bool CIsNewPage { get; set; }
        public int CDeptId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int CBuId { get; set; }
        public string? CPictureName { get; set; }
        public string? CDescription { get; set; }
        public string? CLink { get; set; }
        public int COrder { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblDept CDept { get; set; } = null!;
        public virtual ICollection<TblPushDeptOfBanner> TblPushDeptOfBanners { get; set; }
    }
}

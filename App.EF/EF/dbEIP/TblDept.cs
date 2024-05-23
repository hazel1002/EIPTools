using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblDept
    {
        public TblDept()
        {
            TblAttachments = new HashSet<TblAttachment>();
            TblBanners = new HashSet<TblBanner>();
            TblCalendars = new HashSet<TblCalendar>();
            TblMeetTypes = new HashSet<TblMeetType>();
            TblMeets = new HashSet<TblMeet>();
            TblPushDepOfAnnStorages = new HashSet<TblPushDepOfAnnStorage>();
            TblPushDepOfAnns = new HashSet<TblPushDepOfAnn>();
            TblPushDepOfLinks = new HashSet<TblPushDepOfLink>();
            TblPushDepOfVotes = new HashSet<TblPushDepOfVote>();
            TblPushDeptOfBanners = new HashSet<TblPushDeptOfBanner>();
            TblResourceFronts = new HashSet<TblResourceFront>();
            TblResourceTypeUsers = new HashSet<TblResourceTypeUser>();
            TblResourceTypes = new HashSet<TblResourceType>();
            TblResourceUsers = new HashSet<TblResourceUser>();
            TblResources = new HashSet<TblResource>();
            TblUsers = new HashSet<TblUser>();
        }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CBuId { get; set; }
        /// <summary>
        /// 部門流水號
        /// </summary>
        public int CDeptId { get; set; }
        /// <summary>
        /// 部門代號
        /// </summary>
        public string CDeptCode { get; set; } = null!;
        /// <summary>
        /// 部門名稱
        /// </summary>
        public string CDeptName { get; set; } = null!;
        /// <summary>
        /// 父部門ID
        /// </summary>
        public int CParentDeptId { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CCreateDt { get; set; }
        /// <summary>
        /// 建立者
        /// </summary>
        public int CCreator { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime CUpdatedDt { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public int CUpdator { get; set; }
        /// <summary>
        /// 是否刪除
        /// </summary>
        public bool CIsDelete { get; set; }
        /// <summary>
        /// 部門等級
        /// </summary>
        public int CDeptLevel { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual ICollection<TblAttachment> TblAttachments { get; set; }
        public virtual ICollection<TblBanner> TblBanners { get; set; }
        public virtual ICollection<TblCalendar> TblCalendars { get; set; }
        public virtual ICollection<TblMeetType> TblMeetTypes { get; set; }
        public virtual ICollection<TblMeet> TblMeets { get; set; }
        public virtual ICollection<TblPushDepOfAnnStorage> TblPushDepOfAnnStorages { get; set; }
        public virtual ICollection<TblPushDepOfAnn> TblPushDepOfAnns { get; set; }
        public virtual ICollection<TblPushDepOfLink> TblPushDepOfLinks { get; set; }
        public virtual ICollection<TblPushDepOfVote> TblPushDepOfVotes { get; set; }
        public virtual ICollection<TblPushDeptOfBanner> TblPushDeptOfBanners { get; set; }
        public virtual ICollection<TblResourceFront> TblResourceFronts { get; set; }
        public virtual ICollection<TblResourceTypeUser> TblResourceTypeUsers { get; set; }
        public virtual ICollection<TblResourceType> TblResourceTypes { get; set; }
        public virtual ICollection<TblResourceUser> TblResourceUsers { get; set; }
        public virtual ICollection<TblResource> TblResources { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}

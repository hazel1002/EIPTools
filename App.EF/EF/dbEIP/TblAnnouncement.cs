using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAnnouncement
    {
        public TblAnnouncement()
        {
            TblAnnouncementStorages = new HashSet<TblAnnouncementStorage>();
            TblAttachmentOfAnns = new HashSet<TblAttachmentOfAnn>();
            TblLinkOfAnns = new HashSet<TblLinkOfAnn>();
            TblPictureOfAnns = new HashSet<TblPictureOfAnn>();
            TblPushDepOfAnns = new HashSet<TblPushDepOfAnn>();
            TblSaveConfirmOfAnns = new HashSet<TblSaveConfirmOfAnn>();
            TblVideoOfAnns = new HashSet<TblVideoOfAnn>();
            TblViewLogOfAnns = new HashSet<TblViewLogOfAnn>();
        }

        /// <summary>
        /// 公告ID
        /// </summary>
        public int CAnnouncementId { get; set; }
        /// <summary>
        /// 節點ID
        /// </summary>
        public int CNodeMainId { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string? CTitle { get; set; }
        /// <summary>
        /// 公告分類ID
        /// </summary>
        public int? CAnnouncementTypeId { get; set; }
        /// <summary>
        /// 狀態1.上架 0.下架
        /// </summary>
        public int? CStatus { get; set; }
        /// <summary>
        /// 上架日期
        /// </summary>
        public DateTime? COnShelfDate { get; set; }
        /// <summary>
        /// 下架日期
        /// </summary>
        public DateTime? COffShelfDate { get; set; }
        /// <summary>
        /// 置頂
        /// </summary>
        public bool CTop { get; set; }
        public DateTime? CCancelTop { get; set; }
        /// <summary>
        /// 是否必需閱讀
        /// </summary>
        public bool CIsread { get; set; }
        /// <summary>
        /// 每日發送推播予未閱讀者(小時)
        /// </summary>
        public int? CIsSendPush { get; set; }
        /// <summary>
        /// URL
        /// </summary>
        public string? CUrl { get; set; }
        /// <summary>
        /// 簡述
        /// </summary>
        public string? CQoute { get; set; }
        /// <summary>
        /// 文章內容
        /// </summary>
        public string? CContent { get; set; }
        /// <summary>
        /// 是否呈現前台
        /// </summary>
        public bool CIsAppear { get; set; }
        /// <summary>
        /// 是否文章推播
        /// </summary>
        public bool CIsPush { get; set; }
        /// <summary>
        /// 新增時間
        /// </summary>
        public DateTime CCreateDt { get; set; }
        /// <summary>
        /// 新增者
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

        public virtual TblAnnouncementType? CAnnouncementType { get; set; }
        public virtual TblNodeMain CNodeMain { get; set; } = null!;
        public virtual ICollection<TblAnnouncementStorage> TblAnnouncementStorages { get; set; }
        public virtual ICollection<TblAttachmentOfAnn> TblAttachmentOfAnns { get; set; }
        public virtual ICollection<TblLinkOfAnn> TblLinkOfAnns { get; set; }
        public virtual ICollection<TblPictureOfAnn> TblPictureOfAnns { get; set; }
        public virtual ICollection<TblPushDepOfAnn> TblPushDepOfAnns { get; set; }
        public virtual ICollection<TblSaveConfirmOfAnn> TblSaveConfirmOfAnns { get; set; }
        public virtual ICollection<TblVideoOfAnn> TblVideoOfAnns { get; set; }
        public virtual ICollection<TblViewLogOfAnn> TblViewLogOfAnns { get; set; }
    }
}

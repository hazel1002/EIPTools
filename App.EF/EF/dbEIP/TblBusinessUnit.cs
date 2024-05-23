using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    /// <summary>
    /// 企業主檔
    /// </summary>
    public partial class TblBusinessUnit
    {
        public TblBusinessUnit()
        {
            TblAddressbooks = new HashSet<TblAddressbook>();
            TblAnnouncementTypes = new HashSet<TblAnnouncementType>();
            TblAppointments = new HashSet<TblAppointment>();
            TblAttachmentTypes = new HashSet<TblAttachmentType>();
            TblAttachments = new HashSet<TblAttachment>();
            TblBanners = new HashSet<TblBanner>();
            TblBlocks = new HashSet<TblBlock>();
            TblBuLanguages = new HashSet<TblBuLanguage>();
            TblCalendars = new HashSet<TblCalendar>();
            TblDepts = new HashSet<TblDept>();
            TblGoodsTypes = new HashSet<TblGoodsType>();
            TblMarquees = new HashSet<TblMarquee>();
            TblMeetTypes = new HashSet<TblMeetType>();
            TblMeetings = new HashSet<TblMeeting>();
            TblNodeMains = new HashSet<TblNodeMain>();
            TblPushNotifications = new HashSet<TblPushNotification>();
            TblResourceFronts = new HashSet<TblResourceFront>();
            TblResourceTypes = new HashSet<TblResourceType>();
            TblSaveConfirmOfResources = new HashSet<TblSaveConfirmOfResource>();
            TblUsers = new HashSet<TblUser>();
            TblVotes = new HashSet<TblVote>();
        }

        /// <summary>
        /// BUID
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// BU代碼
        /// </summary>
        public string? CBucode { get; set; }
        /// <summary>
        /// BU名稱
        /// </summary>
        public string? CName { get; set; }
        /// <summary>
        /// 說明
        /// </summary>
        public string? CDescription { get; set; }
        public DateTime? CCreateDt { get; set; }
        public int? CCreator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public int? CUpdator { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public int? CStatus { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string? CRemark { get; set; }
        /// <summary>
        /// 使用者上限
        /// </summary>
        public int? CUserLimit { get; set; }
        /// <summary>
        /// 是否支援
        /// </summary>
        public bool? CPlatformIsSupport { get; set; }
        /// <summary>
        /// 1 平台 2 商戶
        /// </summary>
        public int? CType { get; set; }
        public string? CTenantId { get; set; }

        public virtual ICollection<TblAddressbook> TblAddressbooks { get; set; }
        public virtual ICollection<TblAnnouncementType> TblAnnouncementTypes { get; set; }
        public virtual ICollection<TblAppointment> TblAppointments { get; set; }
        public virtual ICollection<TblAttachmentType> TblAttachmentTypes { get; set; }
        public virtual ICollection<TblAttachment> TblAttachments { get; set; }
        public virtual ICollection<TblBanner> TblBanners { get; set; }
        public virtual ICollection<TblBlock> TblBlocks { get; set; }
        public virtual ICollection<TblBuLanguage> TblBuLanguages { get; set; }
        public virtual ICollection<TblCalendar> TblCalendars { get; set; }
        public virtual ICollection<TblDept> TblDepts { get; set; }
        public virtual ICollection<TblGoodsType> TblGoodsTypes { get; set; }
        public virtual ICollection<TblMarquee> TblMarquees { get; set; }
        public virtual ICollection<TblMeetType> TblMeetTypes { get; set; }
        public virtual ICollection<TblMeeting> TblMeetings { get; set; }
        public virtual ICollection<TblNodeMain> TblNodeMains { get; set; }
        public virtual ICollection<TblPushNotification> TblPushNotifications { get; set; }
        public virtual ICollection<TblResourceFront> TblResourceFronts { get; set; }
        public virtual ICollection<TblResourceType> TblResourceTypes { get; set; }
        public virtual ICollection<TblSaveConfirmOfResource> TblSaveConfirmOfResources { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
        public virtual ICollection<TblVote> TblVotes { get; set; }
    }
}

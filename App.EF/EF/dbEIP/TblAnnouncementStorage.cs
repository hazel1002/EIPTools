using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAnnouncementStorage
    {
        public TblAnnouncementStorage()
        {
            TblAttachmentOfAnnStorages = new HashSet<TblAttachmentOfAnnStorage>();
            TblLinkOfAnnStorages = new HashSet<TblLinkOfAnnStorage>();
            TblPictureOfAnnStorages = new HashSet<TblPictureOfAnnStorage>();
            TblPushDepOfAnnStorages = new HashSet<TblPushDepOfAnnStorage>();
            TblVideoOfAnnStorages = new HashSet<TblVideoOfAnnStorage>();
        }

        public int CAnnouncementId { get; set; }
        public int CNodeMainId { get; set; }
        public string? CTitle { get; set; }
        public int? CAnnouncementTypeId { get; set; }
        public int? CStatus { get; set; }
        public DateTime? COnShelfDate { get; set; }
        public DateTime? COffShelfDate { get; set; }
        public bool CTop { get; set; }
        public DateTime? CCancelTop { get; set; }
        public bool CIsread { get; set; }
        public int? CIsSendPush { get; set; }
        public string? CUrl { get; set; }
        public string? CQoute { get; set; }
        public string? CContent { get; set; }
        public bool CIsAppear { get; set; }
        public bool CIsPush { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int? CAnnouncementStorageId { get; set; }

        public virtual TblAnnouncement? CAnnouncementStorage { get; set; }
        public virtual TblAnnouncementType? CAnnouncementType { get; set; }
        public virtual TblNodeMain CNodeMain { get; set; } = null!;
        public virtual ICollection<TblAttachmentOfAnnStorage> TblAttachmentOfAnnStorages { get; set; }
        public virtual ICollection<TblLinkOfAnnStorage> TblLinkOfAnnStorages { get; set; }
        public virtual ICollection<TblPictureOfAnnStorage> TblPictureOfAnnStorages { get; set; }
        public virtual ICollection<TblPushDepOfAnnStorage> TblPushDepOfAnnStorages { get; set; }
        public virtual ICollection<TblVideoOfAnnStorage> TblVideoOfAnnStorages { get; set; }
    }
}

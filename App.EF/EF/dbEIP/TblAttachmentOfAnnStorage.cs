using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAttachmentOfAnnStorage
    {
        public int CAnnouncementId { get; set; }
        public int? CAttachmentOfAnnType { get; set; }
        public int CAttachmentOfAnnId { get; set; }
        public string? CTitle { get; set; }
        public string? CFileName { get; set; }
        public string CAttachmentName { get; set; } = null!;
        public string? CDescription { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblAnnouncementStorage CAnnouncement { get; set; } = null!;
    }
}

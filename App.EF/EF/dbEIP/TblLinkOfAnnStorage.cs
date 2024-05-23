using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblLinkOfAnnStorage
    {
        public int CAnnouncementId { get; set; }
        public int CLinkOfAnnType { get; set; }
        public int CLinkOfAnnId { get; set; }
        public string CLinkUrl { get; set; } = null!;
        public string? CDescription { get; set; }
        public bool CIsNewPage { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblAnnouncementStorage CAnnouncement { get; set; } = null!;
    }
}

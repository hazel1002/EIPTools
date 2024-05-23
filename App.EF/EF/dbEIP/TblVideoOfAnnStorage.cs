using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblVideoOfAnnStorage
    {
        public int CAnnouncementId { get; set; }
        public int CVideoOfAnnId { get; set; }
        public string? CTitle { get; set; }
        public string? CDescription { get; set; }
        public string? CUrl { get; set; }
        public string CFileName { get; set; } = null!;
        public string CVideoName { get; set; } = null!;
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblAnnouncementStorage CAnnouncement { get; set; } = null!;
    }
}

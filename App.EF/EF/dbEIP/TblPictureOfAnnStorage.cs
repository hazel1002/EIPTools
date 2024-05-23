using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPictureOfAnnStorage
    {
        public int CAnnouncementId { get; set; }
        public int CPictureOfAnnId { get; set; }
        public string? CLinkUrl { get; set; }
        public string CPictureName { get; set; } = null!;
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

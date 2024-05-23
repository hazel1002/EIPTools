using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblSaveConfirmOfAnn
    {
        public int CAnnouncementId { get; set; }
        public int CConfirmOfAnnId { get; set; }
        public int CUserId { get; set; }
        public short CConfirmStatus { get; set; }
        public DateTime CConfirmTime { get; set; }
        public string? CRemark { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblAnnouncement CAnnouncement { get; set; } = null!;
        public virtual TblUser CUser { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblConfirmOfAnn
    {
        public int CConfirmOfAnnId { get; set; }
        public int CAnnouncementId { get; set; }
        public string CTitle { get; set; } = null!;
        public DateTime CTrialDate { get; set; }
        public DateTime COnShelfDate { get; set; }
        public DateTime COffShelfDate { get; set; }
        public short CConfirmStatus { get; set; }
        public int CUserId { get; set; }
        public DateTime CConfirmTime { get; set; }
        public string CRemark { get; set; } = null!;
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

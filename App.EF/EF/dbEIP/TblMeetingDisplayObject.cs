using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblMeetingDisplayObject
    {
        public int CId { get; set; }
        public int CmeetingId { get; set; }
        public int CUserId { get; set; }
        public string CName { get; set; } = null!;
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblMeeting Cmeeting { get; set; } = null!;
    }
}

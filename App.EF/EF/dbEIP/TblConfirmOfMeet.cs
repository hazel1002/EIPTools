using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblConfirmOfMeet
    {
        public int CConfirmOfMeetId { get; set; }
        public int CMeetTypeNameId { get; set; }
        public int CMeetNameId { get; set; }
        public DateTime CTrialDate { get; set; }
        public short CConfirmStatus { get; set; }
        public int CUserId { get; set; }
        public DateTime CConfirmTime { get; set; }
        public string? CRemark { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblMeet CMeetName { get; set; } = null!;
        public virtual TblMeetType CMeetTypeName { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAttachmentOfMeeting
    {
        public int Cid { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
        public string? CfileName { get; set; }
        public string? Cdescription { get; set; }
        public int CmeetingMinutesId { get; set; }
        public string? CattachmentName { get; set; }

        public virtual TblMeetingMinute CmeetingMinutes { get; set; } = null!;
    }
}

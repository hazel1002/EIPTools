using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblMeetingMinute
    {
        public TblMeetingMinute()
        {
            TblAttachmentOfMeetings = new HashSet<TblAttachmentOfMeeting>();
        }

        public int CmeetingMinutesId { get; set; }
        public string? CexternalAttendees { get; set; }
        public string Cmeeting { get; set; } = null!;
        public string? CInstruction { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
        public int CmeetingId { get; set; }

        public virtual TblMeeting CmeetingNavigation { get; set; } = null!;
        public virtual ICollection<TblAttachmentOfMeeting> TblAttachmentOfMeetings { get; set; }
    }
}

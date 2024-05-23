using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblMeeting
    {
        public TblMeeting()
        {
            TblInvitationofMeetings = new HashSet<TblInvitationofMeeting>();
            TblMeetingDisplayObjects = new HashSet<TblMeetingDisplayObject>();
            TblMeetingMinutes = new HashSet<TblMeetingMinute>();
            TblMeetingRooms = new HashSet<TblMeetingRoom>();
        }

        public int CmeetingId { get; set; }
        public string Cmeeting { get; set; } = null!;
        public int CNodeMainId { get; set; }
        public string? CexternalAttendees { get; set; }
        public int CBuId { get; set; }
        public DateTime CmeetingTimeStart { get; set; }
        public DateTime CmeetingTimeEnd { get; set; }
        public int CrecordId { get; set; }
        public int CmeetingBuilderId { get; set; }
        public short CConfirmStatus { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
        public short CDisplay { get; set; }
        public short CFrequencyType { get; set; }
        public short Csetting { get; set; }
        public short? CisGoogle { get; set; }
        public short? CisOutlook { get; set; }
        public short COrdinal { get; set; }
        public short CWeek { get; set; }
        public bool? CMonday { get; set; }
        public bool? CTuesday { get; set; }
        public bool? CWednesday { get; set; }
        public bool? CThursday { get; set; }
        public bool? CFriday { get; set; }
        public bool? CSaturday { get; set; }
        public bool? CSunday { get; set; }
        public int CEvery { get; set; }
        public short? CTimeUnit { get; set; }
        public int CReminder { get; set; }
        public DateTime? CCycleStart { get; set; }
        public DateTime? CCycleEnd { get; set; }
        public short? CFrequency { get; set; }
        public string? CAddress { get; set; }
        public string? CInstruction { get; set; }
        public int? CParentId { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual ICollection<TblInvitationofMeeting> TblInvitationofMeetings { get; set; }
        public virtual ICollection<TblMeetingDisplayObject> TblMeetingDisplayObjects { get; set; }
        public virtual ICollection<TblMeetingMinute> TblMeetingMinutes { get; set; }
        public virtual ICollection<TblMeetingRoom> TblMeetingRooms { get; set; }
    }
}

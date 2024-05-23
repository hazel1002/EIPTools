using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAppointment
    {
        public int CAppointmentId { get; set; }
        public int CBuId { get; set; }
        public string CTitle { get; set; } = null!;
        public DateTime CBorrowTimeStart { get; set; }
        public DateTime CBorrowTimeEnd { get; set; }
        public DateTime CCycleStart { get; set; }
        public DateTime CCycleEnd { get; set; }
        public short CFrequency { get; set; }
        public string? CAdress { get; set; }
        public string? CInstruction { get; set; }
        public short CDisplay { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
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
        public short CTimeUnit { get; set; }
        public int CReminder { get; set; }
        public int? CMeetNameId { get; set; }
        public int? CMeetTypeNameId { get; set; }
        public string? CMeetName { get; set; }
        public int? CResourceNameId { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
    }
}

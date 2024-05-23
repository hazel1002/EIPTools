using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblInvitationDeptOfCalendar
    {
        public int CCalendarId { get; set; }
        public int CId { get; set; }
        public int CDeptId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public short? CType { get; set; }
    }
}

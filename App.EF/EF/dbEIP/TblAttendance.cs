using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAttendance
    {
        public int CUserId { get; set; }
        public int CResourceAppointId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblResourceFront CResourceAppoint { get; set; } = null!;
    }
}

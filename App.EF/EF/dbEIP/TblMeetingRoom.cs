using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblMeetingRoom
    {
        public int CmeetingRoom { get; set; }
        public string ResourceName { get; set; } = null!;
        public int ResourceNameId { get; set; }
        public int CmeetingId { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }

        public virtual TblMeeting Cmeeting { get; set; } = null!;
    }
}

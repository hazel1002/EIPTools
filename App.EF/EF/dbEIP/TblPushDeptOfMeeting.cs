using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPushDeptOfMeeting
    {
        public int Id { get; set; }
        public int CmeetingId { get; set; }
        public int CDeptId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

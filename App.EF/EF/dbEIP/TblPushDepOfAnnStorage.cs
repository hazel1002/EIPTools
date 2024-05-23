using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPushDepOfAnnStorage
    {
        public int CAnnouncementId { get; set; }
        public int CPushDepOfAnnId { get; set; }
        public int CDeptId { get; set; }
        public DateTime? CCreateDt { get; set; }
        public int? CCreator { get; set; }
        public DateTime? CUpdatedDt { get; set; }
        public int? CUpdator { get; set; }
        public bool? CIsDelete { get; set; }

        public virtual TblAnnouncementStorage CAnnouncement { get; set; } = null!;
        public virtual TblDept CDept { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPushDepOfLink
    {
        public int CAttachmentId { get; set; }
        public int CDeptId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int CPushDepOfLink { get; set; }

        public virtual TblAttachment CAttachment { get; set; } = null!;
        public virtual TblDept CDept { get; set; } = null!;
    }
}

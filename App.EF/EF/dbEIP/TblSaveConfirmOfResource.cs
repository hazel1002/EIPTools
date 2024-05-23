using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblSaveConfirmOfResource
    {
        public int CConfirmOfResourceId { get; set; }
        public int CBuId { get; set; }
        public int CUserId { get; set; }
        public short CConfirmStatus { get; set; }
        public DateTime CConfirmTime { get; set; }
        public string? CRemark { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int? CResourceAppointId { get; set; }
        /// <summary>
        /// 1=會議室 2=資源
        /// </summary>
        public short CType { get; set; }
        public int? CCalendarType { get; set; }
        public int? CCalendarId { get; set; }
        public int? CmeetingId { get; set; }
        public int CBorrowListId { get; set; }

        public virtual TblResourceBorrowList CBorrowList { get; set; } = null!;
        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblResourceFront? CResourceAppoint { get; set; }
        public virtual TblUser CUser { get; set; } = null!;
    }
}

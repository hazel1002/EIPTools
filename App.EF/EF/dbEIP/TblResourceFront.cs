using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblResourceFront
    {
        public TblResourceFront()
        {
            TblAttendances = new HashSet<TblAttendance>();
            TblSaveConfirmOfResources = new HashSet<TblSaveConfirmOfResource>();
        }

        /// <summary>
        /// 資源預約ID
        /// </summary>
        public int CResourceAppointId { get; set; }
        public int? CBuId { get; set; }
        /// <summary>
        /// 部門ID
        /// </summary>
        public int CDeptId { get; set; }
        public int CNodeMainId { get; set; }
        /// <summary>
        /// 關鍵字
        /// </summary>
        public string? CKeyword { get; set; }
        /// <summary>
        /// 審核
        /// </summary>
        public short CConfirmStatus { get; set; }
        /// <summary>
        /// 借用時間起
        /// </summary>
        public DateTime? CBorrowTimeStart { get; set; }
        /// <summary>
        /// 使用說明
        /// </summary>
        public string? CResourceInstruction { get; set; }
        public string? CAddress { get; set; }
        /// <summary>
        /// 預約者
        /// </summary>
        public int CUserId { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string CTitle { get; set; } = null!;
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CCreateDt { get; set; }
        /// <summary>
        /// 建立者
        /// </summary>
        public int CCreator { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime CUpdatedDt { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public int CUpdator { get; set; }
        /// <summary>
        /// 是否刪除
        /// </summary>
        public bool CIsDelete { get; set; }
        /// <summary>
        /// 借用時間迄
        /// </summary>
        public DateTime? CBorrowTimeEnd { get; set; }
        /// <summary>
        /// 顯示設定
        /// </summary>
        public short Csetting { get; set; }
        /// <summary>
        /// 是否串Google
        /// </summary>
        public short? CisGoogle { get; set; }
        /// <summary>
        /// 是否串Outlook
        /// </summary>
        public short? CisOutlook { get; set; }
        public short? CFrequency { get; set; }
        public short CFrequencyType { get; set; }
        public short? COrdinal { get; set; }
        public short? CWeek { get; set; }
        public bool? CMonday { get; set; }
        public bool? CTuesday { get; set; }
        public bool? CWednesday { get; set; }
        public bool? CThursday { get; set; }
        public bool? CFriday { get; set; }
        public bool? CSaturday { get; set; }
        public bool? CSunday { get; set; }
        public int? CEvery { get; set; }
        public short? CTimeUnit { get; set; }
        public int CReminder { get; set; }
        public DateTime? CCycleStart { get; set; }
        public DateTime? CCycleEnd { get; set; }
        public int? CParentId { get; set; }

        public virtual TblBusinessUnit? CBu { get; set; }
        public virtual TblDept CDept { get; set; } = null!;
        public virtual TblUser CUser { get; set; } = null!;
        public virtual ICollection<TblAttendance> TblAttendances { get; set; }
        public virtual ICollection<TblSaveConfirmOfResource> TblSaveConfirmOfResources { get; set; }
    }
}

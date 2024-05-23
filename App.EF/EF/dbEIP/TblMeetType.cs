using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblMeetType
    {
        public TblMeetType()
        {
            TblConfirmOfMeets = new HashSet<TblConfirmOfMeet>();
            TblMeets = new HashSet<TblMeet>();
        }

        /// <summary>
        /// 公司流水號
        /// </summary>
        public int CBuId { get; set; }
        /// <summary>
        /// 會議室類別名稱ID
        /// </summary>
        public int CMeetTypeNameId { get; set; }
        /// <summary>
        /// 會議室類別名稱
        /// </summary>
        public string CMeetTypeName { get; set; } = null!;
        /// <summary>
        /// 狀態
        /// </summary>
        public short CStatus { get; set; }
        /// <summary>
        /// 使用對象
        /// </summary>
        public int CDeptId { get; set; }
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

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblDept CDept { get; set; } = null!;
        public virtual ICollection<TblConfirmOfMeet> TblConfirmOfMeets { get; set; }
        public virtual ICollection<TblMeet> TblMeets { get; set; }
    }
}

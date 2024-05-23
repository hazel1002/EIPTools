using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblMeet
    {
        public TblMeet()
        {
            TblConfirmOfMeets = new HashSet<TblConfirmOfMeet>();
        }

        /// <summary>
        /// 會議室類別名稱ID
        /// </summary>
        public int CMeetTypeNameId { get; set; }
        /// <summary>
        /// 會議室名稱ID
        /// </summary>
        public int CMeetNameId { get; set; }
        /// <summary>
        /// 會議室名稱
        /// </summary>
        public string CMeetName { get; set; } = null!;
        /// <summary>
        /// 狀態
        /// </summary>
        public short CStatus { get; set; }
        /// <summary>
        /// 最大容量
        /// </summary>
        public int CMaxCapacity { get; set; }
        /// <summary>
        /// 審核
        /// </summary>
        public bool CConfirm { get; set; }
        /// <summary>
        /// 會議室說明
        /// </summary>
        public string? CMeetIllustrate { get; set; }
        /// <summary>
        /// 使用對象
        /// </summary>
        public int CDeptId { get; set; }
        /// <summary>
        /// 圖片檔名
        /// </summary>
        public int? CPicture { get; set; }
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
        /// 圖片檔名
        /// </summary>
        public string? CPictureName { get; set; }

        public virtual TblDept CDept { get; set; } = null!;
        public virtual TblMeetType CMeetTypeName { get; set; } = null!;
        public virtual ICollection<TblConfirmOfMeet> TblConfirmOfMeets { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAttachment
    {
        public TblAttachment()
        {
            TblPushDepOfLinks = new HashSet<TblPushDepOfLink>();
        }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CBuId { get; set; }
        /// <summary>
        /// 標題ID
        /// </summary>
        public int CAttachmentId { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string CAttachment { get; set; } = null!;
        /// <summary>
        /// 英文標題ID
        /// </summary>
        public int? CEnglishAttachmentId { get; set; }
        /// <summary>
        /// URL
        /// </summary>
        public string? CUrl { get; set; }
        /// <summary>
        /// 英文URL
        /// </summary>
        public string? CEnglishUrl { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public short CStatus { get; set; }
        /// <summary>
        /// 連結顯示對象
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
        /// <summary>
        /// 英文標題
        /// </summary>
        public string? CEnglishAttachment { get; set; }
        public int CAttachmentTypeId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int COrder { get; set; }
        public bool? CIsSso { get; set; }

        public virtual TblAttachmentType CAttachmentType { get; set; } = null!;
        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblDept CDept { get; set; } = null!;
        public virtual ICollection<TblPushDepOfLink> TblPushDepOfLinks { get; set; }
    }
}

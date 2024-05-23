using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAttachmentType
    {
        public TblAttachmentType()
        {
            TblAttachments = new HashSet<TblAttachment>();
        }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CBuId { get; set; }
        /// <summary>
        /// 分類名稱ID
        /// </summary>
        public int CAttachmentTypeId { get; set; }
        public int CNodeMainId { get; set; }
        /// <summary>
        /// 分類母語名稱
        /// </summary>
        public string? CAttachmentType { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int COrder { get; set; }
        /// <summary>
        /// 分類英文名稱
        /// </summary>
        public string? CEnglishAttachmentType { get; set; }
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

        public virtual TblBusinessUnit? CBu { get; set; }
        public virtual TblNodeMain CNodeMain { get; set; } = null!;
        public virtual ICollection<TblAttachment> TblAttachments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAttachmentOfAnn
    {
        /// <summary>
        /// 公告ID
        /// </summary>
        public int CAnnouncementId { get; set; }
        /// <summary>
        /// 附件類型
        /// </summary>
        public int? CAttachmentOfAnnType { get; set; }
        /// <summary>
        /// 附件類型Id
        /// </summary>
        public int CAttachmentOfAnnId { get; set; }
        /// <summary>
        /// 附件標題
        /// </summary>
        public string? CTitle { get; set; }
        /// <summary>
        /// 檔名
        /// </summary>
        public string? CFileName { get; set; }
        /// <summary>
        /// 附件名稱
        /// </summary>
        public string CAttachmentName { get; set; } = null!;
        /// <summary>
        /// 描述
        /// </summary>
        public string? CDescription { get; set; }
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

        public virtual TblAnnouncement CAnnouncement { get; set; } = null!;
    }
}

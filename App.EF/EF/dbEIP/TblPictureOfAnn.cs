using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPictureOfAnn
    {
        /// <summary>
        /// 公告Id
        /// </summary>
        public int CAnnouncementId { get; set; }
        /// <summary>
        /// 圖片ID
        /// </summary>
        public int CPictureOfAnnId { get; set; }
        /// <summary>
        /// 連結
        /// </summary>
        public string? CLinkUrl { get; set; }
        /// <summary>
        /// 圖片名稱
        /// </summary>
        public string CPictureName { get; set; } = null!;
        /// <summary>
        /// 圖片描述
        /// </summary>
        public string? CDescription { get; set; }
        /// <summary>
        /// 在新視窗開啟
        /// </summary>
        public bool CIsNewPage { get; set; }
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

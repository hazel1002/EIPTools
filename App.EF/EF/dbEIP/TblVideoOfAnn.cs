using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblVideoOfAnn
    {
        /// <summary>
        /// 公告Id
        /// </summary>
        public int CAnnouncementId { get; set; }
        /// <summary>
        /// 影片ID
        /// </summary>
        public int CVideoOfAnnId { get; set; }
        /// <summary>
        /// 影片標題
        /// </summary>
        public string? CTitle { get; set; }
        /// <summary>
        /// 影片描述
        /// </summary>
        public string? CDescription { get; set; }
        /// <summary>
        /// 影片網址
        /// </summary>
        public string? CUrl { get; set; }
        /// <summary>
        /// 檔案名稱
        /// </summary>
        public string CFileName { get; set; } = null!;
        /// <summary>
        /// 影片檔名
        /// </summary>
        public string CVideoName { get; set; } = null!;
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

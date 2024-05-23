using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblLinkOfAnn
    {
        /// <summary>
        /// 公告Id
        /// </summary>
        public int CAnnouncementId { get; set; }
        /// <summary>
        /// 附件類型，1.圖片、2.附件、3.影片
        /// </summary>
        public int CLinkOfAnnType { get; set; }
        /// <summary>
        /// 連結Id
        /// </summary>
        public int CLinkOfAnnId { get; set; }
        /// <summary>
        /// 連結位置
        /// </summary>
        public string CLinkUrl { get; set; } = null!;
        /// <summary>
        /// 描述
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

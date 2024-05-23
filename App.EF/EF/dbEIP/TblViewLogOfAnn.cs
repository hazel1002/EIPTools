using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblViewLogOfAnn
    {
        /// <summary>
        /// 公告瀏覽紀錄Id
        /// </summary>
        public int CViewLogOfAnnId { get; set; }
        /// <summary>
        /// 公告Id
        /// </summary>
        public int CAnnouncementId { get; set; }
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

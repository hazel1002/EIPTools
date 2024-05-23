using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAnnouncementType
    {
        public TblAnnouncementType()
        {
            TblAnnouncementStorages = new HashSet<TblAnnouncementStorage>();
            TblAnnouncements = new HashSet<TblAnnouncement>();
        }

        /// <summary>
        /// 公司流水號
        /// </summary>
        public int CBuId { get; set; }
        /// <summary>
        /// 類別編號
        /// </summary>
        public int CAnnouncementTypeId { get; set; }
        /// <summary>
        /// 類別名稱
        /// </summary>
        public string CAnnouncementTypeName { get; set; } = null!;
        public int CStatus { get; set; }
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
        public virtual ICollection<TblAnnouncementStorage> TblAnnouncementStorages { get; set; }
        public virtual ICollection<TblAnnouncement> TblAnnouncements { get; set; }
    }
}

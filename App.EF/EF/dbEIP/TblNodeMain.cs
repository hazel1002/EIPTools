using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblNodeMain
    {
        public TblNodeMain()
        {
            TblAnnouncementStorages = new HashSet<TblAnnouncementStorage>();
            TblAnnouncements = new HashSet<TblAnnouncement>();
            TblAttachmentTypes = new HashSet<TblAttachmentType>();
            TblBlocks = new HashSet<TblBlock>();
            TblDisplayObjects = new HashSet<TblDisplayObject>();
            TblFilterOfNodes = new HashSet<TblFilterOfNode>();
            TblMarquees = new HashSet<TblMarquee>();
            TblModelNames = new HashSet<TblModelName>();
            TblNodeNames = new HashSet<TblNodeName>();
            TblVotes = new HashSet<TblVote>();
        }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CBuId { get; set; }
        /// <summary>
        /// 節點主表Id
        /// </summary>
        public int CNodeMainId { get; set; }
        /// <summary>
        /// 版型Id
        /// </summary>
        public int CTemplateId { get; set; }
        /// <summary>
        /// 1.單/2多篇
        /// </summary>
        public short CPages { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public short CStatus { get; set; }
        /// <summary>
        /// 文章是否需要審核
        /// </summary>
        public bool CIsComfirm { get; set; }
        /// <summary>
        /// 是否顯示在選單
        /// </summary>
        public bool CIsMainfest { get; set; }
        /// <summary>
        /// 父結點Id
        /// </summary>
        public int CParentNodeId { get; set; }
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
        public string? CUrl { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual ICollection<TblAnnouncementStorage> TblAnnouncementStorages { get; set; }
        public virtual ICollection<TblAnnouncement> TblAnnouncements { get; set; }
        public virtual ICollection<TblAttachmentType> TblAttachmentTypes { get; set; }
        public virtual ICollection<TblBlock> TblBlocks { get; set; }
        public virtual ICollection<TblDisplayObject> TblDisplayObjects { get; set; }
        public virtual ICollection<TblFilterOfNode> TblFilterOfNodes { get; set; }
        public virtual ICollection<TblMarquee> TblMarquees { get; set; }
        public virtual ICollection<TblModelName> TblModelNames { get; set; }
        public virtual ICollection<TblNodeName> TblNodeNames { get; set; }
        public virtual ICollection<TblVote> TblVotes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblResourceKeeper
    {
        /// <summary>
        /// 資源類別名稱ID
        /// </summary>
        public int? CResourceTypeNameId { get; set; }
        /// <summary>
        /// 資源名稱
        /// </summary>
        public int CResourceNameId { get; set; }
        /// <summary>
        /// 使用者ID
        /// </summary>
        public int CUserId { get; set; }
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

        public virtual TblResource CResourceName { get; set; } = null!;
        public virtual TblResourceType? CResourceTypeName { get; set; }
    }
}

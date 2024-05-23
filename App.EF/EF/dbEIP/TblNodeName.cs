using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblNodeName
    {
        /// <summary>
        /// 節點主表Id
        /// </summary>
        public int CNodeMainId { get; set; }
        /// <summary>
        /// 語系Id
        /// </summary>
        public int CLanguageId { get; set; }
        /// <summary>
        /// 節點名稱
        /// </summary>
        public string CNodeName { get; set; } = null!;
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

        public virtual TblLanguage CLanguage { get; set; } = null!;
        public virtual TblNodeMain CNodeMain { get; set; } = null!;
    }
}

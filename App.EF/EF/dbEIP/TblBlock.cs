using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblBlock
    {
        /// <summary>
        /// 公司流水號
        /// </summary>
        public int CBuId { get; set; }
        /// <summary>
        /// 首頁區塊Id
        /// </summary>
        public int CBlockId { get; set; }
        /// <summary>
        /// 區塊大小
        /// </summary>
        public short CBlockSize { get; set; }
        /// <summary>
        /// 節點主表Id
        /// </summary>
        public int CNodeMainId { get; set; }
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
        public virtual TblNodeMain CNodeMain { get; set; } = null!;
    }
}

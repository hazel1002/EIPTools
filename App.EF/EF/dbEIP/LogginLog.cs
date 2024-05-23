using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class LogginLog
    {
        /// <summary>
        /// 遞進號
        /// </summary>
        public int SeqNo { get; set; }
        /// <summary>
        /// 帳號
        /// </summary>
        public string? AccountId { get; set; }
        /// <summary>
        /// 0.登出 1.登入
        /// </summary>
        public byte? Type { get; set; }
        /// <summary>
        /// 刪除註記
        /// </summary>
        public bool? IsDelete { get; set; }
        /// <summary>
        /// 建立日期
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 建立人員
        /// </summary>
        public string? Creator { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// 修改人員
        /// </summary>
        public string? Modifier { get; set; }
    }
}

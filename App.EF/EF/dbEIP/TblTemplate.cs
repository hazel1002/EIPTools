using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblTemplate
    {
        public int CId { get; set; }
        /// <summary>
        /// 版型Id
        /// </summary>
        public int CTemplateId { get; set; }
        /// <summary>
        /// 版型名稱
        /// </summary>
        public string CTemplateName { get; set; } = null!;
        public int CLanguageId { get; set; }
        /// <summary>
        /// 新增時間
        /// </summary>
        public DateTime CCreateDt { get; set; }
        /// <summary>
        /// 新增者
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
        public string? CPageUrl { get; set; }
        public string? CIcon { get; set; }
    }
}

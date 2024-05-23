using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    /// <summary>
    /// 使用者
    /// </summary>
    public partial class TblUser
    {
        public TblUser()
        {
            TblPushNotifications = new HashSet<TblPushNotification>();
            TblResourceFronts = new HashSet<TblResourceFront>();
            TblSaveConfirmOfAnns = new HashSet<TblSaveConfirmOfAnn>();
            TblSaveConfirmOfResources = new HashSet<TblSaveConfirmOfResource>();
        }

        /// <summary>
        /// 使用者編號
        /// </summary>
        public int CUserId { get; set; }
        /// <summary>
        /// 使用者名稱
        /// </summary>
        public string CUserName { get; set; } = null!;
        /// <summary>
        /// cAccount、cAccount2都不可重複
        /// </summary>
        public string CAccount { get; set; } = null!;
        /// <summary>
        /// 密碼
        /// </summary>
        public string? CPassword { get; set; }
        /// <summary>
        /// 信箱
        /// </summary>
        public string CMail { get; set; } = null!;
        /// <summary>
        /// 是否為單位最高權限(0:否, 1:是)
        /// </summary>
        public bool? CIsDeptManager { get; set; }
        /// <summary>
        /// 緩刪除(0:未刪除, 1:已刪除)
        /// </summary>
        public bool CIsDelete { get; set; }
        /// <summary>
        /// 建立者
        /// </summary>
        public int CCreator { get; set; }
        /// <summary>
        /// 建立日期時間
        /// </summary>
        public DateTime CCreateDt { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public int CUpdator { get; set; }
        /// <summary>
        /// 更新日期時間
        /// </summary>
        public DateTime CUpdateDt { get; set; }
        /// <summary>
        /// 狀態 0:停用 1:啟用(前台狀態)
        /// </summary>
        public int CStatus { get; set; }
        /// <summary>
        /// 狀態 0:停用 1:啟用(後臺狀態)
        /// </summary>
        public int CAdminStatus { get; set; }
        /// <summary>
        /// 代理單位
        /// </summary>
        public string? CAgentUnit { get; set; }
        /// <summary>
        /// BU
        /// </summary>
        public int CBuId { get; set; }
        /// <summary>
        /// 語系
        /// </summary>
        public int CLanguageId { get; set; }
        /// <summary>
        /// 部門流水號
        /// </summary>
        public int CDeptId { get; set; }
        /// <summary>
        /// 職稱
        /// </summary>
        public string? CJobTitle { get; set; }
        /// <summary>
        /// 是否為主要職稱(0:否, 1:是)
        /// </summary>
        public bool? CIsMainTitle { get; set; }
        /// <summary>
        /// 是否為前台
        /// </summary>
        public bool CIsFront { get; set; }
        public bool? CIsChangePassword { get; set; }
        /// <summary>
        /// 頭貼
        /// </summary>
        public string? CPicture { get; set; }
        public string? CGoogleId { get; set; }
        public string? COutlookId { get; set; }
        public string? CSessionId { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblDept CDept { get; set; } = null!;
        public virtual TblLanguage CLanguage { get; set; } = null!;
        public virtual ICollection<TblPushNotification> TblPushNotifications { get; set; }
        public virtual ICollection<TblResourceFront> TblResourceFronts { get; set; }
        public virtual ICollection<TblSaveConfirmOfAnn> TblSaveConfirmOfAnns { get; set; }
        public virtual ICollection<TblSaveConfirmOfResource> TblSaveConfirmOfResources { get; set; }
    }
}

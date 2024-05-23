using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPushNotification
    {
        public int CBuId { get; set; }
        public int CpushNotification { get; set; }
        public int CUserId { get; set; }
        public int Ctype { get; set; }
        public int CtemplateId { get; set; }
        /// <summary>
        /// 資料源標題ID
        /// </summary>
        public int CspaceId { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
        public string Caccount { get; set; } = null!;
        public bool CisRead { get; set; }
        public int CpushTakerId { get; set; }
        public short? CcalendarType { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblUser CUser { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblReminder
    {
        public int CBuId { get; set; }
        public int Cid { get; set; }
        public int CUserId { get; set; }
        public int Ctype { get; set; }
        public int CtemplateId { get; set; }
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
        public bool? CisRemind { get; set; }
        public DateTime? Ctime { get; set; }
    }
}

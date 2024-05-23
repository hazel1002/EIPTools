using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPushDepOfVote
    {
        public int CvoteId { get; set; }
        public int CpushDepOfVoteId { get; set; }
        public int CdeptId { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }

        public virtual TblDept Cdept { get; set; } = null!;
        public virtual TblVote Cvote { get; set; } = null!;
    }
}

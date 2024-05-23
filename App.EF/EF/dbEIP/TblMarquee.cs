using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblMarquee
    {
        public int CBuId { get; set; }
        public int CmarqueeId { get; set; }
        public string Ctitle { get; set; } = null!;
        public int CtemplateId { get; set; }
        public string? Ctemplate { get; set; }
        public string Cspace { get; set; } = null!;
        public int CspaceId { get; set; }
        public string Curl { get; set; } = null!;
        public short Cstatus { get; set; }
        public DateTime ConShelfTime { get; set; }
        public int Corder { get; set; }
        public DateTime CoffShelfTime { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
        public int CnodeMainId { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblNodeMain CnodeMain { get; set; } = null!;
    }
}

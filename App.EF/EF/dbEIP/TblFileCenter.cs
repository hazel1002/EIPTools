using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblFileCenter
    {
        public int CfolderId { get; set; }
        public string CfolderName { get; set; } = null!;
        public int CbuId { get; set; }
        public int Corder { get; set; }
        public int CparentFolderId { get; set; }
        public short Cstatus { get; set; }
        public int CnodeMainId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

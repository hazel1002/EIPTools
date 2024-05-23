using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblFilterOfNode
    {
        public int FilterOfNodeId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int CResourceNameId { get; set; }
        public string CResourceName { get; set; } = null!;
        public int CNodeMainId { get; set; }

        public virtual TblNodeMain CNodeMain { get; set; } = null!;
    }
}

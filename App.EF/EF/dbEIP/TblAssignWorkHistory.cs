using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAssignWorkHistory
    {
        public int TblAssignWorkHistoryId { get; set; }
        public int CuserId { get; set; }
        public int Cprogress { get; set; }
        public string? Cillustration { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
        public int CassignId { get; set; }

        public virtual TblAssignWork Cassign { get; set; } = null!;
    }
}

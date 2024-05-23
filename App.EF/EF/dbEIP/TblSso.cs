using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblSso
    {
        public int Id { get; set; }
        public int CUserId { get; set; }
        public string CToken { get; set; } = null!;
        public DateTime CDueDt { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
    }
}

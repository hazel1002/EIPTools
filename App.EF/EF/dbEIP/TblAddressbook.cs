using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAddressbook
    {
        public int CBuId { get; set; }
        public string CuserName { get; set; } = null!;
        public int CNodeMainId { get; set; }
        public string Caccount { get; set; } = null!;
        public int CaddressBookId { get; set; }
        public string CdeptName { get; set; } = null!;
        public string CjobTitle { get; set; } = null!;
        public string? Cemail { get; set; }
        public string? CcellPhone { get; set; }
        public string? CcompanyPhone { get; set; }
        public string? Cextension { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
        public short Cgender { get; set; }
        public string? Cremark1 { get; set; }
        public string? Cremark2 { get; set; }
        public string? Cremark3 { get; set; }
        public string? Cremark4 { get; set; }
        public string? Cremark5 { get; set; }
        public string? Cremark6 { get; set; }
        public string? Cremark7 { get; set; }
        public string? Cremark8 { get; set; }
        public string? Cremark9 { get; set; }
        public string? Cremark10 { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
    }
}

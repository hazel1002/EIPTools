using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblSelection
    {
        public int CselectionId { get; set; }
        public int CanswerId { get; set; }
        public bool CisCheck { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public int Cid { get; set; }

        public virtual TblAnswer Canswer { get; set; } = null!;
        public virtual TblQuestion Cselection { get; set; } = null!;
    }
}

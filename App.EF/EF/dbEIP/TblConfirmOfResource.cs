using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblConfirmOfResource
    {
        public int CConfirmOfResourceId { get; set; }
        public int CResourceTypeNameId { get; set; }
        public int CResourceNameId { get; set; }
        public DateTime CTrialDate { get; set; }
        public short CConfirmStatus { get; set; }
        public int CUserId { get; set; }
        public DateTime CConfirmTime { get; set; }
        public string? CRemark { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

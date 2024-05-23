using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAssignWorkUpload
    {
        public int TblAssignWorkUploadId { get; set; }
        public int CassignId { get; set; }
        public string? CfileName { get; set; }
        public string? CattachmentName { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }

        public virtual TblAssignWork Cassign { get; set; } = null!;
    }
}

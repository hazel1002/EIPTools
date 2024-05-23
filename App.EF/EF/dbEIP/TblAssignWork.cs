using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAssignWork
    {
        public TblAssignWork()
        {
            TblAssignWorkHistories = new HashSet<TblAssignWorkHistory>();
            TblAssignWorkUploads = new HashSet<TblAssignWorkUpload>();
        }

        public int CassignId { get; set; }
        public int Csponsor { get; set; }
        public int? CmeetingId { get; set; }
        public int? Buid { get; set; }
        public int Cexecutor { get; set; }
        public string CworkMatters { get; set; } = null!;
        public DateTime CstartTime { get; set; }
        public DateTime? CdueTime { get; set; }
        public int Cpriority { get; set; }
        public int Cprogress { get; set; }
        public string? Cillustration { get; set; }
        public string? Ccontent { get; set; }
        public bool CisRedmine { get; set; }
        public int? CprojectId { get; set; }
        public string? Cproject { get; set; }
        public string? CoverviewofProject { get; set; }
        public string? CprojectCode { get; set; }
        public int? CversionId { get; set; }
        public string? Cversion { get; set; }
        public string? CoverviewofVersion { get; set; }
        public short Cstatus { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }

        public virtual ICollection<TblAssignWorkHistory> TblAssignWorkHistories { get; set; }
        public virtual ICollection<TblAssignWorkUpload> TblAssignWorkUploads { get; set; }
    }
}

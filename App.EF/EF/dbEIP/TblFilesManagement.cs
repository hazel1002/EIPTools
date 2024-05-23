using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblFilesManagement
    {
        public int CfileId { get; set; }
        public string CfileName { get; set; } = null!;
        public int Corder { get; set; }
        public int CparentFolderId { get; set; }
        public string CfileUrl { get; set; } = null!;
        public long Csize { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

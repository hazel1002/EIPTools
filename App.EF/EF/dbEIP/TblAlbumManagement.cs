using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAlbumManagement
    {
        public int CpictureId { get; set; }
        public int CalbumId { get; set; }
        public bool Cpicture { get; set; }
        public string CfileName { get; set; } = null!;
        public string Cname { get; set; } = null!;
        public int Corder { get; set; }
        public bool CisCover { get; set; }
        public string CfileSize { get; set; } = null!;
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public string? Cdescription { get; set; }
        public string? Curl { get; set; }
    }
}

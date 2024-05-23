using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAlbum
    {
        public int CalbumId { get; set; }
        public int CBuId { get; set; }
        public int CNodeMainId { get; set; }
        public string Calbum { get; set; } = null!;
        public int Corder { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

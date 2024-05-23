using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblUploadPicture
    {
        public int Id { get; set; }
        public int CalbumId { get; set; }
        public string CfileName { get; set; } = null!;
        public string? Cdescription { get; set; }
        public bool? CisCover { get; set; }
    }
}

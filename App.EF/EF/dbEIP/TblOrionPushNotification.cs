using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblOrionPushNotification
    {
        public int Id { get; set; }
        public int CUserId { get; set; }
        public int CType { get; set; }
        public int CSenderUserId { get; set; }
        public string CImuserId { get; set; } = null!;
        public string? CGuestUrl { get; set; }
        public string? CContent { get; set; }
        public DateTime? CCreateDt { get; set; }
    }
}

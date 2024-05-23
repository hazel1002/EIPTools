using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblUserOnGroup
    {
        public int CUserId { get; set; }
        public int CUserGroupId { get; set; }
        public bool? CStatus { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblPushDeptOfGood
    {
        public int Id { get; set; }
        public int CGoodsId { get; set; }
        public int CDeptId { get; set; }
        public string CDeptName { get; set; } = null!;
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
    }
}

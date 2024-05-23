using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblResourceBorrowList
    {
        public TblResourceBorrowList()
        {
            TblSaveConfirmOfResources = new HashSet<TblSaveConfirmOfResource>();
        }

        public int CResourceNameId { get; set; }
        public int CResourceAppointId { get; set; }
        public string CResourceName { get; set; } = null!;
        public int CBorrowListId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }
        public short CTypeId { get; set; }

        public virtual ICollection<TblSaveConfirmOfResource> TblSaveConfirmOfResources { get; set; }
    }
}

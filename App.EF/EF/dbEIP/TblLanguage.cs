using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblLanguage
    {
        public TblLanguage()
        {
            TblBuLanguages = new HashSet<TblBuLanguage>();
            TblModelNames = new HashSet<TblModelName>();
            TblNodeNames = new HashSet<TblNodeName>();
            TblUsers = new HashSet<TblUser>();
        }

        public int CLanguageId { get; set; }
        public string CLanguageName { get; set; } = null!;
        public string CLanguageCode { get; set; } = null!;
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual ICollection<TblBuLanguage> TblBuLanguages { get; set; }
        public virtual ICollection<TblModelName> TblModelNames { get; set; }
        public virtual ICollection<TblNodeName> TblNodeNames { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblQuestion
    {
        public TblQuestion()
        {
            TblSelections = new HashSet<TblSelection>();
        }

        public int CquestionId { get; set; }
        public string Cselection { get; set; } = null!;
        public int CselectionId { get; set; }
        public short CvoteTypeId { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }

        public virtual TblVoteType Cquestion { get; set; } = null!;
        public virtual ICollection<TblSelection> TblSelections { get; set; }
    }
}

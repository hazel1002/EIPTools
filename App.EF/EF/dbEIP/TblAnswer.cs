using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblAnswer
    {
        public TblAnswer()
        {
            TblSelections = new HashSet<TblSelection>();
        }

        public int CanswerId { get; set; }
        public int CquestionId { get; set; }
        public int CvoteFrontId { get; set; }
        public string? Canswer { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblVoteType Cquestion { get; set; } = null!;
        public virtual TblVoteFront CvoteFront { get; set; } = null!;
        public virtual ICollection<TblSelection> TblSelections { get; set; }
    }
}

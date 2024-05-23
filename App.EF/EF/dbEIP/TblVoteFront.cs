using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblVoteFront
    {
        public TblVoteFront()
        {
            TblAnswers = new HashSet<TblAnswer>();
        }

        public int CvoteFrontId { get; set; }
        public int CvoteId { get; set; }
        public DateTime CCreateDt { get; set; }
        public int CCreator { get; set; }
        public DateTime CUpdatedDt { get; set; }
        public int CUpdator { get; set; }
        public bool CIsDelete { get; set; }

        public virtual TblVote Cvote { get; set; } = null!;
        public virtual ICollection<TblAnswer> TblAnswers { get; set; }
    }
}

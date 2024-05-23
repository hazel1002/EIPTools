using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblVoteType
    {
        public TblVoteType()
        {
            TblAnswers = new HashSet<TblAnswer>();
            TblQuestions = new HashSet<TblQuestion>();
        }

        public int CvoteId { get; set; }
        public int CquestionId { get; set; }
        public short CvoteTypeId { get; set; }
        public string Cquestion { get; set; } = null!;
        public bool Crequired { get; set; }
        public string? Cremark { get; set; }
        public string? CuploadPic { get; set; }
        public string? CuploadVideo { get; set; }
        public DateTime CcreateDt { get; set; }
        public int Ccreator { get; set; }
        public DateTime CupdatedDt { get; set; }
        public int Cupdator { get; set; }
        public bool CisDelete { get; set; }
        public int? Climit { get; set; }
        public int? Corder { get; set; }

        public virtual TblVote Cvote { get; set; } = null!;
        public virtual ICollection<TblAnswer> TblAnswers { get; set; }
        public virtual ICollection<TblQuestion> TblQuestions { get; set; }
    }
}

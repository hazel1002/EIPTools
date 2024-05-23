using System;
using System.Collections.Generic;

namespace App.EF.EF.dbEIP
{
    public partial class TblVote
    {
        public TblVote()
        {
            TblPushDepOfVotes = new HashSet<TblPushDepOfVote>();
            TblVoteFronts = new HashSet<TblVoteFront>();
            TblVoteTypes = new HashSet<TblVoteType>();
        }

        /// <summary>
        /// 公司流水號
        /// </summary>
        public int CBuId { get; set; }
        public int CNodeMainId { get; set; }
        /// <summary>
        /// 投票問卷ID
        /// </summary>
        public int CvoteId { get; set; }
        /// <summary>
        /// 類別ID
        /// </summary>
        public short CtypeId { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public short Cstatus { get; set; }
        /// <summary>
        /// 是否推播
        /// </summary>
        public short CisPush { get; set; }
        /// <summary>
        /// 發布單位
        /// </summary>
        public int CdeptId { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string Ctitle { get; set; } = null!;
        /// <summary>
        /// 上架時間
        /// </summary>
        public DateTime ConShelfDate { get; set; }
        /// <summary>
        /// 下架時間
        /// </summary>
        public DateTime CoffShelfDate { get; set; }
        /// <summary>
        /// 回覆數
        /// </summary>
        public int Cresponse { get; set; }
        /// <summary>
        /// 造訪數
        /// </summary>
        public int Cvisit { get; set; }
        /// <summary>
        /// 友善網址
        /// </summary>
        public string? Clinks { get; set; }
        /// <summary>
        /// 是否呈現前台
        /// </summary>
        public bool CisAppear { get; set; }
        /// <summary>
        /// 投票問卷內容
        /// </summary>
        public string Ccontent { get; set; } = null!;
        /// <summary>
        /// URL
        /// </summary>
        public string Curl { get; set; } = null!;
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CcreateDt { get; set; }
        /// <summary>
        /// 建立者
        /// </summary>
        public int Ccreator { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime CupdatedDt { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public int Cupdator { get; set; }
        /// <summary>
        /// 是否刪除
        /// </summary>
        public bool CisDelete { get; set; }
        /// <summary>
        /// 置頂
        /// </summary>
        public bool CisTop { get; set; }
        /// <summary>
        /// 匿名
        /// </summary>
        public bool CisAnonymous { get; set; }
        public short? CisSingleChoice { get; set; }
        public int? CchoiceLimit { get; set; }

        public virtual TblBusinessUnit CBu { get; set; } = null!;
        public virtual TblNodeMain CNodeMain { get; set; } = null!;
        public virtual ICollection<TblPushDepOfVote> TblPushDepOfVotes { get; set; }
        public virtual ICollection<TblVoteFront> TblVoteFronts { get; set; }
        public virtual ICollection<TblVoteType> TblVoteTypes { get; set; }
    }
}

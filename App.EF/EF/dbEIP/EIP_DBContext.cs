using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.EF.EF.dbEIP
{
    public partial class EIP_DBContext : DbContext
    {
        public EIP_DBContext()
        {
        }

        public EIP_DBContext(DbContextOptions<EIP_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LogginLog> LogginLogs { get; set; } = null!;
        public virtual DbSet<StakeholderView> StakeholderViews { get; set; } = null!;
        public virtual DbSet<TblAccessLog> TblAccessLogs { get; set; } = null!;
        public virtual DbSet<TblAddressbook> TblAddressbooks { get; set; } = null!;
        public virtual DbSet<TblAlbum> TblAlbums { get; set; } = null!;
        public virtual DbSet<TblAlbumManagement> TblAlbumManagements { get; set; } = null!;
        public virtual DbSet<TblAnnouncement> TblAnnouncements { get; set; } = null!;
        public virtual DbSet<TblAnnouncementStorage> TblAnnouncementStorages { get; set; } = null!;
        public virtual DbSet<TblAnnouncementType> TblAnnouncementTypes { get; set; } = null!;
        public virtual DbSet<TblAnswer> TblAnswers { get; set; } = null!;
        public virtual DbSet<TblAppointment> TblAppointments { get; set; } = null!;
        public virtual DbSet<TblAssignWork> TblAssignWorks { get; set; } = null!;
        public virtual DbSet<TblAssignWorkHistory> TblAssignWorkHistories { get; set; } = null!;
        public virtual DbSet<TblAssignWorkUpload> TblAssignWorkUploads { get; set; } = null!;
        public virtual DbSet<TblAttachment> TblAttachments { get; set; } = null!;
        public virtual DbSet<TblAttachmentOfAnn> TblAttachmentOfAnns { get; set; } = null!;
        public virtual DbSet<TblAttachmentOfAnnStorage> TblAttachmentOfAnnStorages { get; set; } = null!;
        public virtual DbSet<TblAttachmentOfMeeting> TblAttachmentOfMeetings { get; set; } = null!;
        public virtual DbSet<TblAttachmentType> TblAttachmentTypes { get; set; } = null!;
        public virtual DbSet<TblAttendance> TblAttendances { get; set; } = null!;
        public virtual DbSet<TblBanner> TblBanners { get; set; } = null!;
        public virtual DbSet<TblBlock> TblBlocks { get; set; } = null!;
        public virtual DbSet<TblBuLanguage> TblBuLanguages { get; set; } = null!;
        public virtual DbSet<TblBusinessUnit> TblBusinessUnits { get; set; } = null!;
        public virtual DbSet<TblBusinessUnitBak> TblBusinessUnitBaks { get; set; } = null!;
        public virtual DbSet<TblCalendar> TblCalendars { get; set; } = null!;
        public virtual DbSet<TblConfirmOfAnn> TblConfirmOfAnns { get; set; } = null!;
        public virtual DbSet<TblConfirmOfMeet> TblConfirmOfMeets { get; set; } = null!;
        public virtual DbSet<TblConfirmOfResource> TblConfirmOfResources { get; set; } = null!;
        public virtual DbSet<TblDept> TblDepts { get; set; } = null!;
        public virtual DbSet<TblDisplayObject> TblDisplayObjects { get; set; } = null!;
        public virtual DbSet<TblFileCenter> TblFileCenters { get; set; } = null!;
        public virtual DbSet<TblFilesManagement> TblFilesManagements { get; set; } = null!;
        public virtual DbSet<TblFilterOfNode> TblFilterOfNodes { get; set; } = null!;
        public virtual DbSet<TblFunction> TblFunctions { get; set; } = null!;
        public virtual DbSet<TblFunctionOnBu> TblFunctionOnBus { get; set; } = null!;
        public virtual DbSet<TblFunctionOnGroup> TblFunctionOnGroups { get; set; } = null!;
        public virtual DbSet<TblGood> TblGoods { get; set; } = null!;
        public virtual DbSet<TblGoodsBorrowList> TblGoodsBorrowLists { get; set; } = null!;
        public virtual DbSet<TblGoodsFront> TblGoodsFronts { get; set; } = null!;
        public virtual DbSet<TblGoodsKeeper> TblGoodsKeepers { get; set; } = null!;
        public virtual DbSet<TblGoodsType> TblGoodsTypes { get; set; } = null!;
        public virtual DbSet<TblGoodsTypeUser> TblGoodsTypeUsers { get; set; } = null!;
        public virtual DbSet<TblGoodsUser> TblGoodsUsers { get; set; } = null!;
        public virtual DbSet<TblInvitationDeptOfCalendar> TblInvitationDeptOfCalendars { get; set; } = null!;
        public virtual DbSet<TblInvitationDeptOfMeeting> TblInvitationDeptOfMeetings { get; set; } = null!;
        public virtual DbSet<TblInvitationofCalendar> TblInvitationofCalendars { get; set; } = null!;
        public virtual DbSet<TblInvitationofMeeting> TblInvitationofMeetings { get; set; } = null!;
        public virtual DbSet<TblLanguage> TblLanguages { get; set; } = null!;
        public virtual DbSet<TblLinkOfAnn> TblLinkOfAnns { get; set; } = null!;
        public virtual DbSet<TblLinkOfAnnStorage> TblLinkOfAnnStorages { get; set; } = null!;
        public virtual DbSet<TblLoginLog> TblLoginLogs { get; set; } = null!;
        public virtual DbSet<TblMarquee> TblMarquees { get; set; } = null!;
        public virtual DbSet<TblMeet> TblMeets { get; set; } = null!;
        public virtual DbSet<TblMeetType> TblMeetTypes { get; set; } = null!;
        public virtual DbSet<TblMeeting> TblMeetings { get; set; } = null!;
        public virtual DbSet<TblMeetingDisplayDept> TblMeetingDisplayDepts { get; set; } = null!;
        public virtual DbSet<TblMeetingDisplayObject> TblMeetingDisplayObjects { get; set; } = null!;
        public virtual DbSet<TblMeetingMinute> TblMeetingMinutes { get; set; } = null!;
        public virtual DbSet<TblMeetingRoom> TblMeetingRooms { get; set; } = null!;
        public virtual DbSet<TblModelName> TblModelNames { get; set; } = null!;
        public virtual DbSet<TblNodeMain> TblNodeMains { get; set; } = null!;
        public virtual DbSet<TblNodeName> TblNodeNames { get; set; } = null!;
        public virtual DbSet<TblOrionPushNotification> TblOrionPushNotifications { get; set; } = null!;
        public virtual DbSet<TblPictureOfAnn> TblPictureOfAnns { get; set; } = null!;
        public virtual DbSet<TblPictureOfAnnStorage> TblPictureOfAnnStorages { get; set; } = null!;
        public virtual DbSet<TblPushDepOfAnn> TblPushDepOfAnns { get; set; } = null!;
        public virtual DbSet<TblPushDepOfAnnStorage> TblPushDepOfAnnStorages { get; set; } = null!;
        public virtual DbSet<TblPushDepOfLink> TblPushDepOfLinks { get; set; } = null!;
        public virtual DbSet<TblPushDepOfVote> TblPushDepOfVotes { get; set; } = null!;
        public virtual DbSet<TblPushDeptOfAlbum> TblPushDeptOfAlbums { get; set; } = null!;
        public virtual DbSet<TblPushDeptOfBanner> TblPushDeptOfBanners { get; set; } = null!;
        public virtual DbSet<TblPushDeptOfFileCenter> TblPushDeptOfFileCenters { get; set; } = null!;
        public virtual DbSet<TblPushDeptOfGood> TblPushDeptOfGoods { get; set; } = null!;
        public virtual DbSet<TblPushDeptOfMeeting> TblPushDeptOfMeetings { get; set; } = null!;
        public virtual DbSet<TblPushNotification> TblPushNotifications { get; set; } = null!;
        public virtual DbSet<TblPushOfBanner> TblPushOfBanners { get; set; } = null!;
        public virtual DbSet<TblQuestion> TblQuestions { get; set; } = null!;
        public virtual DbSet<TblReminder> TblReminders { get; set; } = null!;
        public virtual DbSet<TblResource> TblResources { get; set; } = null!;
        public virtual DbSet<TblResourceBorrowList> TblResourceBorrowLists { get; set; } = null!;
        public virtual DbSet<TblResourceFront> TblResourceFronts { get; set; } = null!;
        public virtual DbSet<TblResourceKeeper> TblResourceKeepers { get; set; } = null!;
        public virtual DbSet<TblResourceType> TblResourceTypes { get; set; } = null!;
        public virtual DbSet<TblResourceTypeUser> TblResourceTypeUsers { get; set; } = null!;
        public virtual DbSet<TblResourceUser> TblResourceUsers { get; set; } = null!;
        public virtual DbSet<TblSaveConfirmOfAnn> TblSaveConfirmOfAnns { get; set; } = null!;
        public virtual DbSet<TblSaveConfirmOfGood> TblSaveConfirmOfGoods { get; set; } = null!;
        public virtual DbSet<TblSaveConfirmOfResource> TblSaveConfirmOfResources { get; set; } = null!;
        public virtual DbSet<TblSelection> TblSelections { get; set; } = null!;
        public virtual DbSet<TblSso> TblSsos { get; set; } = null!;
        public virtual DbSet<TblTemplate> TblTemplates { get; set; } = null!;
        public virtual DbSet<TblUploadPicture> TblUploadPictures { get; set; } = null!;
        public virtual DbSet<TblUploadVideo> TblUploadVideos { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;
        public virtual DbSet<TblUserGroup> TblUserGroups { get; set; } = null!;
        public virtual DbSet<TblUserOnGroup> TblUserOnGroups { get; set; } = null!;
        public virtual DbSet<TblVideoOfAnn> TblVideoOfAnns { get; set; } = null!;
        public virtual DbSet<TblVideoOfAnnStorage> TblVideoOfAnnStorages { get; set; } = null!;
        public virtual DbSet<TblViewLogOfAnn> TblViewLogOfAnns { get; set; } = null!;
        public virtual DbSet<TblVote> TblVotes { get; set; } = null!;
        public virtual DbSet<TblVoteFront> TblVoteFronts { get; set; } = null!;
        public virtual DbSet<TblVoteType> TblVoteTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=60.251.54.93;Database=EIP_DB;Trusted_Connection=False;user id=demoeip;password=sa@demoeip; encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogginLog>(entity =>
            {
                entity.HasKey(e => e.SeqNo);

                entity.ToTable("LogginLog");

                entity.Property(e => e.SeqNo).HasComment("遞進號");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("帳號");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("建立日期");

                entity.Property(e => e.Creator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("建立人員");

                entity.Property(e => e.IsDelete)
                    .HasDefaultValueSql("((0))")
                    .HasComment("刪除註記");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改日期");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改人員");

                entity.Property(e => e.Type).HasComment("0.登出 1.登入");
            });

            modelBuilder.Entity<StakeholderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StakeholderView", "Stakeholder");

                entity.Property(e => e.StakeholderId1)
                    .HasMaxLength(20)
                    .HasColumnName("StakeholderID1");

                entity.Property(e => e.StakeholderId2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("StakeholderID2");

                entity.Property(e => e.StakeholderId3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("StakeholderID3");

                entity.Property(e => e.StakeholderId4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("StakeholderID4");

                entity.Property(e => e.StakeholderId5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("StakeholderID5");
            });

            modelBuilder.Entity<TblAccessLog>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblAccessLog");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CActionName)
                    .HasMaxLength(50)
                    .HasColumnName("cActionName")
                    .HasComment("{\r\n  \"isquery\":1,\r\n  \"isRequire\":1,\r\n  \"columnDesc\":\"動作名稱\"\r\n}");

                entity.Property(e => e.CApiname)
                    .HasMaxLength(50)
                    .HasColumnName("cAPIName")
                    .HasComment("API");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者Id");

                entity.Property(e => e.CFunctionId)
                    .HasColumnName("cFunctionID")
                    .HasComment("{\r\n  \"isquery\":1,\r\n  \"type\":\"dropdownlist\",\r\n  \"options\":[{\"text\":\"功能1\",\"value\":\"1\"},{\"text\":\"功能2\",\"value\":\"2\"},{\"text\":\"功能3\",\"value\":\"3\"}],\r\n  \"columnDesc\":\"功能\"\r\n}");

                entity.Property(e => e.CIp)
                    .HasMaxLength(50)
                    .HasColumnName("cIP")
                    .HasComment("IP");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(500)
                    .HasColumnName("cRemark")
                    .HasComment("備註");

                entity.Property(e => e.CRequest)
                    .HasColumnName("cRequest")
                    .HasComment("請求參數");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("更新日期");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者Id");

                entity.Property(e => e.CUrl)
                    .HasMaxLength(200)
                    .HasColumnName("cUrl")
                    .HasComment("URL");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");
            });

            modelBuilder.Entity<TblAddressbook>(entity =>
            {
                entity.HasKey(e => e.CaddressBookId)
                    .HasName("PK__tmp_ms_x__9916B609D3E9E12F");

                entity.ToTable("tblAddressbook");

                entity.Property(e => e.CaddressBookId).HasColumnName("CAddressBookId");

                entity.Property(e => e.CBuId).HasColumnName("cBuId");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainId");

                entity.Property(e => e.Caccount)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CAccount");

                entity.Property(e => e.CcellPhone)
                    .HasMaxLength(500)
                    .HasColumnName("CCellPhone");

                entity.Property(e => e.CcompanyPhone)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CCompanyPhone");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CdeptName)
                    .HasMaxLength(500)
                    .HasColumnName("CDeptName");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(500)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cextension)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CExtension");

                entity.Property(e => e.Cgender).HasColumnName("CGender");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CjobTitle)
                    .HasMaxLength(500)
                    .HasColumnName("CJobTitle");

                entity.Property(e => e.Cremark1)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark1")
                    .IsFixedLength();

                entity.Property(e => e.Cremark10)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark10")
                    .IsFixedLength();

                entity.Property(e => e.Cremark2)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark2")
                    .IsFixedLength();

                entity.Property(e => e.Cremark3)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark3")
                    .IsFixedLength();

                entity.Property(e => e.Cremark4)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark4")
                    .IsFixedLength();

                entity.Property(e => e.Cremark5)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark5")
                    .IsFixedLength();

                entity.Property(e => e.Cremark6)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark6")
                    .IsFixedLength();

                entity.Property(e => e.Cremark7)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark7")
                    .IsFixedLength();

                entity.Property(e => e.Cremark8)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark8")
                    .IsFixedLength();

                entity.Property(e => e.Cremark9)
                    .HasMaxLength(10)
                    .HasColumnName("CRemark9")
                    .IsFixedLength();

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.Property(e => e.CuserName)
                    .HasMaxLength(500)
                    .HasColumnName("CUserName");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblAddressbooks)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAddressbook_tblBusinessUnit");
            });

            modelBuilder.Entity<TblAlbum>(entity =>
            {
                entity.HasKey(e => e.CalbumId)
                    .HasName("PK__tmp_ms_x__54D1960304A188D7");

                entity.ToTable("tblAlbum");

                entity.Property(e => e.CalbumId).HasColumnName("CAlbumID");

                entity.Property(e => e.CBuId).HasColumnName("cBuId");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainId");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.Calbum)
                    .HasMaxLength(1000)
                    .HasColumnName("CAlbum");

                entity.Property(e => e.Corder).HasColumnName("COrder");
            });

            modelBuilder.Entity<TblAlbumManagement>(entity =>
            {
                entity.HasKey(e => e.CpictureId)
                    .HasName("PK__tmp_ms_x__D83785C2C7E45B1A");

                entity.ToTable("tblAlbumManagement");

                entity.Property(e => e.CpictureId).HasColumnName("CPictureID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CalbumId).HasColumnName("CAlbumID");

                entity.Property(e => e.Cdescription).HasColumnName("CDescription");

                entity.Property(e => e.CfileName)
                    .HasMaxLength(2000)
                    .HasColumnName("CFileName");

                entity.Property(e => e.CfileSize)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CFileSize");

                entity.Property(e => e.CisCover).HasColumnName("CIsCover");

                entity.Property(e => e.Cname)
                    .HasMaxLength(2000)
                    .HasColumnName("CName");

                entity.Property(e => e.Corder).HasColumnName("COrder");

                entity.Property(e => e.Cpicture).HasColumnName("CPicture");

                entity.Property(e => e.Curl)
                    .HasMaxLength(2000)
                    .HasColumnName("CUrl");
            });

            modelBuilder.Entity<TblAnnouncement>(entity =>
            {
                entity.HasKey(e => e.CAnnouncementId)
                    .HasName("PK__tmp_ms_x__58C4623338BBD179");

                entity.ToTable("tblAnnouncement");

                entity.Property(e => e.CAnnouncementId)
                    .HasColumnName("cAnnouncementID")
                    .HasComment("公告ID");

                entity.Property(e => e.CAnnouncementTypeId)
                    .HasColumnName("cAnnouncementTypeID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("公告分類ID");

                entity.Property(e => e.CCancelTop)
                    .HasColumnType("datetime")
                    .HasColumnName("cCancelTop");

                entity.Property(e => e.CContent)
                    .HasColumnName("cContent")
                    .HasComment("文章內容");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("新增時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("新增者");

                entity.Property(e => e.CIsAppear)
                    .HasColumnName("cIsAppear")
                    .HasComment("是否呈現前台");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CIsPush)
                    .HasColumnName("cIsPush")
                    .HasComment("是否文章推播");

                entity.Property(e => e.CIsSendPush)
                    .HasColumnName("cIsSendPush")
                    .HasComment("每日發送推播予未閱讀者(小時)");

                entity.Property(e => e.CIsread)
                    .HasColumnName("cIsread")
                    .HasComment("是否必需閱讀");

                entity.Property(e => e.CNodeMainId)
                    .HasColumnName("cNodeMainId")
                    .HasComment("節點ID");

                entity.Property(e => e.COffShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cOffShelfDate")
                    .HasComment("下架日期");

                entity.Property(e => e.COnShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cOnShelfDate")
                    .HasComment("上架日期");

                entity.Property(e => e.CQoute)
                    .HasMaxLength(1000)
                    .HasColumnName("cQoute")
                    .HasComment("簡述");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasDefaultValueSql("((0))")
                    .HasComment("狀態1.上架 0.下架");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(300)
                    .HasColumnName("cTitle")
                    .HasComment("標題");

                entity.Property(e => e.CTop)
                    .HasColumnName("cTop")
                    .HasComment("置頂");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.Property(e => e.CUrl)
                    .HasColumnName("cURL")
                    .HasComment("URL");

                entity.HasOne(d => d.CAnnouncementType)
                    .WithMany(p => p.TblAnnouncements)
                    .HasForeignKey(d => d.CAnnouncementTypeId)
                    .HasConstraintName("FK_tblAnnouncement_ToTable");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblAnnouncements)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAnnouncement_ToTblNodeMain");
            });

            modelBuilder.Entity<TblAnnouncementStorage>(entity =>
            {
                entity.HasKey(e => e.CAnnouncementId)
                    .HasName("PK__tmp_ms_x__58C46233895AB0F1");

                entity.ToTable("tblAnnouncementStorage");

                entity.Property(e => e.CAnnouncementId).HasColumnName("cAnnouncementID");

                entity.Property(e => e.CAnnouncementStorageId).HasColumnName("cAnnouncementStorageID");

                entity.Property(e => e.CAnnouncementTypeId)
                    .HasColumnName("cAnnouncementTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CCancelTop)
                    .HasColumnType("datetime")
                    .HasColumnName("cCancelTop");

                entity.Property(e => e.CContent).HasColumnName("cContent");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsAppear).HasColumnName("cIsAppear");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CIsPush).HasColumnName("cIsPush");

                entity.Property(e => e.CIsSendPush).HasColumnName("cIsSendPush");

                entity.Property(e => e.CIsread).HasColumnName("cIsread");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainId");

                entity.Property(e => e.COffShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cOffShelfDate");

                entity.Property(e => e.COnShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cOnShelfDate");

                entity.Property(e => e.CQoute)
                    .HasMaxLength(1000)
                    .HasColumnName("cQoute");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(300)
                    .HasColumnName("cTitle");

                entity.Property(e => e.CTop).HasColumnName("cTop");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUrl).HasColumnName("cURL");

                entity.HasOne(d => d.CAnnouncementStorage)
                    .WithMany(p => p.TblAnnouncementStorages)
                    .HasForeignKey(d => d.CAnnouncementStorageId)
                    .HasConstraintName("FK_tblAnnouncementStorage_tblAnnouncement");

                entity.HasOne(d => d.CAnnouncementType)
                    .WithMany(p => p.TblAnnouncementStorages)
                    .HasForeignKey(d => d.CAnnouncementTypeId)
                    .HasConstraintName("FK_tblAnnouncementStorage_tblAnnouncementType");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblAnnouncementStorages)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAnnouncementStorage_ToTblNodeMain");
            });

            modelBuilder.Entity<TblAnnouncementType>(entity =>
            {
                entity.HasKey(e => e.CAnnouncementTypeId)
                    .HasName("PK__tmp_ms_x__8F90CCC7CA5DC9B7");

                entity.ToTable("tblAnnouncementType");

                entity.Property(e => e.CAnnouncementTypeId)
                    .HasColumnName("cAnnouncementTypeID")
                    .HasComment("類別編號");

                entity.Property(e => e.CAnnouncementTypeName)
                    .HasMaxLength(100)
                    .HasColumnName("cAnnouncementTypeName")
                    .HasComment("類別名稱");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司流水號");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblAnnouncementTypes)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAnnouncementType_ToTable");
            });

            modelBuilder.Entity<TblAnswer>(entity =>
            {
                entity.HasKey(e => e.CanswerId)
                    .HasName("PK__tmp_ms_x__22973C5B680FD5C1");

                entity.ToTable("tblAnswer");

                entity.Property(e => e.CanswerId).HasColumnName("CAnswerId");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.Canswer)
                    .HasMaxLength(2000)
                    .HasColumnName("CAnswer");

                entity.Property(e => e.CquestionId).HasColumnName("CQuestionId");

                entity.Property(e => e.CvoteFrontId).HasColumnName("CVoteFrontId");

                entity.HasOne(d => d.Cquestion)
                    .WithMany(p => p.TblAnswers)
                    .HasForeignKey(d => d.CquestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAnswer_tblVoteType");

                entity.HasOne(d => d.CvoteFront)
                    .WithMany(p => p.TblAnswers)
                    .HasForeignKey(d => d.CvoteFrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAnswer_tblVoteFront");
            });

            modelBuilder.Entity<TblAppointment>(entity =>
            {
                entity.HasKey(e => e.CAppointmentId)
                    .HasName("PK__tblAppoi__88CA28608BDD47E3");

                entity.ToTable("tblAppointment");

                entity.Property(e => e.CAppointmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("cAppointmentID");

                entity.Property(e => e.CAdress)
                    .HasMaxLength(500)
                    .HasColumnName("cAdress");

                entity.Property(e => e.CBorrowTimeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("cBorrowTimeEnd");

                entity.Property(e => e.CBorrowTimeStart)
                    .HasColumnType("datetime")
                    .HasColumnName("cBorrowTimeStart");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CCycleEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("cCycleEnd");

                entity.Property(e => e.CCycleStart)
                    .HasColumnType("datetime")
                    .HasColumnName("cCycleStart");

                entity.Property(e => e.CDisplay).HasColumnName("cDisplay");

                entity.Property(e => e.CEvery).HasColumnName("cEvery");

                entity.Property(e => e.CFrequency).HasColumnName("cFrequency");

                entity.Property(e => e.CFrequencyType).HasColumnName("cFrequencyType");

                entity.Property(e => e.CFriday)
                    .HasColumnName("cFriday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CInstruction)
                    .HasMaxLength(500)
                    .HasColumnName("cInstruction");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CMeetName)
                    .HasMaxLength(500)
                    .HasColumnName("cMeetName");

                entity.Property(e => e.CMeetNameId).HasColumnName("cMeetNameID");

                entity.Property(e => e.CMeetTypeNameId).HasColumnName("cMeetTypeNameID");

                entity.Property(e => e.CMonday)
                    .HasColumnName("cMonday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.COrdinal).HasColumnName("cOrdinal");

                entity.Property(e => e.CReminder).HasColumnName("cReminder");

                entity.Property(e => e.CResourceNameId).HasColumnName("cResourceNameID");

                entity.Property(e => e.CSaturday)
                    .HasColumnName("cSaturday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CSunday)
                    .HasColumnName("cSunday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CThursday)
                    .HasColumnName("cThursday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CTimeUnit).HasColumnName("cTimeUnit");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(500)
                    .HasColumnName("cTitle");

                entity.Property(e => e.CTuesday)
                    .HasColumnName("cTuesday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CWednesday)
                    .HasColumnName("cWednesday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CWeek).HasColumnName("cWeek");

                entity.Property(e => e.CisGoogle).HasColumnName("CIsGoogle ");

                entity.Property(e => e.CisOutlook).HasColumnName("CIsOutlook");

                entity.Property(e => e.Csetting).HasColumnName("CSetting");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblAppointments)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAppointment_tblBusinessUnit");
            });

            modelBuilder.Entity<TblAssignWork>(entity =>
            {
                entity.HasKey(e => e.CassignId)
                    .HasName("PK__tmp_ms_x__8C84D4F81CCEA2A8");

                entity.ToTable("tblAssignWork");

                entity.Property(e => e.CassignId).HasColumnName("CAssignID");

                entity.Property(e => e.Buid).HasColumnName("BUID");

                entity.Property(e => e.Ccontent)
                    .HasMaxLength(1000)
                    .HasColumnName("CContent");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CdueTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CDueTime");

                entity.Property(e => e.Cexecutor).HasColumnName("CExecutor");

                entity.Property(e => e.Cillustration)
                    .HasMaxLength(1000)
                    .HasColumnName("CIllustration");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CisRedmine).HasColumnName("CIsRedmine");

                entity.Property(e => e.CmeetingId).HasColumnName("CMeetingID");

                entity.Property(e => e.CoverviewofProject)
                    .HasMaxLength(1000)
                    .HasColumnName("COverviewofProject");

                entity.Property(e => e.CoverviewofVersion)
                    .HasMaxLength(1000)
                    .HasColumnName("COverviewofVersion");

                entity.Property(e => e.Cpriority).HasColumnName("CPriority");

                entity.Property(e => e.Cprogress).HasColumnName("CProgress");

                entity.Property(e => e.Cproject)
                    .HasMaxLength(1000)
                    .HasColumnName("CProject");

                entity.Property(e => e.CprojectCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CProjectCode");

                entity.Property(e => e.CprojectId).HasColumnName("CProjectID");

                entity.Property(e => e.Csponsor).HasColumnName("CSponsor");

                entity.Property(e => e.CstartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CStartTime");

                entity.Property(e => e.Cstatus).HasColumnName("CStatus");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.Property(e => e.Cversion)
                    .HasMaxLength(1000)
                    .HasColumnName("CVersion");

                entity.Property(e => e.CversionId).HasColumnName("CVersionID");

                entity.Property(e => e.CworkMatters)
                    .HasMaxLength(200)
                    .HasColumnName("CWorkMatters");
            });

            modelBuilder.Entity<TblAssignWorkHistory>(entity =>
            {
                entity.ToTable("tblAssignWorkHistory");

                entity.Property(e => e.TblAssignWorkHistoryId).HasColumnName("tblAssignWorkHistoryId");

                entity.Property(e => e.CassignId).HasColumnName("CAssignID");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.Cillustration)
                    .HasMaxLength(1000)
                    .HasColumnName("CIllustration");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.Cprogress).HasColumnName("CProgress");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.Property(e => e.CuserId).HasColumnName("CUserID");

                entity.HasOne(d => d.Cassign)
                    .WithMany(p => p.TblAssignWorkHistories)
                    .HasForeignKey(d => d.CassignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAssignWorkHistory_tblAssignWork");
            });

            modelBuilder.Entity<TblAssignWorkUpload>(entity =>
            {
                entity.ToTable("tblAssignWorkUpload");

                entity.Property(e => e.TblAssignWorkUploadId).HasColumnName("tblAssignWorkUploadId");

                entity.Property(e => e.CassignId).HasColumnName("CAssignID");

                entity.Property(e => e.CattachmentName).HasColumnName("CAttachmentName");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CfileName)
                    .HasMaxLength(100)
                    .HasColumnName("CFileName")
                    .IsFixedLength();

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.HasOne(d => d.Cassign)
                    .WithMany(p => p.TblAssignWorkUploads)
                    .HasForeignKey(d => d.CassignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAssignWorkUpload_tblAssignWork");
            });

            modelBuilder.Entity<TblAttachment>(entity =>
            {
                entity.HasKey(e => e.CAttachmentId)
                    .HasName("PK__tmp_ms_x__ACC4ED3CF1A50C3E");

                entity.ToTable("tblAttachment");

                entity.Property(e => e.CAttachmentId)
                    .HasColumnName("cAttachmentID")
                    .HasComment("標題ID");

                entity.Property(e => e.CAttachment)
                    .HasMaxLength(500)
                    .HasColumnName("cAttachment")
                    .HasComment("標題");

                entity.Property(e => e.CAttachmentTypeId).HasColumnName("cAttachmentTypeID");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司ID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDeptId)
                    .HasColumnName("cDeptID")
                    .HasComment("連結顯示對象");

                entity.Property(e => e.CEnglishAttachment)
                    .HasMaxLength(500)
                    .HasColumnName("cEnglishAttachment")
                    .HasComment("英文標題");

                entity.Property(e => e.CEnglishAttachmentId)
                    .HasColumnName("cEnglishAttachmentID")
                    .HasComment("英文標題ID");

                entity.Property(e => e.CEnglishUrl)
                    .HasMaxLength(500)
                    .HasColumnName("cEnglishURL")
                    .HasComment("英文URL");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CIsSso).HasColumnName("cIsSso");

                entity.Property(e => e.COrder)
                    .HasColumnName("cOrder")
                    .HasComment("排序");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.Property(e => e.CUrl)
                    .HasMaxLength(500)
                    .HasColumnName("cURL")
                    .HasComment("URL");

                entity.HasOne(d => d.CAttachmentType)
                    .WithMany(p => p.TblAttachments)
                    .HasForeignKey(d => d.CAttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttachment_tblAttachmentType");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblAttachments)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttachment_tblBusinessUnit");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblAttachments)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttachment_tblDept");
            });

            modelBuilder.Entity<TblAttachmentOfAnn>(entity =>
            {
                entity.HasKey(e => e.CAttachmentOfAnnId)
                    .HasName("PK__tmp_ms_x__4ECB1A389BFA7769");

                entity.ToTable("tblAttachmentOfAnn");

                entity.Property(e => e.CAttachmentOfAnnId)
                    .HasColumnName("cAttachmentOfAnnID")
                    .HasComment("附件類型Id");

                entity.Property(e => e.CAnnouncementId)
                    .HasColumnName("cAnnouncementID")
                    .HasComment("公告ID");

                entity.Property(e => e.CAttachmentName)
                    .HasMaxLength(100)
                    .HasColumnName("cAttachmentName")
                    .HasComment("附件名稱");

                entity.Property(e => e.CAttachmentOfAnnType)
                    .HasColumnName("cAttachmentOfAnnType")
                    .HasComment("附件類型");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("cDescription")
                    .HasComment("描述");

                entity.Property(e => e.CFileName)
                    .HasMaxLength(500)
                    .HasColumnName("cFileName")
                    .HasComment("檔名");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(200)
                    .HasColumnName("cTitle")
                    .HasComment("附件標題");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblAttachmentOfAnns)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttachmentOfAnn_ToTable");
            });

            modelBuilder.Entity<TblAttachmentOfAnnStorage>(entity =>
            {
                entity.HasKey(e => e.CAttachmentOfAnnId)
                    .HasName("PK__tmp_ms_x__4ECB1A3852B83960");

                entity.ToTable("tblAttachmentOfAnnStorage");

                entity.Property(e => e.CAttachmentOfAnnId).HasColumnName("cAttachmentOfAnnID");

                entity.Property(e => e.CAnnouncementId).HasColumnName("cAnnouncementID");

                entity.Property(e => e.CAttachmentName)
                    .HasMaxLength(100)
                    .HasColumnName("cAttachmentName");

                entity.Property(e => e.CAttachmentOfAnnType).HasColumnName("cAttachmentOfAnnType");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("cDescription");

                entity.Property(e => e.CFileName)
                    .HasMaxLength(500)
                    .HasColumnName("cFileName");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(200)
                    .HasColumnName("cTitle");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblAttachmentOfAnnStorages)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttachmentOfAnnStorage_tblAnnouncementStorage");
            });

            modelBuilder.Entity<TblAttachmentOfMeeting>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__tmp_ms_x__C1F8DC598CCA8E1D");

                entity.ToTable("tblAttachmentOfMeeting");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.CattachmentName).HasColumnName("CAttachmentName");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.Cdescription)
                    .HasMaxLength(100)
                    .HasColumnName("CDescription");

                entity.Property(e => e.CfileName).HasColumnName("CFileName");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CmeetingMinutesId).HasColumnName("CMeetingMinutesId");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.HasOne(d => d.CmeetingMinutes)
                    .WithMany(p => p.TblAttachmentOfMeetings)
                    .HasForeignKey(d => d.CmeetingMinutesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttachmentOfMeeting_tblMeetingMinutes");
            });

            modelBuilder.Entity<TblAttachmentType>(entity =>
            {
                entity.HasKey(e => e.CAttachmentTypeId)
                    .HasName("PK__tmp_ms_x__AE16216E726DBF0D");

                entity.ToTable("tblAttachmentType");

                entity.Property(e => e.CAttachmentTypeId)
                    .HasColumnName("cAttachmentTypeID")
                    .HasComment("分類名稱ID");

                entity.Property(e => e.CAttachmentType)
                    .HasMaxLength(500)
                    .HasColumnName("cAttachmentType")
                    .HasComment("分類母語名稱");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司ID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CEnglishAttachmentType)
                    .HasMaxLength(500)
                    .HasColumnName("cEnglishAttachmentType")
                    .HasComment("分類英文名稱");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainId");

                entity.Property(e => e.COrder)
                    .HasColumnName("cOrder")
                    .HasComment("排序");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblAttachmentTypes)
                    .HasForeignKey(d => d.CBuId)
                    .HasConstraintName("FK_tblAttachmentType_tblBusinessUnit");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblAttachmentTypes)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttachmentType_tblNodeMain");
            });

            modelBuilder.Entity<TblAttendance>(entity =>
            {
                entity.HasKey(e => new { e.CUserId, e.CResourceAppointId })
                    .HasName("PK__tmp_ms_x__020A5A8229C9EF4C");

                entity.ToTable("tblAttendance");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.CResourceAppointId).HasColumnName("cResourceAppointID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CResourceAppoint)
                    .WithMany(p => p.TblAttendances)
                    .HasForeignKey(d => d.CResourceAppointId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAttendance_tblResourceFront");
            });

            modelBuilder.Entity<TblBanner>(entity =>
            {
                entity.HasKey(e => e.CBannerId)
                    .HasName("PK__tmp_ms_x__38D2A1A9D6DED497");

                entity.ToTable("tblBanner");

                entity.Property(e => e.CBannerId).HasColumnName("cBannerID");

                entity.Property(e => e.CBannerName)
                    .HasMaxLength(100)
                    .HasColumnName("cBannerName");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CDescription).HasColumnName("cDescription");

                entity.Property(e => e.CIsAppear).HasColumnName("cIsAppear");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CIsNewPage).HasColumnName("cIsNewPage");

                entity.Property(e => e.CLink).HasColumnName("cLink");

                entity.Property(e => e.COffShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cOffShelfDate");

                entity.Property(e => e.COnShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cOnShelfDate");

                entity.Property(e => e.COrder).HasColumnName("cOrder");

                entity.Property(e => e.CPicture).HasColumnName("cPicture");

                entity.Property(e => e.CPictureName).HasColumnName("cPictureName");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");

                entity.Property(e => e.CTransUrl).HasColumnName("cTransURL");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUrl).HasColumnName("cURL");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblBanners)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBanner_tblBusinessUnit");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblBanners)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBanner_tblDept");
            });

            modelBuilder.Entity<TblBlock>(entity =>
            {
                entity.HasKey(e => e.CBlockId)
                    .HasName("PK__tblBlock__6D8158D223263F3E");

                entity.ToTable("tblBlock");

                entity.Property(e => e.CBlockId)
                    .HasColumnName("cBlockId")
                    .HasComment("首頁區塊Id");

                entity.Property(e => e.CBlockSize)
                    .HasColumnName("cBlockSize")
                    .HasComment("區塊大小");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司流水號");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CNodeMainId)
                    .HasColumnName("cNodeMainId")
                    .HasComment("節點主表Id");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblBlocks)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBlock_tblBu");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblBlocks)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBlock_tblNodeMain");
            });

            modelBuilder.Entity<TblBuLanguage>(entity =>
            {
                entity.HasKey(e => e.CBuLanguageId)
                    .HasName("PK__tblBuLan__440A244EC405A8AE");

                entity.ToTable("tblBuLanguage");

                entity.Property(e => e.CBuLanguageId)
                    .HasColumnName("cBuLanguageID")
                    .HasComment("公司語系ID");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司流水號");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CLanguageId)
                    .HasColumnName("cLanguageId")
                    .HasComment("語系Id");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblBuLanguages)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBuLanguage_ToTable");

                entity.HasOne(d => d.CLanguage)
                    .WithMany(p => p.TblBuLanguages)
                    .HasForeignKey(d => d.CLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBuLanguage_ToTable_1");
            });

            modelBuilder.Entity<TblBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblBusinessUnit");

                entity.HasComment("企業主檔");

                entity.Property(e => e.CId)
                    .HasColumnName("cID")
                    .HasComment("BUID");

                entity.Property(e => e.CBucode)
                    .HasMaxLength(20)
                    .HasColumnName("cBUCode")
                    .HasComment("BU代碼");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(200)
                    .HasColumnName("cDescription")
                    .HasComment("說明");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .HasColumnName("cName")
                    .HasComment("BU名稱");

                entity.Property(e => e.CPlatformIsSupport)
                    .HasColumnName("cPlatformIsSupport")
                    .HasComment("是否支援");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(500)
                    .HasColumnName("cRemark")
                    .HasComment("備註");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態");

                entity.Property(e => e.CTenantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cTenantId");

                entity.Property(e => e.CType)
                    .HasColumnName("cType")
                    .HasComment("1 平台 2 商戶");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserLimit)
                    .HasColumnName("cUserLimit")
                    .HasComment("使用者上限");
            });

            modelBuilder.Entity<TblBusinessUnitBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBusinessUnit_bak");

                entity.Property(e => e.CBucode)
                    .HasMaxLength(20)
                    .HasColumnName("cBUCode");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(200)
                    .HasColumnName("cDescription");

                entity.Property(e => e.CId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cID");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .HasColumnName("cName");

                entity.Property(e => e.CPlatformIsSupport).HasColumnName("cPlatformIsSupport");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(500)
                    .HasColumnName("cRemark");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");

                entity.Property(e => e.CType).HasColumnName("cType");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserLimit).HasColumnName("cUserLimit");
            });

            modelBuilder.Entity<TblCalendar>(entity =>
            {
                entity.HasKey(e => e.CCalendarId)
                    .HasName("PK__tmp_ms_x__A4C1FD85E216DDB7");

                entity.ToTable("tblCalendar");

                entity.Property(e => e.CCalendarId).HasColumnName("cCalendarID");

                entity.Property(e => e.CAdress)
                    .HasMaxLength(500)
                    .HasColumnName("cAdress");

                entity.Property(e => e.CBorrowTimeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("cBorrowTimeEnd");

                entity.Property(e => e.CBorrowTimeStart)
                    .HasColumnType("datetime")
                    .HasColumnName("cBorrowTimeStart");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CCalendarName)
                    .HasMaxLength(500)
                    .HasColumnName("cCalendarName");

                entity.Property(e => e.CConfirmStatus).HasColumnName("cConfirmStatus");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CCycleEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("cCycleEnd");

                entity.Property(e => e.CCycleStart)
                    .HasColumnType("datetime")
                    .HasColumnName("cCycleStart");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CDisplay).HasColumnName("cDisplay");

                entity.Property(e => e.CEvery).HasColumnName("cEvery");

                entity.Property(e => e.CFrequency).HasColumnName("cFrequency");

                entity.Property(e => e.CFrequencyType).HasColumnName("cFrequencyType");

                entity.Property(e => e.CFriday)
                    .HasColumnName("cFriday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CInstruction)
                    .HasMaxLength(500)
                    .HasColumnName("cInstruction");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CKeyword)
                    .HasMaxLength(500)
                    .HasColumnName("cKeyword");

                entity.Property(e => e.CMonday)
                    .HasColumnName("cMonday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainId");

                entity.Property(e => e.COrdinal).HasColumnName("cOrdinal");

                entity.Property(e => e.CParentsId).HasColumnName("cParentsID");

                entity.Property(e => e.CReminder).HasColumnName("cReminder");

                entity.Property(e => e.CSaturday)
                    .HasColumnName("cSaturday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CSunday)
                    .HasColumnName("cSunday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CThursday)
                    .HasColumnName("cThursday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CTimeUnit).HasColumnName("cTimeUnit");

                entity.Property(e => e.CTuesday)
                    .HasColumnName("cTuesday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CWednesday)
                    .HasColumnName("cWednesday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CWeek).HasColumnName("cWeek");

                entity.Property(e => e.CisGoogle).HasColumnName("CIsGoogle ");

                entity.Property(e => e.CisOutlook).HasColumnName("CIsOutlook");

                entity.Property(e => e.Csetting).HasColumnName("CSetting");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblCalendars)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCalendar_tblBusinessUnit");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblCalendars)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCalendar_tblDept");
            });

            modelBuilder.Entity<TblConfirmOfAnn>(entity =>
            {
                entity.HasKey(e => e.CConfirmOfAnnId)
                    .HasName("PK__tblConfi__3BE4B1E90AE6246F");

                entity.ToTable("tblConfirmOfAnn");

                entity.Property(e => e.CConfirmOfAnnId).HasColumnName("cConfirmOfAnnID");

                entity.Property(e => e.CAnnouncementId).HasColumnName("cAnnouncementID");

                entity.Property(e => e.CConfirmStatus).HasColumnName("cConfirmStatus");

                entity.Property(e => e.CConfirmTime)
                    .HasColumnType("datetime")
                    .HasColumnName("cConfirmTime");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.COffShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cOffShelfDate");

                entity.Property(e => e.COnShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cOnShelfDate");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(1000)
                    .HasColumnName("cRemark");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(1000)
                    .HasColumnName("cTitle");

                entity.Property(e => e.CTrialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cTrialDate");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");
            });

            modelBuilder.Entity<TblConfirmOfMeet>(entity =>
            {
                entity.HasKey(e => e.CConfirmOfMeetId)
                    .HasName("PK__tblConfi__378E8A5B57952AF2");

                entity.ToTable("tblConfirmOfMeet");

                entity.Property(e => e.CConfirmOfMeetId).HasColumnName("cConfirmOfMeetID");

                entity.Property(e => e.CConfirmStatus).HasColumnName("cConfirmStatus");

                entity.Property(e => e.CConfirmTime)
                    .HasColumnType("datetime")
                    .HasColumnName("cConfirmTime");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CMeetNameId).HasColumnName("cMeetNameID");

                entity.Property(e => e.CMeetTypeNameId).HasColumnName("cMeetTypeNameID");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(1000)
                    .HasColumnName("cRemark");

                entity.Property(e => e.CTrialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cTrialDate");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.HasOne(d => d.CMeetName)
                    .WithMany(p => p.TblConfirmOfMeets)
                    .HasForeignKey(d => d.CMeetNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblConfirmOfMeet_tblMeet");

                entity.HasOne(d => d.CMeetTypeName)
                    .WithMany(p => p.TblConfirmOfMeets)
                    .HasForeignKey(d => d.CMeetTypeNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblConfirmOfMeet_tblMeetType");
            });

            modelBuilder.Entity<TblConfirmOfResource>(entity =>
            {
                entity.HasKey(e => e.CConfirmOfResourceId)
                    .HasName("PK__tblConfi__6C00FE96DC58A01A");

                entity.ToTable("tblConfirmOfResource");

                entity.Property(e => e.CConfirmOfResourceId).HasColumnName("cConfirmOfResourceID");

                entity.Property(e => e.CConfirmStatus).HasColumnName("cConfirmStatus");

                entity.Property(e => e.CConfirmTime)
                    .HasColumnType("datetime")
                    .HasColumnName("cConfirmTime");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(1000)
                    .HasColumnName("cRemark");

                entity.Property(e => e.CResourceNameId).HasColumnName("cResourceNameID");

                entity.Property(e => e.CResourceTypeNameId).HasColumnName("cResourceTypeNameID");

                entity.Property(e => e.CTrialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cTrialDate");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");
            });

            modelBuilder.Entity<TblDept>(entity =>
            {
                entity.HasKey(e => e.CDeptId)
                    .HasName("PK__tmp_ms_x__F96B472C87D1B068");

                entity.ToTable("tblDept");

                entity.HasIndex(e => e.CBuId, "IX_tblDept_Column");

                entity.Property(e => e.CDeptId)
                    .HasColumnName("cDeptID")
                    .HasComment("部門流水號");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司ID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDeptCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cDeptCode")
                    .HasComment("部門代號");

                entity.Property(e => e.CDeptLevel)
                    .HasColumnName("cDeptLevel")
                    .HasComment("部門等級");

                entity.Property(e => e.CDeptName)
                    .HasMaxLength(1000)
                    .HasColumnName("cDeptName")
                    .HasComment("部門名稱");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CParentDeptId)
                    .HasColumnName("cParentDeptID")
                    .HasComment("父部門ID");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblDepts)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDept_ToTable");
            });

            modelBuilder.Entity<TblDisplayObject>(entity =>
            {
                entity.HasKey(e => e.CDisplayObjectId)
                    .HasName("PK__tblDispl__889AD91652C51DE4");

                entity.ToTable("tblDisplayObject");

                entity.Property(e => e.CDisplayObjectId).HasColumnName("cDisplayObjectID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainID");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblDisplayObjects)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDisplayObject_tblNodeMain");
            });

            modelBuilder.Entity<TblFileCenter>(entity =>
            {
                entity.HasKey(e => e.CfolderId)
                    .HasName("PK__tmp_ms_x__19DCFCD85E817E34");

                entity.ToTable("tblFileCenter");

                entity.Property(e => e.CfolderId).HasColumnName("CFolderID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CbuId).HasColumnName("CBuID");

                entity.Property(e => e.CfolderName)
                    .HasMaxLength(200)
                    .HasColumnName("CFolderName");

                entity.Property(e => e.CnodeMainId).HasColumnName("CNodeMainId");

                entity.Property(e => e.Corder).HasColumnName("COrder");

                entity.Property(e => e.CparentFolderId).HasColumnName("CParentFolderId");

                entity.Property(e => e.Cstatus).HasColumnName("CStatus");
            });

            modelBuilder.Entity<TblFilesManagement>(entity =>
            {
                entity.HasKey(e => e.CfileId)
                    .HasName("PK__tblFiles__ADBD2712CB1DB396");

                entity.ToTable("tblFilesManagement");

                entity.Property(e => e.CfileId).HasColumnName("CFileID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CfileName)
                    .HasMaxLength(2000)
                    .HasColumnName("CFileName");

                entity.Property(e => e.CfileUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CFileUrl");

                entity.Property(e => e.Corder).HasColumnName("COrder");

                entity.Property(e => e.CparentFolderId).HasColumnName("CParentFolderId");

                entity.Property(e => e.Csize).HasColumnName("CSize");
            });

            modelBuilder.Entity<TblFilterOfNode>(entity =>
            {
                entity.HasKey(e => e.FilterOfNodeId)
                    .HasName("PK__tmp_ms_x__4D24C9EF9339C884");

                entity.ToTable("tblFilterOfNode");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainID");

                entity.Property(e => e.CResourceName)
                    .HasMaxLength(200)
                    .HasColumnName("cResourceName");

                entity.Property(e => e.CResourceNameId).HasColumnName("cResourceNameID");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblFilterOfNodes)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFilterOfNode_tblNodeMain");
            });

            modelBuilder.Entity<TblFunction>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblFunction");

                entity.HasComment("單元(已審核)");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("cID")
                    .HasComment("模組編號");

                entity.Property(e => e.CCompetenceType)
                    .HasColumnName("cCompetenceType")
                    .HasComment("(0:是單元, 1:新增, 2:修改, 3:檢視, 4:刪除, 5:審核)");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CCssStyle)
                    .HasMaxLength(50)
                    .HasColumnName("cCssStyle")
                    .HasComment("後台CSS樣式名稱");

                entity.Property(e => e.CFlowId)
                    .HasColumnName("cFlowID")
                    .HasComment("審查流程ID");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("緩刪除(0:未刪除, 1:已刪除)");

                entity.Property(e => e.CIsMenu)
                    .HasColumnName("cIsMenu")
                    .HasComment("是否為後台目錄(0:否, 1:是)");

                entity.Property(e => e.CMenuIndex)
                    .HasColumnName("cMenuIndex")
                    .HasComment("前台及後台目錄索引值(排序由小到大)");

                entity.Property(e => e.CName)
                    .HasMaxLength(200)
                    .HasColumnName("cName")
                    .HasComment("模組名稱");

                entity.Property(e => e.CPageUrl)
                    .HasMaxLength(200)
                    .HasColumnName("cPageUrl")
                    .HasComment("功能頁面");

                entity.Property(e => e.CParentId)
                    .HasColumnName("cParentID")
                    .HasComment("父模組編號");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態(0:停用, 1:啟用)");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("修改日期時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("修改者");
            });

            modelBuilder.Entity<TblFunctionOnBu>(entity =>
            {
                entity.HasKey(e => new { e.CBuid, e.CFunctionId });

                entity.ToTable("tblFunctionOnBU");

                entity.HasComment("模組功能管理(對應企業)");

                entity.Property(e => e.CBuid).HasColumnName("cBUID");

                entity.Property(e => e.CFunctionId).HasColumnName("cFunctionID");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");
            });

            modelBuilder.Entity<TblFunctionOnGroup>(entity =>
            {
                entity.HasKey(e => new { e.CUserGroupId, e.CFunctionId })
                    .HasName("PK_tblFunctionOnRole");

                entity.ToTable("tblFunctionOnGroup");

                entity.Property(e => e.CUserGroupId)
                    .HasColumnName("cUserGroupID")
                    .HasComment("使用者群組編號");

                entity.Property(e => e.CFunctionId)
                    .HasColumnName("cFunctionID")
                    .HasComment("功能編號");
            });

            modelBuilder.Entity<TblGood>(entity =>
            {
                entity.HasKey(e => e.CgoodsId);

                entity.ToTable("tblGoods");

                entity.Property(e => e.CgoodsId).HasColumnName("CGoodsID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CPicture)
                    .HasMaxLength(500)
                    .HasColumnName("cPicture");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.Cgoods)
                    .HasMaxLength(200)
                    .HasColumnName("CGoods");

                entity.Property(e => e.CgoodsCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CGoodsCode");

                entity.Property(e => e.CgoodsTypeId).HasColumnName("CGoodsTypeId");

                entity.Property(e => e.CmaxApplication).HasColumnName("CMaxApplication");

                entity.Property(e => e.CminiApplication).HasColumnName("CMiniApplication");

                entity.Property(e => e.Cprice).HasColumnName("CPrice");

                entity.Property(e => e.CsafetyStock).HasColumnName("CSafetyStock");

                entity.Property(e => e.Cstatus).HasColumnName("CStatus");

                entity.Property(e => e.Cstock).HasColumnName("CStock");

                entity.Property(e => e.Cunit)
                    .HasMaxLength(200)
                    .HasColumnName("CUnit");

                entity.Property(e => e.CuserId).HasColumnName("CUserID");
            });

            modelBuilder.Entity<TblGoodsBorrowList>(entity =>
            {
                entity.ToTable("tblGoodsBorrowList");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.Camount).HasColumnName("CAmount");

                entity.Property(e => e.CgoodsFrontId).HasColumnName("CGoodsFrontID");

                entity.Property(e => e.CgoodsId).HasColumnName("CGoodsID");
            });

            modelBuilder.Entity<TblGoodsFront>(entity =>
            {
                entity.HasKey(e => e.CgoodFrontId)
                    .HasName("PK__tmp_ms_x__6AEC95F9E017B395");

                entity.ToTable("tblGoodsFront");

                entity.Property(e => e.CgoodFrontId).HasColumnName("CGoodFrontID");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CisSent).HasColumnName("CIsSent");

                entity.Property(e => e.Crecipt)
                    .HasMaxLength(500)
                    .HasColumnName("CRecipt");

                entity.Property(e => e.Cremark)
                    .HasMaxLength(2000)
                    .HasColumnName("CRemark");
            });

            modelBuilder.Entity<TblGoodsKeeper>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblGoodsKeeper");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CGoodsTypeId).HasColumnName("cGoodsTypeID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");
            });

            modelBuilder.Entity<TblGoodsType>(entity =>
            {
                entity.HasKey(e => e.CgoodsTypeId)
                    .HasName("PK__tmp_ms_x__B319A70E4846FA5E");

                entity.ToTable("tblGoodsType");

                entity.Property(e => e.CgoodsTypeId).HasColumnName("CGoodsTypeId");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CgoodsAmount).HasColumnName("CGoodsAmount");

                entity.Property(e => e.CgoodsType)
                    .HasMaxLength(200)
                    .HasColumnName("CGoodsType");

                entity.Property(e => e.Ckeeper).HasColumnName("CKeeper");

                entity.Property(e => e.Cstatus).HasColumnName("CStatus");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblGoodsTypes)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblGoodsType_tblBusinessUnit");
            });

            modelBuilder.Entity<TblGoodsTypeUser>(entity =>
            {
                entity.ToTable("tblGoodsTypeUser");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CGoodsTypeId).HasColumnName("cGoodsTypeID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");
            });

            modelBuilder.Entity<TblGoodsUser>(entity =>
            {
                entity.ToTable("tblGoodsUser");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CGoodsId).HasColumnName("cGoodsID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");
            });

            modelBuilder.Entity<TblInvitationDeptOfCalendar>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__tmp_ms_x__D830D45754AC2E50");

                entity.ToTable("tblInvitationDeptOfCalendar");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCalendarId).HasColumnName("cCalendarID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CType).HasColumnName("cType");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");
            });

            modelBuilder.Entity<TblInvitationDeptOfMeeting>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__tmp_ms_x__D830D4576608518A");

                entity.ToTable("tblInvitationDeptOfMeeting");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CMeetingId).HasColumnName("cMeetingID");

                entity.Property(e => e.CType).HasColumnName("cType");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");
            });

            modelBuilder.Entity<TblInvitationofCalendar>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__tmp_ms_x__D830D457369A7782");

                entity.ToTable("tblInvitationofCalendar");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCalendarId).HasColumnName("cCalendarID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CName)
                    .HasMaxLength(500)
                    .HasColumnName("cName");

                entity.Property(e => e.CType).HasColumnName("cType");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.HasOne(d => d.CCalendar)
                    .WithMany(p => p.TblInvitationofCalendars)
                    .HasForeignKey(d => d.CCalendarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInvitationofCalendar_tblCalendar");
            });

            modelBuilder.Entity<TblInvitationofMeeting>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__tmp_ms_x__D830D45758BCF082");

                entity.ToTable("tblInvitationofMeeting");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CMeetingId).HasColumnName("cMeetingID");

                entity.Property(e => e.CName)
                    .HasMaxLength(500)
                    .HasColumnName("cName");

                entity.Property(e => e.CType).HasColumnName("cType");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.HasOne(d => d.CMeeting)
                    .WithMany(p => p.TblInvitationofMeetings)
                    .HasForeignKey(d => d.CMeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInvitationofMeeting_tblMeeting");
            });

            modelBuilder.Entity<TblLanguage>(entity =>
            {
                entity.HasKey(e => e.CLanguageId)
                    .HasName("PK__tmp_ms_x__349034DD64ECFD6B");

                entity.ToTable("tblLanguage");

                entity.Property(e => e.CLanguageId).HasColumnName("cLanguageId");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CLanguageCode)
                    .HasMaxLength(10)
                    .HasColumnName("cLanguageCode");

                entity.Property(e => e.CLanguageName)
                    .HasMaxLength(20)
                    .HasColumnName("cLanguageName");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");
            });

            modelBuilder.Entity<TblLinkOfAnn>(entity =>
            {
                entity.HasKey(e => e.CLinkOfAnnId)
                    .HasName("PK__tmp_ms_x__C9FD05F9732D77D4");

                entity.ToTable("tblLinkOfAnn");

                entity.Property(e => e.CLinkOfAnnId)
                    .HasColumnName("cLinkOfAnnID")
                    .HasComment("連結Id");

                entity.Property(e => e.CAnnouncementId)
                    .HasColumnName("cAnnouncementID")
                    .HasComment("公告Id");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("cDescription")
                    .HasComment("描述");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CIsNewPage)
                    .HasColumnName("cIsNewPage")
                    .HasComment("在新視窗開啟");

                entity.Property(e => e.CLinkOfAnnType)
                    .HasColumnName("cLinkOfAnnType")
                    .HasComment("附件類型，1.圖片、2.附件、3.影片");

                entity.Property(e => e.CLinkUrl)
                    .HasMaxLength(500)
                    .HasColumnName("cLinkUrl")
                    .HasComment("連結位置");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblLinkOfAnns)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLinkOfAnn_ToTable");
            });

            modelBuilder.Entity<TblLinkOfAnnStorage>(entity =>
            {
                entity.HasKey(e => e.CLinkOfAnnId)
                    .HasName("PK__tmp_ms_x__C9FD05F9CFD51229");

                entity.ToTable("tblLinkOfAnnStorage");

                entity.Property(e => e.CLinkOfAnnId).HasColumnName("cLinkOfAnnID");

                entity.Property(e => e.CAnnouncementId).HasColumnName("cAnnouncementID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("cDescription");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CIsNewPage).HasColumnName("cIsNewPage");

                entity.Property(e => e.CLinkOfAnnType).HasColumnName("cLinkOfAnnType");

                entity.Property(e => e.CLinkUrl)
                    .HasMaxLength(500)
                    .HasColumnName("cLinkUrl");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblLinkOfAnnStorages)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLinkOfAnnStorage_tblAnnouncementStorage");
            });

            modelBuilder.Entity<TblLoginLog>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK_tblLoginHistory");

                entity.ToTable("tblLoginLog");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者Id");

                entity.Property(e => e.CIp)
                    .HasMaxLength(50)
                    .HasColumnName("cIP");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("更新日期");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者Id");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.CUserToken)
                    .HasMaxLength(800)
                    .HasColumnName("cUserToken");
            });

            modelBuilder.Entity<TblMarquee>(entity =>
            {
                entity.HasKey(e => e.CmarqueeId)
                    .HasName("PK__tmp_ms_x__7EF1F954499C7013");

                entity.ToTable("tblMarquee");

                entity.Property(e => e.CmarqueeId).HasColumnName("CMarqueeId");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CnodeMainId).HasColumnName("CNodeMainId");

                entity.Property(e => e.CoffShelfTime)
                    .HasColumnType("datetime")
                    .HasColumnName("COffShelfTime");

                entity.Property(e => e.ConShelfTime)
                    .HasColumnType("datetime")
                    .HasColumnName("COnShelfTime");

                entity.Property(e => e.Corder).HasColumnName("COrder");

                entity.Property(e => e.Cspace)
                    .HasMaxLength(200)
                    .HasColumnName("CSpace");

                entity.Property(e => e.CspaceId).HasColumnName("CSpaceID");

                entity.Property(e => e.Cstatus).HasColumnName("CStatus");

                entity.Property(e => e.Ctemplate)
                    .HasMaxLength(200)
                    .HasColumnName("CTemplate");

                entity.Property(e => e.CtemplateId).HasColumnName("CTemplateId");

                entity.Property(e => e.Ctitle)
                    .HasMaxLength(200)
                    .HasColumnName("CTitle");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.Property(e => e.Curl).HasColumnName("CUrl");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblMarquees)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMarquee_tblBusinessUnit");

                entity.HasOne(d => d.CnodeMain)
                    .WithMany(p => p.TblMarquees)
                    .HasForeignKey(d => d.CnodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMarquee_tblNodeMain");
            });

            modelBuilder.Entity<TblMeet>(entity =>
            {
                entity.HasKey(e => e.CMeetNameId)
                    .HasName("PK__tmp_ms_x__43DF68A1C98336A2");

                entity.ToTable("tblMeet");

                entity.Property(e => e.CMeetNameId)
                    .HasColumnName("cMeetNameID")
                    .HasComment("會議室名稱ID");

                entity.Property(e => e.CConfirm)
                    .HasColumnName("cConfirm")
                    .HasComment("審核");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDeptId)
                    .HasColumnName("cDeptID")
                    .HasComment("使用對象");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CMaxCapacity)
                    .HasColumnName("cMaxCapacity")
                    .HasComment("最大容量");

                entity.Property(e => e.CMeetIllustrate)
                    .HasMaxLength(500)
                    .HasColumnName("cMeetIllustrate")
                    .HasComment("會議室說明");

                entity.Property(e => e.CMeetName)
                    .HasMaxLength(500)
                    .HasColumnName("cMeetName")
                    .HasComment("會議室名稱");

                entity.Property(e => e.CMeetTypeNameId)
                    .HasColumnName("cMeetTypeNameID")
                    .HasComment("會議室類別名稱ID");

                entity.Property(e => e.CPicture)
                    .HasColumnName("cPicture")
                    .HasComment("圖片檔名");

                entity.Property(e => e.CPictureName)
                    .HasMaxLength(500)
                    .HasColumnName("cPictureName")
                    .IsFixedLength()
                    .HasComment("圖片檔名");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblMeets)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMeet_tblDept");

                entity.HasOne(d => d.CMeetTypeName)
                    .WithMany(p => p.TblMeets)
                    .HasForeignKey(d => d.CMeetTypeNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMeet_tblMeetType");
            });

            modelBuilder.Entity<TblMeetType>(entity =>
            {
                entity.HasKey(e => e.CMeetTypeNameId)
                    .HasName("PK__tmp_ms_x__0B4E97F91D89BFE8");

                entity.ToTable("tblMeetType");

                entity.Property(e => e.CMeetTypeNameId)
                    .HasColumnName("cMeetTypeNameID")
                    .HasComment("會議室類別名稱ID");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司流水號");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDeptId)
                    .HasColumnName("cDeptID")
                    .HasComment("使用對象");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CMeetTypeName)
                    .HasMaxLength(500)
                    .HasColumnName("cMeetTypeName")
                    .HasComment("會議室類別名稱");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblMeetTypes)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMeetType_tblBusinessUnit");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblMeetTypes)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMeetType_tblDept");
            });

            modelBuilder.Entity<TblMeeting>(entity =>
            {
                entity.HasKey(e => e.CmeetingId)
                    .HasName("PK__tmp_ms_x__4E9E2B601B3F6FAA");

                entity.ToTable("tblMeeting");

                entity.Property(e => e.CmeetingId).HasColumnName("CMeetingID");

                entity.Property(e => e.CAddress)
                    .HasMaxLength(500)
                    .HasColumnName("cAddress");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CConfirmStatus).HasColumnName("cConfirmStatus");

                entity.Property(e => e.CCycleEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("cCycleEnd");

                entity.Property(e => e.CCycleStart)
                    .HasColumnType("datetime")
                    .HasColumnName("cCycleStart");

                entity.Property(e => e.CDisplay).HasColumnName("cDisplay");

                entity.Property(e => e.CEvery).HasColumnName("cEvery");

                entity.Property(e => e.CFrequency).HasColumnName("cFrequency");

                entity.Property(e => e.CFrequencyType).HasColumnName("cFrequencyType");

                entity.Property(e => e.CFriday)
                    .HasColumnName("cFriday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CInstruction)
                    .HasMaxLength(1000)
                    .HasColumnName("cInstruction")
                    .IsFixedLength();

                entity.Property(e => e.CMonday)
                    .HasColumnName("cMonday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainId");

                entity.Property(e => e.COrdinal).HasColumnName("cOrdinal");

                entity.Property(e => e.CParentId).HasColumnName("cParentID");

                entity.Property(e => e.CReminder).HasColumnName("cReminder");

                entity.Property(e => e.CSaturday)
                    .HasColumnName("cSaturday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CSunday)
                    .HasColumnName("cSunday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CThursday)
                    .HasColumnName("cThursday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CTimeUnit).HasColumnName("cTimeUnit");

                entity.Property(e => e.CTuesday)
                    .HasColumnName("cTuesday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CWednesday)
                    .HasColumnName("cWednesday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CWeek).HasColumnName("cWeek");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CexternalAttendees)
                    .HasMaxLength(100)
                    .HasColumnName("CExternalAttendees");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CisGoogle).HasColumnName("CIsGoogle ");

                entity.Property(e => e.CisOutlook).HasColumnName("CIsOutlook");

                entity.Property(e => e.Cmeeting)
                    .HasMaxLength(500)
                    .HasColumnName("CMeeting");

                entity.Property(e => e.CmeetingBuilderId).HasColumnName("CMeetingBuilderID");

                entity.Property(e => e.CmeetingTimeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("CMeetingTimeEnd");

                entity.Property(e => e.CmeetingTimeStart)
                    .HasColumnType("datetime")
                    .HasColumnName("CMeetingTimeStart");

                entity.Property(e => e.CrecordId).HasColumnName("CRecordID");

                entity.Property(e => e.Csetting).HasColumnName("CSetting");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblMeetings)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMeeting_tblBusinessUnit");
            });

            modelBuilder.Entity<TblMeetingDisplayDept>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__tmp_ms_x__D830D4570F1D60F3");

                entity.ToTable("tblMeetingDisplayDept");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CmeetingId).HasColumnName("CMeetingID");
            });

            modelBuilder.Entity<TblMeetingDisplayObject>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__tmp_ms_x__D830D457B53CE760");

                entity.ToTable("tblMeetingDisplayObject");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CName)
                    .HasMaxLength(500)
                    .HasColumnName("cName");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.CmeetingId).HasColumnName("CMeetingID");

                entity.HasOne(d => d.Cmeeting)
                    .WithMany(p => p.TblMeetingDisplayObjects)
                    .HasForeignKey(d => d.CmeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMeetingDisplayObject_tblMeeting");
            });

            modelBuilder.Entity<TblMeetingMinute>(entity =>
            {
                entity.HasKey(e => e.CmeetingMinutesId)
                    .HasName("PK__tmp_ms_x__5183BE29025D5D17");

                entity.ToTable("tblMeetingMinutes");

                entity.Property(e => e.CmeetingMinutesId).HasColumnName("CMeetingMinutesId");

                entity.Property(e => e.CInstruction).HasColumnName("cInstruction");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CexternalAttendees)
                    .HasMaxLength(100)
                    .HasColumnName("CExternalAttendees");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.Cmeeting)
                    .HasMaxLength(200)
                    .HasColumnName("CMeeting");

                entity.Property(e => e.CmeetingId).HasColumnName("CMeetingID");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.HasOne(d => d.CmeetingNavigation)
                    .WithMany(p => p.TblMeetingMinutes)
                    .HasForeignKey(d => d.CmeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMeetingMinutes_tblMeeting");
            });

            modelBuilder.Entity<TblMeetingRoom>(entity =>
            {
                entity.HasKey(e => e.CmeetingRoom)
                    .HasName("PK__tmp_ms_x__6C4841674A5A99B9");

                entity.ToTable("tblMeetingRoom");

                entity.Property(e => e.CmeetingRoom).HasColumnName("CMeetingRoom");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CmeetingId).HasColumnName("CMeetingID");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.Property(e => e.ResourceName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ResourceNameId).HasColumnName("ResourceNameID");

                entity.HasOne(d => d.Cmeeting)
                    .WithMany(p => p.TblMeetingRooms)
                    .HasForeignKey(d => d.CmeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMeetingRoom_tblMeeting");
            });

            modelBuilder.Entity<TblModelName>(entity =>
            {
                entity.HasKey(e => new { e.CNodeMainId, e.CLanguageId });

                entity.ToTable("tblModelName");

                entity.Property(e => e.CNodeMainId)
                    .HasColumnName("cNodeMainId")
                    .HasComment("節點主表Id");

                entity.Property(e => e.CLanguageId)
                    .HasColumnName("cLanguageId")
                    .HasComment("語系Id");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("新增時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("新增者");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CModelName)
                    .HasMaxLength(100)
                    .HasColumnName("cModelName")
                    .HasComment("前台模組名稱");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CLanguage)
                    .WithMany(p => p.TblModelNames)
                    .HasForeignKey(d => d.CLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModelName_ToTable_1");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblModelNames)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModelName_ToTable");
            });

            modelBuilder.Entity<TblNodeMain>(entity =>
            {
                entity.HasKey(e => e.CNodeMainId)
                    .HasName("PK__tmp_ms_x__AD5FB075403BCC16");

                entity.ToTable("tblNodeMain");

                entity.Property(e => e.CNodeMainId)
                    .HasColumnName("cNodeMainId")
                    .HasComment("節點主表Id");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司ID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CIsComfirm)
                    .HasColumnName("cIsComfirm")
                    .HasComment("文章是否需要審核");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CIsMainfest)
                    .HasColumnName("cIsMainfest")
                    .HasComment("是否顯示在選單");

                entity.Property(e => e.CPages)
                    .HasColumnName("cPages")
                    .HasComment("1.單/2多篇");

                entity.Property(e => e.CParentNodeId)
                    .HasColumnName("cParentNodeId")
                    .HasComment("父結點Id");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態");

                entity.Property(e => e.CTemplateId)
                    .HasColumnName("cTemplateId")
                    .HasComment("版型Id");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.Property(e => e.CUrl)
                    .HasMaxLength(2000)
                    .HasColumnName("cURL");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblNodeMains)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblNodeMain_ToTable");
            });

            modelBuilder.Entity<TblNodeName>(entity =>
            {
                entity.HasKey(e => new { e.CNodeMainId, e.CLanguageId });

                entity.ToTable("tblNodeName");

                entity.Property(e => e.CNodeMainId)
                    .HasColumnName("cNodeMainId")
                    .HasComment("節點主表Id");

                entity.Property(e => e.CLanguageId)
                    .HasColumnName("cLanguageId")
                    .HasComment("語系Id");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CNodeName)
                    .HasMaxLength(100)
                    .HasColumnName("cNodeName")
                    .HasComment("節點名稱");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CLanguage)
                    .WithMany(p => p.TblNodeNames)
                    .HasForeignKey(d => d.CLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblNodeName_ToTable_1");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblNodeNames)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblNodeName_ToTable");
            });

            modelBuilder.Entity<TblOrionPushNotification>(entity =>
            {
                entity.ToTable("tblOrionPushNotification");

                entity.Property(e => e.CContent)
                    .HasMaxLength(200)
                    .HasColumnName("cContent");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CGuestUrl).HasColumnName("cGuestUrl");

                entity.Property(e => e.CImuserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cIMUserID");

                entity.Property(e => e.CSenderUserId).HasColumnName("cSenderUserId");

                entity.Property(e => e.CType).HasColumnName("cType");

                entity.Property(e => e.CUserId).HasColumnName("cUserId");
            });

            modelBuilder.Entity<TblPictureOfAnn>(entity =>
            {
                entity.HasKey(e => e.CPictureOfAnnId)
                    .HasName("PK__tmp_ms_x__BB0C8B8AC5BED8FC");

                entity.ToTable("tblPictureOfAnn");

                entity.Property(e => e.CPictureOfAnnId)
                    .HasColumnName("cPictureOfAnnID")
                    .HasComment("圖片ID");

                entity.Property(e => e.CAnnouncementId)
                    .HasColumnName("cAnnouncementID")
                    .HasComment("公告Id");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("cDescription")
                    .HasComment("圖片描述");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CIsNewPage)
                    .HasColumnName("cIsNewPage")
                    .HasComment("在新視窗開啟");

                entity.Property(e => e.CLinkUrl)
                    .HasColumnName("cLinkUrl")
                    .HasComment("連結");

                entity.Property(e => e.CPictureName)
                    .HasColumnName("cPictureName")
                    .HasComment("圖片名稱");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblPictureOfAnns)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPictureOfAnn_ToTable");
            });

            modelBuilder.Entity<TblPictureOfAnnStorage>(entity =>
            {
                entity.HasKey(e => e.CPictureOfAnnId)
                    .HasName("PK__tmp_ms_x__BB0C8B8AD012138A");

                entity.ToTable("tblPictureOfAnnStorage");

                entity.Property(e => e.CPictureOfAnnId).HasColumnName("cPictureOfAnnID");

                entity.Property(e => e.CAnnouncementId).HasColumnName("cAnnouncementID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("cDescription");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CIsNewPage).HasColumnName("cIsNewPage");

                entity.Property(e => e.CLinkUrl).HasColumnName("cLinkUrl");

                entity.Property(e => e.CPictureName).HasColumnName("cPictureName");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblPictureOfAnnStorages)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPictureOfAnnStorage\r\n    _tblAnnouncementStorage");
            });

            modelBuilder.Entity<TblPushDepOfAnn>(entity =>
            {
                entity.HasKey(e => e.CPushDepOfAnnId)
                    .HasName("PK__tblPushD__AA91B85E6D1D1B6F");

                entity.ToTable("tblPushDepOfAnn");

                entity.Property(e => e.CPushDepOfAnnId)
                    .HasColumnName("cPushDepOfAnnID")
                    .HasComment("公告推播對象Id");

                entity.Property(e => e.CAnnouncementId)
                    .HasColumnName("cAnnouncementID")
                    .HasComment("公告Id");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDeptId)
                    .HasColumnName("cDeptID")
                    .HasComment("部門流水號");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblPushDepOfAnns)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDepOfAnn_ToTable_1");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblPushDepOfAnns)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDepOfAnn_ToTable");
            });

            modelBuilder.Entity<TblPushDepOfAnnStorage>(entity =>
            {
                entity.HasKey(e => e.CPushDepOfAnnId)
                    .HasName("PK__tblPushD__AA91B85EB28A6023");

                entity.ToTable("tblPushDepOfAnnStorage");

                entity.Property(e => e.CPushDepOfAnnId).HasColumnName("cPushDepOfAnnID");

                entity.Property(e => e.CAnnouncementId).HasColumnName("cAnnouncementID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblPushDepOfAnnStorages)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDepOfAnnStorage_tblAnnouncementStorage");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblPushDepOfAnnStorages)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDepOfAnnStorage_tblDept");
            });

            modelBuilder.Entity<TblPushDepOfLink>(entity =>
            {
                entity.HasKey(e => e.CPushDepOfLink)
                    .HasName("PK__tmp_ms_x__4C3C511486C024EC");

                entity.ToTable("tblPushDepOfLink");

                entity.Property(e => e.CPushDepOfLink).HasColumnName("cPushDepOfLink");

                entity.Property(e => e.CAttachmentId).HasColumnName("cAttachmentID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CAttachment)
                    .WithMany(p => p.TblPushDepOfLinks)
                    .HasForeignKey(d => d.CAttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDepOfLink_tblAttachment");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblPushDepOfLinks)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDepOfLink_tblDept");
            });

            modelBuilder.Entity<TblPushDepOfVote>(entity =>
            {
                entity.HasKey(e => e.CpushDepOfVoteId)
                    .HasName("PK__tblPushD__436EE3AE06BF82ED");

                entity.ToTable("tblPushDepOfVote");

                entity.Property(e => e.CpushDepOfVoteId).HasColumnName("CPushDepOfVoteId");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CdeptId).HasColumnName("CDeptId");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.Property(e => e.CvoteId).HasColumnName("CVoteId");

                entity.HasOne(d => d.Cdept)
                    .WithMany(p => p.TblPushDepOfVotes)
                    .HasForeignKey(d => d.CdeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDepOfVote_tblDept");

                entity.HasOne(d => d.Cvote)
                    .WithMany(p => p.TblPushDepOfVotes)
                    .HasForeignKey(d => d.CvoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDepOfVote_tblVote");
            });

            modelBuilder.Entity<TblPushDeptOfAlbum>(entity =>
            {
                entity.ToTable("tblPushDeptOfAlbum");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CalbumId).HasColumnName("CAlbumID");
            });

            modelBuilder.Entity<TblPushDeptOfBanner>(entity =>
            {
                entity.HasKey(e => e.CPushDeptOfBanner);

                entity.ToTable("tblPushDeptOfBanner");

                entity.Property(e => e.CPushDeptOfBanner).HasColumnName("cPushDeptOfBanner");

                entity.Property(e => e.CBannerId).HasColumnName("cBannerID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CBanner)
                    .WithMany(p => p.TblPushDeptOfBanners)
                    .HasForeignKey(d => d.CBannerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDeptOfBanner_tblBanner");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblPushDeptOfBanners)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushDeptOfBanner_tblDept");
            });

            modelBuilder.Entity<TblPushDeptOfFileCenter>(entity =>
            {
                entity.ToTable("tblPushDeptOfFileCenter");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CfolderId).HasColumnName("CFolderID");
            });

            modelBuilder.Entity<TblPushDeptOfGood>(entity =>
            {
                entity.ToTable("tblPushDeptOfGoods");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CDeptName)
                    .HasMaxLength(500)
                    .HasColumnName("cDeptName");

                entity.Property(e => e.CGoodsId).HasColumnName("cGoodsID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");
            });

            modelBuilder.Entity<TblPushDeptOfMeeting>(entity =>
            {
                entity.ToTable("tblPushDeptOfMeeting");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CmeetingId).HasColumnName("CMeetingId");
            });

            modelBuilder.Entity<TblPushNotification>(entity =>
            {
                entity.HasKey(e => e.CpushNotification);

                entity.ToTable("tblPushNotification");

                entity.Property(e => e.CpushNotification).HasColumnName("CPushNotification");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.Caccount)
                    .HasMaxLength(200)
                    .HasColumnName("CAccount");

                entity.Property(e => e.CcalendarType).HasColumnName("CCalendarType");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CisRead).HasColumnName("CIsRead");

                entity.Property(e => e.CpushTakerId).HasColumnName("CPushTakerID");

                entity.Property(e => e.CspaceId)
                    .HasColumnName("CSpaceID")
                    .HasComment("資料源標題ID");

                entity.Property(e => e.CtemplateId).HasColumnName("CTemplateId");

                entity.Property(e => e.Ctype)
                    .HasColumnName("CType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblPushNotifications)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushNotification_tblBusinessUnit");

                entity.HasOne(d => d.CUser)
                    .WithMany(p => p.TblPushNotifications)
                    .HasForeignKey(d => d.CUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPushNotification_tblPushNotification");
            });

            modelBuilder.Entity<TblPushOfBanner>(entity =>
            {
                entity.HasKey(e => e.CDeptId)
                    .HasName("PK_tblPushOfAttachment");

                entity.ToTable("tblPushOfBanner");

                entity.Property(e => e.CDeptId)
                    .ValueGeneratedNever()
                    .HasColumnName("cDeptID");

                entity.Property(e => e.CBannerId).HasColumnName("cBannerID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptName)
                    .HasMaxLength(100)
                    .HasColumnName("cDeptName")
                    .IsFixedLength();

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");
            });

            modelBuilder.Entity<TblQuestion>(entity =>
            {
                entity.HasKey(e => e.CselectionId);

                entity.ToTable("tblQuestion");

                entity.Property(e => e.CselectionId).HasColumnName("CSelectionId");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CquestionId).HasColumnName("CQuestionId");

                entity.Property(e => e.Cselection)
                    .HasMaxLength(100)
                    .HasColumnName("CSelection");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.Property(e => e.CvoteTypeId).HasColumnName("CVoteTypeId");

                entity.HasOne(d => d.Cquestion)
                    .WithMany(p => p.TblQuestions)
                    .HasForeignKey(d => d.CquestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblQuestion_tblVoteType");
            });

            modelBuilder.Entity<TblReminder>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("tblReminder");

                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.Caccount)
                    .HasMaxLength(200)
                    .HasColumnName("CAccount");

                entity.Property(e => e.CcalendarType).HasColumnName("CCalendarType");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CisRead).HasColumnName("CIsRead");

                entity.Property(e => e.CisRemind).HasColumnName("CIsRemind");

                entity.Property(e => e.CpushTakerId).HasColumnName("CPushTakerID");

                entity.Property(e => e.CspaceId).HasColumnName("CSpaceID");

                entity.Property(e => e.CtemplateId).HasColumnName("CTemplateId");

                entity.Property(e => e.Ctime)
                    .HasColumnType("datetime")
                    .HasColumnName("CTime");

                entity.Property(e => e.Ctype)
                    .HasColumnName("CType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");
            });

            modelBuilder.Entity<TblResource>(entity =>
            {
                entity.HasKey(e => e.CResourceNameId)
                    .HasName("PK__tmp_ms_x__3FEFD02E84F3BE7E");

                entity.ToTable("tblResource");

                entity.Property(e => e.CResourceNameId).HasColumnName("cResourceNameID");

                entity.Property(e => e.CConfirm).HasColumnName("cConfirm");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIllustrate)
                    .HasMaxLength(1000)
                    .HasColumnName("cIllustrate");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CPicture).HasColumnName("cPicture");

                entity.Property(e => e.CPictureName)
                    .HasMaxLength(1000)
                    .HasColumnName("cPictureName");

                entity.Property(e => e.CResourceName)
                    .HasMaxLength(500)
                    .HasColumnName("cResourceName");

                entity.Property(e => e.CResourceTypeNameId).HasColumnName("cResourceTypeNameID");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblResources)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResource_tblDept");

                entity.HasOne(d => d.CResourceTypeName)
                    .WithMany(p => p.TblResources)
                    .HasForeignKey(d => d.CResourceTypeNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResource_tblResourceType");
            });

            modelBuilder.Entity<TblResourceBorrowList>(entity =>
            {
                entity.HasKey(e => e.CBorrowListId);

                entity.ToTable("tblResourceBorrowList");

                entity.Property(e => e.CBorrowListId).HasColumnName("cBorrowListID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CResourceAppointId).HasColumnName("cResourceAppointID");

                entity.Property(e => e.CResourceName)
                    .HasMaxLength(500)
                    .HasColumnName("cResourceName");

                entity.Property(e => e.CResourceNameId).HasColumnName("cResourceNameID");

                entity.Property(e => e.CTypeId).HasColumnName("cTypeID");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");
            });

            modelBuilder.Entity<TblResourceFront>(entity =>
            {
                entity.HasKey(e => e.CResourceAppointId)
                    .HasName("PK__tmp_ms_x__B61F0E15D68C305B");

                entity.ToTable("tblResourceFront");

                entity.Property(e => e.CResourceAppointId)
                    .HasColumnName("cResourceAppointID")
                    .HasComment("資源預約ID");

                entity.Property(e => e.CAddress)
                    .HasMaxLength(500)
                    .HasColumnName("cAddress");

                entity.Property(e => e.CBorrowTimeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("cBorrowTimeEnd")
                    .HasComment("借用時間迄");

                entity.Property(e => e.CBorrowTimeStart)
                    .HasColumnType("datetime")
                    .HasColumnName("cBorrowTimeStart")
                    .HasComment("借用時間起");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CConfirmStatus)
                    .HasColumnName("cConfirmStatus")
                    .HasComment("審核");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CCycleEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("cCycleEnd");

                entity.Property(e => e.CCycleStart)
                    .HasColumnType("datetime")
                    .HasColumnName("cCycleStart");

                entity.Property(e => e.CDeptId)
                    .HasColumnName("cDeptID")
                    .HasComment("部門ID");

                entity.Property(e => e.CEvery).HasColumnName("cEvery");

                entity.Property(e => e.CFrequency).HasColumnName("cFrequency");

                entity.Property(e => e.CFrequencyType).HasColumnName("cFrequencyType");

                entity.Property(e => e.CFriday)
                    .HasColumnName("cFriday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CKeyword)
                    .HasMaxLength(500)
                    .HasColumnName("cKeyword")
                    .HasComment("關鍵字");

                entity.Property(e => e.CMonday)
                    .HasColumnName("cMonday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainId");

                entity.Property(e => e.COrdinal).HasColumnName("cOrdinal");

                entity.Property(e => e.CParentId).HasColumnName("cParentID");

                entity.Property(e => e.CReminder).HasColumnName("cReminder");

                entity.Property(e => e.CResourceInstruction)
                    .HasMaxLength(500)
                    .HasColumnName("cResourceInstruction")
                    .HasComment("使用說明");

                entity.Property(e => e.CSaturday)
                    .HasColumnName("cSaturday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CSunday)
                    .HasColumnName("cSunday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CThursday)
                    .HasColumnName("cThursday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CTimeUnit).HasColumnName("cTimeUnit");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(500)
                    .HasColumnName("cTitle")
                    .HasComment("標題");

                entity.Property(e => e.CTuesday)
                    .HasColumnName("cTuesday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.Property(e => e.CUserId)
                    .HasColumnName("cUserID")
                    .HasComment("預約者");

                entity.Property(e => e.CWednesday)
                    .HasColumnName("cWednesday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CWeek).HasColumnName("cWeek");

                entity.Property(e => e.CisGoogle)
                    .HasColumnName("CIsGoogle ")
                    .HasComment("是否串Google");

                entity.Property(e => e.CisOutlook)
                    .HasColumnName("CIsOutlook")
                    .HasComment("是否串Outlook");

                entity.Property(e => e.Csetting)
                    .HasColumnName("CSetting")
                    .HasComment("顯示設定");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblResourceFronts)
                    .HasForeignKey(d => d.CBuId)
                    .HasConstraintName("FK_tblResourceFront_tblBusinessUnit");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblResourceFronts)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceFront_tblDept");

                entity.HasOne(d => d.CUser)
                    .WithMany(p => p.TblResourceFronts)
                    .HasForeignKey(d => d.CUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceFront_tblUser");
            });

            modelBuilder.Entity<TblResourceKeeper>(entity =>
            {
                entity.HasKey(e => new { e.CResourceNameId, e.CUserId });

                entity.ToTable("tblResourceKeeper");

                entity.Property(e => e.CResourceNameId)
                    .HasColumnName("cResourceNameID")
                    .HasComment("資源名稱");

                entity.Property(e => e.CUserId)
                    .HasColumnName("cUserID")
                    .HasComment("使用者ID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CResourceTypeNameId)
                    .HasColumnName("cResourceTypeNameID")
                    .HasComment("資源類別名稱ID");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CResourceName)
                    .WithMany(p => p.TblResourceKeepers)
                    .HasForeignKey(d => d.CResourceNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceKeeper_tblResource");

                entity.HasOne(d => d.CResourceTypeName)
                    .WithMany(p => p.TblResourceKeepers)
                    .HasForeignKey(d => d.CResourceTypeNameId)
                    .HasConstraintName("FK_tblResourceKeeper_tblResourceType");
            });

            modelBuilder.Entity<TblResourceType>(entity =>
            {
                entity.HasKey(e => e.CResourceTypeNameId)
                    .HasName("PK__tmp_ms_x__17D324660CC5C005");

                entity.ToTable("tblResourceType");

                entity.Property(e => e.CResourceTypeNameId).HasColumnName("cResourceTypeNameID");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CResourceTypeName)
                    .HasMaxLength(500)
                    .HasColumnName("cResourceTypeName");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");

                entity.Property(e => e.CTypeId).HasColumnName("cTypeID");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblResourceTypes)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceType_tblBusinessUnit");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblResourceTypes)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceType_tblDept");
            });

            modelBuilder.Entity<TblResourceTypeUser>(entity =>
            {
                entity.HasKey(e => e.CResourceTypeUserId)
                    .HasName("PK__tblResou__1A42C54EE73A4E13");

                entity.ToTable("tblResourceTypeUser");

                entity.Property(e => e.CResourceTypeUserId).HasColumnName("cResourceTypeUserID ");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CResourceTypeNameId).HasColumnName("cResourceTypeNameID");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblResourceTypeUsers)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceTypeUser_tblDept");

                entity.HasOne(d => d.CResourceTypeName)
                    .WithMany(p => p.TblResourceTypeUsers)
                    .HasForeignKey(d => d.CResourceTypeNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceTypeUser_tblResourceType");
            });

            modelBuilder.Entity<TblResourceUser>(entity =>
            {
                entity.HasKey(e => e.CResourceUserId)
                    .HasName("PK__tblResou__34E631E4238B6BD1");

                entity.ToTable("tblResourceUser");

                entity.Property(e => e.CResourceUserId).HasColumnName("cResourceUserID ");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDeptId).HasColumnName("cDeptID");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CResourceNameId).HasColumnName("cResourceNameID");

                entity.Property(e => e.CResourceTypeNameId).HasColumnName("cResourceTypeNameID");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblResourceUsers)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceUser_tblDept");

                entity.HasOne(d => d.CResourceName)
                    .WithMany(p => p.TblResourceUsers)
                    .HasForeignKey(d => d.CResourceNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResourceUser_tblResource");
            });

            modelBuilder.Entity<TblSaveConfirmOfAnn>(entity =>
            {
                entity.HasKey(e => e.CConfirmOfAnnId)
                    .HasName("PK__tmp_ms_x__3BE4B1E9000ABAF9");

                entity.ToTable("tblSaveConfirmOfAnn");

                entity.Property(e => e.CConfirmOfAnnId).HasColumnName("cConfirmOfAnnID");

                entity.Property(e => e.CAnnouncementId).HasColumnName("cAnnouncementID");

                entity.Property(e => e.CConfirmStatus).HasColumnName("cConfirmStatus");

                entity.Property(e => e.CConfirmTime)
                    .HasColumnType("datetime")
                    .HasColumnName("cConfirmTime");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(1000)
                    .HasColumnName("cRemark");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblSaveConfirmOfAnns)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSaveConfirmOfAnn_tblAnnouncement");

                entity.HasOne(d => d.CUser)
                    .WithMany(p => p.TblSaveConfirmOfAnns)
                    .HasForeignKey(d => d.CUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSaveConfirmOfAnn_tblUser");
            });

            modelBuilder.Entity<TblSaveConfirmOfGood>(entity =>
            {
                entity.HasKey(e => e.CconfirmOfGoodsId)
                    .HasName("PK__tmp_ms_x__D74A47EB5428D77C");

                entity.ToTable("tblSaveConfirmOfGoods");

                entity.Property(e => e.CconfirmOfGoodsId).HasColumnName("CConfirmOfGoodsID");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(1000)
                    .HasColumnName("cRemark");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CconfirmStatus).HasColumnName("CConfirmStatus");

                entity.Property(e => e.CdeptId).HasColumnName("CDeptID");

                entity.Property(e => e.CgoodsFrontId).HasColumnName("CGoodsFrontID");

                entity.Property(e => e.CuserId).HasColumnName("CUserID");
            });

            modelBuilder.Entity<TblSaveConfirmOfResource>(entity =>
            {
                entity.HasKey(e => e.CConfirmOfResourceId)
                    .HasName("PK__tmp_ms_x__6C00FE96A15E0130");

                entity.ToTable("tblSaveConfirmOfResource");

                entity.Property(e => e.CConfirmOfResourceId).HasColumnName("cConfirmOfResourceID");

                entity.Property(e => e.CBorrowListId).HasColumnName("cBorrowListID");

                entity.Property(e => e.CBuId).HasColumnName("cBuID");

                entity.Property(e => e.CCalendarId).HasColumnName("cCalendarID");

                entity.Property(e => e.CCalendarType).HasColumnName("cCalendarType");

                entity.Property(e => e.CConfirmStatus).HasColumnName("cConfirmStatus");

                entity.Property(e => e.CConfirmTime)
                    .HasColumnType("datetime")
                    .HasColumnName("cConfirmTime");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(1000)
                    .HasColumnName("cRemark");

                entity.Property(e => e.CResourceAppointId).HasColumnName("cResourceAppointID");

                entity.Property(e => e.CType)
                    .HasColumnName("cType")
                    .HasComment("1=會議室 2=資源");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.CmeetingId).HasColumnName("CMeetingID");

                entity.HasOne(d => d.CBorrowList)
                    .WithMany(p => p.TblSaveConfirmOfResources)
                    .HasForeignKey(d => d.CBorrowListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSaveConfirmOfResource_tblSaveConfirmOfResource");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblSaveConfirmOfResources)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSaveConfirmOfResource_tblBusinessUnit");

                entity.HasOne(d => d.CResourceAppoint)
                    .WithMany(p => p.TblSaveConfirmOfResources)
                    .HasForeignKey(d => d.CResourceAppointId)
                    .HasConstraintName("FK_tblSaveConfirmOfResource_tblResourceFront");

                entity.HasOne(d => d.CUser)
                    .WithMany(p => p.TblSaveConfirmOfResources)
                    .HasForeignKey(d => d.CUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSaveConfirmOfResource_tblUser");
            });

            modelBuilder.Entity<TblSelection>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__tmp_ms_x__C1F8DC39BC74BFA0");

                entity.ToTable("tblSelection");

                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CanswerId).HasColumnName("CAnswerId");

                entity.Property(e => e.CisCheck).HasColumnName("CIsCheck");

                entity.Property(e => e.CselectionId).HasColumnName("CSelectionId");

                entity.HasOne(d => d.Canswer)
                    .WithMany(p => p.TblSelections)
                    .HasForeignKey(d => d.CanswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSelection_tblAnswer");

                entity.HasOne(d => d.Cselection)
                    .WithMany(p => p.TblSelections)
                    .HasForeignKey(d => d.CselectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSelection[tblQuestion");
            });

            modelBuilder.Entity<TblSso>(entity =>
            {
                entity.ToTable("tblSSO");

                entity.Property(e => e.CDueDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cDueDT");

                entity.Property(e => e.CToken)
                    .HasMaxLength(50)
                    .HasColumnName("cToken");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");
            });

            modelBuilder.Entity<TblTemplate>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__tmp_ms_x__D830D4772F6C5B55");

                entity.ToTable("tblTemplate");

                entity.Property(e => e.CId).HasColumnName("cId");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("新增時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("新增者");

                entity.Property(e => e.CIcon)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cIcon");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CLanguageId).HasColumnName("cLanguageID");

                entity.Property(e => e.CPageUrl)
                    .HasMaxLength(500)
                    .HasColumnName("cPageUrl");

                entity.Property(e => e.CTemplateId)
                    .HasColumnName("cTemplateId")
                    .HasComment("版型Id");

                entity.Property(e => e.CTemplateName)
                    .HasMaxLength(50)
                    .HasColumnName("cTemplateName")
                    .HasComment("版型名稱");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<TblUploadPicture>(entity =>
            {
                entity.ToTable("tblUploadPicture");

                entity.Property(e => e.CalbumId).HasColumnName("CAlbumID");

                entity.Property(e => e.Cdescription).HasColumnName("CDescription");

                entity.Property(e => e.CfileName)
                    .HasMaxLength(2000)
                    .HasColumnName("CFileName");

                entity.Property(e => e.CisCover).HasColumnName("CIsCover");
            });

            modelBuilder.Entity<TblUploadVideo>(entity =>
            {
                entity.ToTable("tblUploadVideo");

                entity.Property(e => e.CalbumId).HasColumnName("CAlbumID");

                entity.Property(e => e.Cdescription).HasColumnName("CDescription");

                entity.Property(e => e.CfileName)
                    .HasMaxLength(2000)
                    .HasColumnName("CFileName");

                entity.Property(e => e.Curl)
                    .HasMaxLength(2000)
                    .HasColumnName("CUrl");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.CUserId);

                entity.ToTable("tblUser");

                entity.HasComment("使用者");

                entity.Property(e => e.CUserId)
                    .HasColumnName("cUserID")
                    .HasComment("使用者編號");

                entity.Property(e => e.CAccount)
                    .HasMaxLength(100)
                    .HasColumnName("cAccount")
                    .HasComment("cAccount、cAccount2都不可重複");

                entity.Property(e => e.CAdminStatus)
                    .HasColumnName("cAdminStatus")
                    .HasComment("狀態 0:停用 1:啟用(後臺狀態)");

                entity.Property(e => e.CAgentUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cAgentUnit")
                    .HasComment("代理單位");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("BU");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDeptId)
                    .HasColumnName("cDeptID")
                    .HasComment("部門流水號");

                entity.Property(e => e.CGoogleId)
                    .HasMaxLength(100)
                    .HasColumnName("cGoogleID");

                entity.Property(e => e.CIsChangePassword).HasColumnName("cIsChangePassword");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("緩刪除(0:未刪除, 1:已刪除)");

                entity.Property(e => e.CIsDeptManager)
                    .HasColumnName("cIsDeptManager")
                    .HasComment("是否為單位最高權限(0:否, 1:是)");

                entity.Property(e => e.CIsFront)
                    .HasColumnName("cIsFront")
                    .HasComment("是否為前台");

                entity.Property(e => e.CIsMainTitle)
                    .HasColumnName("cIsMainTitle ")
                    .HasComment("是否為主要職稱(0:否, 1:是)");

                entity.Property(e => e.CJobTitle)
                    .HasMaxLength(500)
                    .HasColumnName("cJobTitle")
                    .HasComment("職稱");

                entity.Property(e => e.CLanguageId)
                    .HasColumnName("cLanguageId")
                    .HasComment("語系");

                entity.Property(e => e.CMail)
                    .HasMaxLength(1000)
                    .HasColumnName("cMail")
                    .HasComment("信箱");

                entity.Property(e => e.COutlookId)
                    .HasMaxLength(100)
                    .HasColumnName("cOutlookID");

                entity.Property(e => e.CPassword)
                    .HasMaxLength(500)
                    .HasColumnName("cPassword")
                    .HasComment("密碼");

                entity.Property(e => e.CPicture)
                    .HasMaxLength(500)
                    .HasColumnName("cPicture")
                    .HasComment("頭貼");

                entity.Property(e => e.CSessionId)
                    .HasMaxLength(100)
                    .HasColumnName("cSessionID");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態 0:停用 1:啟用(前台狀態)");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("更新日期時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.Property(e => e.CUserName)
                    .HasMaxLength(500)
                    .HasColumnName("cUserName")
                    .HasComment("使用者名稱");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUser_tblBusinessUnit");

                entity.HasOne(d => d.CDept)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.CDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUser_tblDept");

                entity.HasOne(d => d.CLanguage)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.CLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUser_tblLanguage");
            });

            modelBuilder.Entity<TblUserGroup>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblUserGroup");

                entity.HasComment("使用者群組");

                entity.Property(e => e.CId)
                    .HasColumnName("cID")
                    .HasComment("使用者群組編號");

                entity.Property(e => e.CBuid).HasColumnName("cBUID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CName)
                    .HasMaxLength(100)
                    .HasColumnName("cName")
                    .HasComment("群組名稱");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態(0:停用, 1:啟用)");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("更新日期時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<TblUserOnGroup>(entity =>
            {
                entity.HasKey(e => new { e.CUserId, e.CUserGroupId });

                entity.ToTable("tblUserOnGroup");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.CUserGroupId).HasColumnName("cUserGroupID");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");
            });

            modelBuilder.Entity<TblVideoOfAnn>(entity =>
            {
                entity.HasKey(e => e.CVideoOfAnnId)
                    .HasName("PK__tmp_ms_x__783BACCD7A697905");

                entity.ToTable("tblVideoOfAnn");

                entity.Property(e => e.CVideoOfAnnId)
                    .HasColumnName("cVideoOfAnnID")
                    .HasComment("影片ID");

                entity.Property(e => e.CAnnouncementId)
                    .HasColumnName("cAnnouncementID")
                    .HasComment("公告Id");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("cDescription")
                    .HasComment("影片描述");

                entity.Property(e => e.CFileName)
                    .HasMaxLength(500)
                    .HasColumnName("cFileName")
                    .HasComment("檔案名稱");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(200)
                    .HasColumnName("cTitle")
                    .HasComment("影片標題");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.Property(e => e.CUrl)
                    .HasColumnName("cURL")
                    .HasComment("影片網址");

                entity.Property(e => e.CVideoName)
                    .HasMaxLength(100)
                    .HasColumnName("cVideoName")
                    .HasComment("影片檔名");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblVideoOfAnns)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVideoOfAnn_ToTable");
            });

            modelBuilder.Entity<TblVideoOfAnnStorage>(entity =>
            {
                entity.HasKey(e => e.CVideoOfAnnId)
                    .HasName("PK__tmp_ms_x__783BACCD3743CDD3");

                entity.ToTable("tblVideoOfAnnStorage");

                entity.Property(e => e.CVideoOfAnnId).HasColumnName("cVideoOfAnnID");

                entity.Property(e => e.CAnnouncementId).HasColumnName("cAnnouncementID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("cDescription");

                entity.Property(e => e.CFileName)
                    .HasMaxLength(500)
                    .HasColumnName("cFileName");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(200)
                    .HasColumnName("cTitle");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUrl).HasColumnName("cURL");

                entity.Property(e => e.CVideoName)
                    .HasMaxLength(100)
                    .HasColumnName("cVideoName");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblVideoOfAnnStorages)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVideoOfAnnStorage_tblAnnouncementStorage");
            });

            modelBuilder.Entity<TblViewLogOfAnn>(entity =>
            {
                entity.HasKey(e => e.CViewLogOfAnnId)
                    .HasName("PK__tblViewL__3E59D0D2C663A2F0");

                entity.ToTable("tblViewLogOfAnn");

                entity.Property(e => e.CViewLogOfAnnId)
                    .HasColumnName("cViewLogOfAnnID")
                    .HasComment("公告瀏覽紀錄Id");

                entity.Property(e => e.CAnnouncementId)
                    .HasColumnName("cAnnouncementID")
                    .HasComment("公告Id");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.HasOne(d => d.CAnnouncement)
                    .WithMany(p => p.TblViewLogOfAnns)
                    .HasForeignKey(d => d.CAnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblViewLogOfAnn_ToTable");
            });

            modelBuilder.Entity<TblVote>(entity =>
            {
                entity.HasKey(e => e.CvoteId);

                entity.ToTable("tblVote");

                entity.Property(e => e.CvoteId)
                    .HasColumnName("CVoteID")
                    .HasComment("投票問卷ID");

                entity.Property(e => e.CBuId)
                    .HasColumnName("cBuID")
                    .HasComment("公司流水號");

                entity.Property(e => e.CNodeMainId).HasColumnName("cNodeMainId");

                entity.Property(e => e.CchoiceLimit).HasColumnName("CChoiceLimit");

                entity.Property(e => e.Ccontent)
                    .HasColumnName("CContent")
                    .HasComment("投票問卷內容");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT")
                    .HasComment("建立時間");

                entity.Property(e => e.Ccreator)
                    .HasColumnName("CCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CdeptId)
                    .HasColumnName("CDeptId")
                    .HasComment("發布單位");

                entity.Property(e => e.CisAnonymous)
                    .HasColumnName("CIsAnonymous")
                    .HasComment("匿名");

                entity.Property(e => e.CisAppear)
                    .HasColumnName("CIsAppear")
                    .HasComment("是否呈現前台");

                entity.Property(e => e.CisDelete)
                    .HasColumnName("CIsDelete")
                    .HasComment("是否刪除");

                entity.Property(e => e.CisPush)
                    .HasColumnName("CIsPush")
                    .HasComment("是否推播");

                entity.Property(e => e.CisSingleChoice).HasColumnName("CIsSingleChoice");

                entity.Property(e => e.CisTop)
                    .HasColumnName("CIsTop")
                    .HasComment("置頂");

                entity.Property(e => e.Clinks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLinks")
                    .HasComment("友善網址");

                entity.Property(e => e.CoffShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("COffShelfDate")
                    .HasComment("下架時間");

                entity.Property(e => e.ConShelfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("COnShelfDate")
                    .HasComment("上架時間");

                entity.Property(e => e.Cresponse)
                    .HasColumnName("CResponse")
                    .HasComment("回覆數");

                entity.Property(e => e.Cstatus)
                    .HasColumnName("CStatus")
                    .HasComment("狀態");

                entity.Property(e => e.Ctitle)
                    .HasMaxLength(200)
                    .HasColumnName("CTitle")
                    .HasComment("標題");

                entity.Property(e => e.CtypeId)
                    .HasColumnName("CTypeId")
                    .HasComment("類別ID");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT")
                    .HasComment("更新時間");

                entity.Property(e => e.Cupdator)
                    .HasColumnName("CUpdator")
                    .HasComment("更新者");

                entity.Property(e => e.Curl)
                    .HasMaxLength(1000)
                    .HasColumnName("CUrl")
                    .HasComment("URL");

                entity.Property(e => e.Cvisit)
                    .HasColumnName("CVisit")
                    .HasComment("造訪數");

                entity.HasOne(d => d.CBu)
                    .WithMany(p => p.TblVotes)
                    .HasForeignKey(d => d.CBuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVote_tblBusinessUnit");

                entity.HasOne(d => d.CNodeMain)
                    .WithMany(p => p.TblVotes)
                    .HasForeignKey(d => d.CNodeMainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVote_tblNodeMain");
            });

            modelBuilder.Entity<TblVoteFront>(entity =>
            {
                entity.HasKey(e => e.CvoteFrontId);

                entity.ToTable("tblVoteFront");

                entity.Property(e => e.CvoteFrontId).HasColumnName("CVoteFrontId");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CIsDelete).HasColumnName("cIsDelete");

                entity.Property(e => e.CUpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdatedDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CvoteId).HasColumnName("CVoteId");

                entity.HasOne(d => d.Cvote)
                    .WithMany(p => p.TblVoteFronts)
                    .HasForeignKey(d => d.CvoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVoteFront_tblVote");
            });

            modelBuilder.Entity<TblVoteType>(entity =>
            {
                entity.HasKey(e => e.CquestionId)
                    .HasName("PK__tmp_ms_x__5267316B02624756");

                entity.ToTable("tblVoteType");

                entity.Property(e => e.CquestionId).HasColumnName("CQuestionId");

                entity.Property(e => e.CcreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CCreateDT");

                entity.Property(e => e.Ccreator).HasColumnName("CCreator");

                entity.Property(e => e.CisDelete).HasColumnName("CIsDelete");

                entity.Property(e => e.Climit).HasColumnName("CLimit");

                entity.Property(e => e.Corder).HasColumnName("COrder");

                entity.Property(e => e.Cquestion)
                    .HasMaxLength(1000)
                    .HasColumnName("CQuestion");

                entity.Property(e => e.Cremark)
                    .HasMaxLength(1000)
                    .HasColumnName("CRemark");

                entity.Property(e => e.Crequired).HasColumnName("CRequired");

                entity.Property(e => e.CupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CUpdatedDT");

                entity.Property(e => e.Cupdator).HasColumnName("CUpdator");

                entity.Property(e => e.CuploadPic)
                    .HasMaxLength(1000)
                    .HasColumnName("CUploadPic");

                entity.Property(e => e.CuploadVideo)
                    .HasMaxLength(1000)
                    .HasColumnName("CUploadVideo");

                entity.Property(e => e.CvoteId).HasColumnName("CVoteId");

                entity.Property(e => e.CvoteTypeId).HasColumnName("CVoteTypeId");

                entity.HasOne(d => d.Cvote)
                    .WithMany(p => p.TblVoteTypes)
                    .HasForeignKey(d => d.CvoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVoteType_tblVote");
            });

            modelBuilder.HasSequence("TemplateSeq").StartsAt(5001);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoderFirst.DataAccess.Migrations
{
    public partial class migg333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Images = table.Column<string>(type: "longtext", nullable: true),
                    PostContent = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Message = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "EmailList",
                columns: table => new
                {
                    EmailListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EmailListName = table.Column<string>(type: "longtext", nullable: true),
                    LastSentOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailList", x => x.EmailListId);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    EmailTemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FromEmail = table.Column<string>(type: "longtext", nullable: true),
                    FromName = table.Column<string>(type: "longtext", nullable: true),
                    HtmlTemplate = table.Column<string>(type: "longtext", nullable: true),
                    Subject = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.EmailTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "EmailUnsubscription",
                columns: table => new
                {
                    EmailUnsubscriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    MemberToken = table.Column<string>(type: "longtext", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailUnsubscription", x => x.EmailUnsubscriptionId);
                });

            migrationBuilder.CreateTable(
                name: "InvalidEmail",
                columns: table => new
                {
                    InvalidEmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvalidEmail", x => x.InvalidEmailId);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    LikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActionedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    LikeType = table.Column<int>(type: "int", nullable: false),
                    LikeTypeId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.LikeId);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Bio = table.Column<string>(type: "longtext", nullable: true),
                    CompanyName = table.Column<string>(type: "longtext", nullable: true),
                    DeactivatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    ExperienceLevel = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "longtext", nullable: true),
                    IsDeactivated = table.Column<bool>(type: "bit", nullable: false),
                    IsMemberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsTopMember = table.Column<bool>(type: "bit", nullable: false),
                    JobTitle = table.Column<string>(type: "longtext", nullable: true),
                    LastName = table.Column<string>(type: "longtext", nullable: true),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    MemberGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MobileNo = table.Column<string>(type: "longtext", nullable: true),
                    NewEmailChangeRequest = table.Column<string>(type: "longtext", nullable: true),
                    PasswordToken = table.Column<string>(type: "longtext", nullable: true),
                    PhotoUrl = table.Column<string>(type: "longtext", nullable: true),
                    ProfileView = table.Column<int>(type: "int", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SkillTag = table.Column<string>(type: "longtext", nullable: true),
                    Token = table.Column<string>(type: "longtext", nullable: true),
                    UserName = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "SkillTag",
                columns: table => new
                {
                    SkillTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTag", x => x.SkillTagId);
                });

            migrationBuilder.CreateTable(
                name: "TopicTag",
                columns: table => new
                {
                    TopicTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicTag", x => x.TopicTagId);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddress",
                columns: table => new
                {
                    EmailAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EmailAdress = table.Column<string>(type: "longtext", nullable: true),
                    EmailListId = table.Column<int>(type: "int", nullable: false),
                    EmailTemplateId = table.Column<int>(type: "int", nullable: true),
                    IsBounced = table.Column<bool>(type: "bit", nullable: true),
                    JobTitle = table.Column<string>(type: "longtext", nullable: true),
                    LastSentOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    MobileNo = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Stopped = table.Column<bool>(type: "bit", nullable: true),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddress", x => x.EmailAddressId);
                    table.ForeignKey(
                        name: "FK_EmailAddress_EmailList_EmailListId",
                        column: x => x.EmailListId,
                        principalTable: "EmailList",
                        principalColumn: "EmailListId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAddress_EmailTemplate_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplate",
                        principalColumn: "EmailTemplateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AboutCompany = table.Column<string>(type: "longtext", nullable: true),
                    ApplyEmailAddress = table.Column<string>(type: "longtext", nullable: true),
                    ApplyUrl = table.Column<string>(type: "longtext", nullable: true),
                    ClosingOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CompanyLogo = table.Column<string>(type: "longtext", nullable: true),
                    CompanyName = table.Column<string>(type: "longtext", nullable: true),
                    CouponCode = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CustomOrder = table.Column<int>(type: "int", nullable: true),
                    DeliverInbox = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    DescriptionImageUrl = table.Column<string>(type: "longtext", nullable: true),
                    ExperienceLeavel = table.Column<int>(type: "int", nullable: false),
                    FriendlyUrl = table.Column<string>(type: "longtext", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsReviewed = table.Column<bool>(type: "bit", nullable: false),
                    JobGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    JobStatus = table.Column<int>(type: "int", nullable: false),
                    JobSummary = table.Column<string>(type: "longtext", nullable: true),
                    JobTitle = table.Column<string>(type: "longtext", nullable: true),
                    JobType = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "longtext", nullable: true),
                    MemberGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    PublishOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    SendJobStats = table.Column<bool>(type: "bit", nullable: false),
                    ShowRecruiterMessage = table.Column<bool>(type: "bit", nullable: false),
                    SkillTag = table.Column<string>(type: "longtext", nullable: true),
                    TotalApplication = table.Column<int>(type: "int", nullable: false),
                    TotalExperince = table.Column<int>(type: "int", nullable: false),
                    Totalview = table.Column<int>(type: "int", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Job_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meetup",
                columns: table => new
                {
                    MeetupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    FriendlyUrl = table.Column<string>(type: "longtext", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GooleMapUrl = table.Column<string>(type: "longtext", nullable: true),
                    InterestedGroup = table.Column<string>(type: "longtext", nullable: true),
                    Location = table.Column<string>(type: "longtext", nullable: true),
                    MaxParticipant = table.Column<int>(type: "int", nullable: false),
                    MeetupGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MeetupStatus = table.Column<int>(type: "int", nullable: false),
                    MeetupTitle = table.Column<string>(type: "longtext", nullable: true),
                    MemberGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    PublishOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalParticipant = table.Column<int>(type: "int", nullable: false),
                    Totalview = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetup", x => x.MeetupId);
                    table.ForeignKey(
                        name: "FK_Meetup_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: true),
                    CanLoadInIFrame = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    FriendlyUrl = table.Column<string>(type: "longtext", nullable: true),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: true),
                    IsPublicPost = table.Column<bool>(type: "bit", nullable: false),
                    KeyTech = table.Column<string>(type: "longtext", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MemberGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    MemberName = table.Column<string>(type: "longtext", nullable: true),
                    PostGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    PostImageHeight = table.Column<int>(type: "int", nullable: false),
                    PostImagePosition = table.Column<int>(type: "int", nullable: false),
                    PostImageWidth = table.Column<int>(type: "int", nullable: false),
                    PostStatus = table.Column<int>(type: "int", nullable: false),
                    PostTags = table.Column<string>(type: "longtext", nullable: true),
                    PostType = table.Column<int>(type: "int", nullable: false),
                    PostUrl = table.Column<string>(type: "longtext", nullable: true),
                    PublishedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RealView = table.Column<int>(type: "int", nullable: true),
                    SendPostStats = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: true),
                    TotalLike = table.Column<int>(type: "int", nullable: false),
                    TotalView = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true),
                    VideoEmbed = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_Blog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blog",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialContact",
                columns: table => new
                {
                    SocialContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ContactType = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    ShowPublic = table.Column<bool>(type: "bit", nullable: false),
                    UserNameUrl = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialContact", x => x.SocialContactId);
                    table.ForeignKey(
                        name: "FK_SocialContact_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobApplication",
                columns: table => new
                {
                    JobApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApplicantEmailAddress = table.Column<string>(type: "longtext", nullable: true),
                    ApplicantName = table.Column<string>(type: "longtext", nullable: true),
                    AppliedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CoveringLetter = table.Column<string>(type: "longtext", nullable: true),
                    IpAddress = table.Column<string>(type: "longtext", nullable: true),
                    JobGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    ResumeFileName = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplication", x => x.JobApplicationId);
                    table.ForeignKey(
                        name: "FK_JobApplication_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobInSkill",
                columns: table => new
                {
                    JobInSkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    SkillTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInSkill", x => x.JobInSkillId);
                    table.ForeignKey(
                        name: "FK_JobInSkill_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobInSkill_SkillTag_SkillTagId",
                        column: x => x.SkillTagId,
                        principalTable: "SkillTag",
                        principalColumn: "SkillTagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetupComment",
                columns: table => new
                {
                    MeetupCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CommentedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Commment = table.Column<string>(type: "longtext", nullable: true),
                    MeetupCommentGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MeetupGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MeetupId = table.Column<int>(type: "int", nullable: false),
                    MemberGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    ParentGuid = table.Column<Guid>(type: "char(36)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetupComment", x => x.MeetupCommentId);
                    table.ForeignKey(
                        name: "FK_MeetupComment_Meetup_MeetupId",
                        column: x => x.MeetupId,
                        principalTable: "Meetup",
                        principalColumn: "MeetupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetupComment_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetupParticipant",
                columns: table => new
                {
                    MeetupParticipantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConfirmDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MeetupGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MeetupId = table.Column<int>(type: "int", nullable: false),
                    MeetupParticipantGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MemberGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetupParticipant", x => x.MeetupParticipantId);
                    table.ForeignKey(
                        name: "FK_MeetupParticipant_Meetup_MeetupId",
                        column: x => x.MeetupId,
                        principalTable: "Meetup",
                        principalColumn: "MeetupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetupParticipant_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    PostCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CommentedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Commment = table.Column<string>(type: "longtext", nullable: true),
                    MemberGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    ParentGuid = table.Column<Guid>(type: "char(36)", nullable: true),
                    PostCommentGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    PostGuid = table.Column<Guid>(type: "char(36)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.PostCommentId);
                    table.ForeignKey(
                        name: "FK_PostComment_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostComment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostLike",
                columns: table => new
                {
                    PostLikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LikedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLike", x => x.PostLikeId);
                    table.ForeignKey(
                        name: "FK_PostLike_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_EmailListId",
                table: "EmailAddress",
                column: "EmailListId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_EmailTemplateId",
                table: "EmailAddress",
                column: "EmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_MemberId",
                table: "Job",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplication_JobId",
                table: "JobApplication",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInSkill_JobId",
                table: "JobInSkill",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInSkill_SkillTagId",
                table: "JobInSkill",
                column: "SkillTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetup_MemberId",
                table: "Meetup",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetupComment_MeetupId",
                table: "MeetupComment",
                column: "MeetupId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetupComment_MemberId",
                table: "MeetupComment",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetupParticipant_MeetupId",
                table: "MeetupParticipant",
                column: "MeetupId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetupParticipant_MemberId",
                table: "MeetupParticipant",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_BlogId",
                table: "Post",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_MemberId",
                table: "Post",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_MemberId",
                table: "PostComment",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostId",
                table: "PostComment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLike_PostId",
                table: "PostLike",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialContact_MemberId",
                table: "SocialContact",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "EmailAddress");

            migrationBuilder.DropTable(
                name: "EmailUnsubscription");

            migrationBuilder.DropTable(
                name: "InvalidEmail");

            migrationBuilder.DropTable(
                name: "JobApplication");

            migrationBuilder.DropTable(
                name: "JobInSkill");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropTable(
                name: "MeetupComment");

            migrationBuilder.DropTable(
                name: "MeetupParticipant");

            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "PostLike");

            migrationBuilder.DropTable(
                name: "SocialContact");

            migrationBuilder.DropTable(
                name: "TopicTag");

            migrationBuilder.DropTable(
                name: "EmailList");

            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "SkillTag");

            migrationBuilder.DropTable(
                name: "Meetup");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}

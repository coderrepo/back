﻿// <auto-generated />
using CoderFirst.Common.Enum;
using CoderFirst.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CoderFirst.DataAccess.Migrations
{
    [DbContext(typeof(BaseContext))]
    partial class BaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("CoderFirst.DataAccess.Model.App.Advertisment", b =>
                {
                    b.Property<int>("AdvertismentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddsImageName");

                    b.Property<Guid>("AdvertismentGuid");

                    b.Property<string>("ClickUrl");

                    b.Property<DateTime>("ClosingOn");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("TotalClick");

                    b.Property<string>("WebUrl");

                    b.HasKey("AdvertismentId");

                    b.ToTable("Advertisment");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.App.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.HasKey("ContactId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.App.Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ConfirmedDate");

                    b.Property<string>("EmailAdress");

                    b.Property<int>("Status");

                    b.Property<DateTime>("SubscriptionDate");

                    b.Property<string>("Token");

                    b.HasKey("SubscriptionId");

                    b.ToTable("Subscription");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Content.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Images");

                    b.Property<string>("PostContent");

                    b.HasKey("BlogId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Content.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApprovalStatus");

                    b.Property<int?>("BlogId");

                    b.Property<bool>("CanLoadInIFrame");

                    b.Property<string>("Description");

                    b.Property<string>("FriendlyUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsPublicPost");

                    b.Property<string>("KeyTech");

                    b.Property<DateTime>("LastModified");

                    b.Property<Guid>("MemberGuid");

                    b.Property<int>("MemberId");

                    b.Property<string>("MemberName");

                    b.Property<Guid>("PostGuid");

                    b.Property<int>("PostImageHeight");

                    b.Property<int>("PostImagePosition");

                    b.Property<int>("PostImageWidth");

                    b.Property<int>("PostStatus");

                    b.Property<string>("PostTags");

                    b.Property<int>("PostType");

                    b.Property<string>("PostUrl");

                    b.Property<DateTime>("PublishedOn");

                    b.Property<int?>("RealView");

                    b.Property<bool>("SendPostStats");

                    b.Property<string>("Title");

                    b.Property<int>("TotalLike");

                    b.Property<int>("TotalView");

                    b.Property<string>("UserName");

                    b.Property<string>("VideoEmbed");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.HasIndex("MemberId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Content.PostComment", b =>
                {
                    b.Property<int>("PostCommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CommentedOn");

                    b.Property<string>("Commment");

                    b.Property<Guid>("MemberGuid");

                    b.Property<int>("MemberId");

                    b.Property<Guid?>("ParentGuid");

                    b.Property<Guid>("PostCommentGuid");

                    b.Property<Guid>("PostGuid");

                    b.Property<int>("PostId");

                    b.Property<int>("Status");

                    b.HasKey("PostCommentId");

                    b.HasIndex("MemberId");

                    b.HasIndex("PostId");

                    b.ToTable("PostComment");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Content.PostLike", b =>
                {
                    b.Property<int>("PostLikeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LikedDate");

                    b.Property<int>("MemberId");

                    b.Property<int>("PostId");

                    b.HasKey("PostLikeId");

                    b.HasIndex("PostId");

                    b.ToTable("PostLike");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Email.EmailAddress", b =>
                {
                    b.Property<int>("EmailAddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("EmailAdress");

                    b.Property<int>("EmailListId");

                    b.Property<int?>("EmailTemplateId");

                    b.Property<bool?>("IsBounced");

                    b.Property<string>("JobTitle");

                    b.Property<DateTime?>("LastSentOn");

                    b.Property<string>("MobileNo");

                    b.Property<string>("Name");

                    b.Property<bool?>("Stopped");

                    b.Property<string>("Token");

                    b.HasKey("EmailAddressId");

                    b.HasIndex("EmailListId");

                    b.HasIndex("EmailTemplateId");

                    b.ToTable("EmailAddress");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Email.EmailList", b =>
                {
                    b.Property<int>("EmailListId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("EmailListName");

                    b.Property<DateTime?>("LastSentOn");

                    b.HasKey("EmailListId");

                    b.ToTable("EmailList");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Email.EmailTemplate", b =>
                {
                    b.Property<int>("EmailTemplateId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("FromEmail");

                    b.Property<string>("FromName");

                    b.Property<string>("HtmlTemplate");

                    b.Property<string>("Subject");

                    b.HasKey("EmailTemplateId");

                    b.ToTable("EmailTemplate");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Email.InvalidEmail", b =>
                {
                    b.Property<int>("InvalidEmailId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("EmailAddress");

                    b.Property<int>("Type");

                    b.HasKey("InvalidEmailId");

                    b.ToTable("InvalidEmail");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Job.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutCompany");

                    b.Property<string>("ApplyEmailAddress");

                    b.Property<string>("ApplyUrl");

                    b.Property<DateTime>("ClosingOn");

                    b.Property<string>("CompanyLogo");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CouponCode");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int?>("CustomOrder");

                    b.Property<bool>("DeliverInbox");

                    b.Property<string>("Description");

                    b.Property<string>("DescriptionImageUrl");

                    b.Property<int>("ExperienceLeavel");

                    b.Property<string>("FriendlyUrl");

                    b.Property<bool>("IsFeatured");

                    b.Property<bool>("IsReviewed");

                    b.Property<Guid>("JobGuid");

                    b.Property<int>("JobStatus");

                    b.Property<string>("JobSummary");

                    b.Property<string>("JobTitle");

                    b.Property<int?>("JobType");

                    b.Property<string>("Location");

                    b.Property<Guid>("MemberGuid");

                    b.Property<int>("MemberId");

                    b.Property<DateTime?>("PublishOn");

                    b.Property<bool>("SendJobStats");

                    b.Property<bool>("ShowRecruiterMessage");

                    b.Property<string>("SkillTag");

                    b.Property<int>("TotalApplication");

                    b.Property<int>("TotalExperince");

                    b.Property<int>("Totalview");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("JobId");

                    b.HasIndex("MemberId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Job.JobApplication", b =>
                {
                    b.Property<int>("JobApplicationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicantEmailAddress");

                    b.Property<string>("ApplicantName");

                    b.Property<DateTime>("AppliedOn");

                    b.Property<string>("CoveringLetter");

                    b.Property<string>("IpAddress");

                    b.Property<Guid>("JobGuid");

                    b.Property<int>("JobId");

                    b.Property<string>("ResumeFileName");

                    b.HasKey("JobApplicationId");

                    b.HasIndex("JobId");

                    b.ToTable("JobApplication");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Job.JobInSkill", b =>
                {
                    b.Property<int>("JobInSkillId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("JobId");

                    b.Property<int>("SkillTagId");

                    b.HasKey("JobInSkillId");

                    b.HasIndex("JobId");

                    b.HasIndex("SkillTagId");

                    b.ToTable("JobInSkill");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Job.Lookup.SkillTag", b =>
                {
                    b.Property<int>("SkillTagId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPrimary");

                    b.Property<int>("Status");

                    b.Property<string>("Value");

                    b.HasKey("SkillTagId");

                    b.ToTable("SkillTag");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Job.TopicTag", b =>
                {
                    b.Property<int>("TopicTagId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Status");

                    b.Property<string>("Value");

                    b.HasKey("TopicTagId");

                    b.ToTable("TopicTag");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Meetup.Meetup", b =>
                {
                    b.Property<int>("MeetupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("FriendlyUrl");

                    b.Property<DateTime>("FromDate");

                    b.Property<string>("GooleMapUrl");

                    b.Property<string>("InterestedGroup");

                    b.Property<string>("Location");

                    b.Property<int>("MaxParticipant");

                    b.Property<Guid>("MeetupGuid");

                    b.Property<int>("MeetupStatus");

                    b.Property<string>("MeetupTitle");

                    b.Property<Guid>("MemberGuid");

                    b.Property<int>("MemberId");

                    b.Property<DateTime?>("PublishOn");

                    b.Property<DateTime>("ToDate");

                    b.Property<int>("TotalParticipant");

                    b.Property<int>("Totalview");

                    b.HasKey("MeetupId");

                    b.HasIndex("MemberId");

                    b.ToTable("Meetup");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Meetup.MeetupComment", b =>
                {
                    b.Property<int>("MeetupCommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CommentedOn");

                    b.Property<string>("Commment");

                    b.Property<Guid>("MeetupCommentGuid");

                    b.Property<Guid>("MeetupGuid");

                    b.Property<int>("MeetupId");

                    b.Property<Guid>("MemberGuid");

                    b.Property<int>("MemberId");

                    b.Property<Guid?>("ParentGuid");

                    b.Property<int>("Status");

                    b.HasKey("MeetupCommentId");

                    b.HasIndex("MeetupId");

                    b.HasIndex("MemberId");

                    b.ToTable("MeetupComment");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Meetup.MeetupParticipant", b =>
                {
                    b.Property<int>("MeetupParticipantId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ConfirmDate");

                    b.Property<Guid>("MeetupGuid");

                    b.Property<int>("MeetupId");

                    b.Property<Guid>("MeetupParticipantGuid");

                    b.Property<Guid>("MemberGuid");

                    b.Property<int>("MemberId");

                    b.Property<int>("Status");

                    b.HasKey("MeetupParticipantId");

                    b.HasIndex("MeetupId");

                    b.HasIndex("MemberId");

                    b.ToTable("MeetupParticipant");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Member.EmailUnsubscription", b =>
                {
                    b.Property<int>("EmailUnsubscriptionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("MemberId");

                    b.Property<string>("MemberToken");

                    b.Property<int>("Type");

                    b.HasKey("EmailUnsubscriptionId");

                    b.ToTable("EmailUnsubscription");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Member.Like", b =>
                {
                    b.Property<int>("LikeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ActionedDate");

                    b.Property<int>("Count");

                    b.Property<int>("LikeType");

                    b.Property<int>("LikeTypeId");

                    b.Property<int>("MemberId");

                    b.HasKey("LikeId");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Member.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<string>("CompanyName");

                    b.Property<DateTime?>("DeactivatedOn");

                    b.Property<string>("Email");

                    b.Property<int?>("ExperienceLevel");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeactivated");

                    b.Property<bool>("IsMemberConfirmed");

                    b.Property<bool>("IsTopMember");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LastName");

                    b.Property<bool>("Locked");

                    b.Property<Guid>("MemberGuid");

                    b.Property<string>("MobileNo");

                    b.Property<string>("NewEmailChangeRequest");

                    b.Property<string>("PasswordToken");

                    b.Property<string>("PhotoUrl");

                    b.Property<int?>("ProfileView");

                    b.Property<DateTime>("RegisteredDate");

                    b.Property<string>("SkillTag");

                    b.Property<string>("Token");

                    b.Property<string>("UserName");

                    b.HasKey("MemberId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Member.SocialContact", b =>
                {
                    b.Property<int>("SocialContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactType");

                    b.Property<int>("MemberId");

                    b.Property<bool>("ShowPublic");

                    b.Property<string>("UserNameUrl");

                    b.HasKey("SocialContactId");

                    b.HasIndex("MemberId");

                    b.ToTable("SocialContact");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Content.Post", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Content.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId");

                    b.HasOne("CoderFirst.DataAccess.Model.Member.Member", "Member")
                        .WithMany("Posts")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Content.PostComment", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Member.Member", "Member")
                        .WithMany("PostComment")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoderFirst.DataAccess.Model.Content.Post", "Post")
                        .WithMany("PostComment")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Content.PostLike", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Content.Post", "Post")
                        .WithMany("PostLike")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Email.EmailAddress", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Email.EmailList", "EmailList")
                        .WithMany("EmailAddress")
                        .HasForeignKey("EmailListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoderFirst.DataAccess.Model.Email.EmailTemplate", "EmailTemplate")
                        .WithMany()
                        .HasForeignKey("EmailTemplateId");
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Job.Job", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Member.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Job.JobApplication", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Job.Job", "Job")
                        .WithMany("JobApplication")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Job.JobInSkill", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Job.Job", "Job")
                        .WithMany("JobInSkill")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoderFirst.DataAccess.Model.Job.Lookup.SkillTag", "SkillTag")
                        .WithMany()
                        .HasForeignKey("SkillTagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Meetup.Meetup", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Member.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Meetup.MeetupComment", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Meetup.Meetup", "Meetup")
                        .WithMany("MeetupComment")
                        .HasForeignKey("MeetupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoderFirst.DataAccess.Model.Member.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Meetup.MeetupParticipant", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Meetup.Meetup", "Meetup")
                        .WithMany("MeetupParticipants")
                        .HasForeignKey("MeetupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoderFirst.DataAccess.Model.Member.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Member.SocialContact", b =>
                {
                    b.HasOne("CoderFirst.DataAccess.Model.Member.Member", "Member")
                        .WithMany("SocialContacts")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

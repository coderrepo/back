using System;
using System.Collections.Generic;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject
{
    public class JobBo
    {
        public int JobId { get; set; }       
        public Guid JobGuid { get; set; }
        public Guid? UserId { get; set; }
        public string Description { get; set; }
        public string JobDescriptionType { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteUrl { get; set; }
        public ExperienceLevelEnum ExperienceLeavel { get; set; }
        public int ExperienceLeavelId { get; set; }
        public string JobSummary { get; set; }
        public string AboutCompany { get; set; }
        public string FriendlyUrl { get; set; }
        public string Location { get; set; }
        public int TotalApplication { get; set; }
        public int TotalExperince { get; set; }
        public int TotalView { get; set; }
        public string ApplyEmailAddress { get; set; }
        public string ApplyUrl { get; set; }
        public string[] SkillTagValue { get; set; }
        public string[] SkillTagIds { get; set; }
        public int[] KeyTechnologyRoleIds { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? PublishOn { get; set; }
        public DateTime ClosingOn { get; set; }
        public bool IsReviewed { get; set; }
        public JobStatusEnum JobStatus { get; set; }
        public string DescriptionImageUrl { get; set; }
        public string ReadMoreUrl { get; set; }
        public string ExperienceLevelText { get; set; }
        public string PublishedOnText { get; set; }
        public string ExpiredOnText { get; set; }
        public Guid MemberGuid { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public bool SendJobStats { get; set; }
        public string MemberEmail { get; set; }
        public int ApplicationType { get; set; }
        public string SkillTag { get; set; }
        public JobTypeEnum? JobType { get; set; }
        public string ApplicantEmailAddress { get; set; }
        public string ResumeFileName { get; set; }
        public string ApplicantName { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }
        public bool ShowRecruiterMessage { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyLogoPath { get; set; }
        public string MemberJobTitle { get; set; }
        public List<JobApplicationBo> JobApplication { get; set; }

        public string StatusColor { get; set; }

        public string StatusText { get; set; }
        public bool IsNew { get; set; }
        public bool IsFileDeleted { get; set; }
        public string MemberMobile { get; set; }
        public bool IsPremiumJobPoster { get; set; }
        public string CouponCode { get; set; }
        public decimal DscountPercentage { get; set; }
        public int JobPostFee { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal OrderTotal { get; set; }
        public bool IsFeatured { get; set; }
        public string ClosingOnText { get; set; }
        public bool DeliverInbox { get; set; }
    }
}

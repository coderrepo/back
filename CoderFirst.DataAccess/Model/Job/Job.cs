using CoderFirst.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CoderFirst.DataAccess.Model.Job
{
   [Table("Job")]
   public class Job
    {
        [Key]
        public int JobId { get; set; }
        public int MemberId { get; set; }
        public Guid JobGuid { get; set; }
        public string Description { get; set; }
        public Guid MemberGuid { get; set; }
        public string DescriptionImageUrl { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string JobSummary { get; set; }
        public string WebsiteUrl { get; set; }
        public ExperienceLevelEnum ExperienceLeavel { get; set; }
        public string AboutCompany { get; set; }
        public string FriendlyUrl { get; set; }
        public string Location { get; set; }
        public int TotalExperince { get; set; }
        public int Totalview { get; set; }
        public int TotalApplication { get; set; }
        public string ApplyEmailAddress { get; set; }
        public string ApplyUrl { get; set; }
        public string CompanyLogo { get; set; }
        public string SkillTag { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? PublishOn { get; set; }
        public DateTime ClosingOn { get; set; }
        public bool IsReviewed { get; set; }
        public bool ShowRecruiterMessage { get; set; }
        public JobTypeEnum? JobType { get; set; }
        public bool SendJobStats { get; set; }
        public string CouponCode { get; set; }
        public bool IsFeatured { get; set; }
        public bool DeliverInbox { get; set; }
        public JobStatusEnum JobStatus { get; set; }
        public int? CustomOrder { get; set; }
        public virtual ICollection<JobInSkill> JobInSkill { get; set; }
        public virtual ICollection<JobApplication> JobApplication { get; set; }

        public Member.Member Member { get; set; }
    }
}

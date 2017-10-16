using System;
using System.Collections.Generic;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject
{
    public class MemberBo
    {
        public int MemberId { get; set; }
        public Guid MemberGuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string FirstLatter { get; set; }
        public string UserName { get; set; }
        public string[] SkillTag { get; set; }
        public string MobileNo { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsTopMember { get; set; }
        public string Bio { get; set; }
        public string JobTitle { get; set; }
        public string JobStatus { get; set; }
        public string RegisteredDateText { get; set; }
        public string[] SkillText { get; set; }
        public List<SocialContactlBo> SocialContactlBos { get; set; }
        public int[] SelectedSkillTagIds { get; set; }
        public DateTime RegisteredDate { get; set; }
        public int? ProfileView { get; set; }
        public int RecordCount { get; set; }
        public ExperienceLevelEnum? ExperienceLevel { get; set; }
        public string ExperienceLevelText { get; set; }
        public bool IsMemberConfirmed { get; set; }
        public SocialContactEnum ContactType { get; set; }
        public string PublicProfileUrl { get; set; }
        public bool IsDeactivated { get; set; }
        public string FullName { get; set; }
        public string MemberName { get; set; }
        public DateTime ConfirmDate { get; set; }
        public ParticipantStatusEnum MeetupConfirmationStatus { get; set; }
        public ParticipantStatusEnum Status { get; set; }
        public bool Locked { get; set; }
        public int SelectedExperienceLevel { get; set; }
        public ExperienceLevelEnum ExperienceLeavel { get; set; }
        public string EmailAddress { get; set; }
        public string[] SkillTagValue { get; set; }
        public string Password { get; set; }
        public bool IsTermAccepted { get; set; }
        public string ConfirmPassword { get; set; }
        public string PostAction { get; set; }
        public string ReturnUrl { get; set; }
        public string PicutreUrl { get; set; }
        public string RecaptchaResponse { get; set; }
        public Guid JobGuid { get; set; }
        public decimal PasswordScore { get; set; }
        public Guid InterviewRequestGuid { get; set; }
        public string NewPassword { get; set; }
    }
}
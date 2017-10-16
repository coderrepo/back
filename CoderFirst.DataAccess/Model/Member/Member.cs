using CoderFirst.Common.Enum;
using CoderFirst.DataAccess.Model.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Member
{
    [Table("Member")]
    public class Member
    {
        public Member()
        {
            this.Locked = false;
        }
        [Key]
        public int MemberId { get; set; }
        public Guid MemberGuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string SkillTag { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public int? ProfileView { get; set; }
        public string MobileNo { get; set; }
        public string PhotoUrl { get; set; }
        public string JobTitle { get; set; }
        public string PasswordToken { get; set; }
        public DateTime RegisteredDate { get; set; }
        public bool IsMemberConfirmed { get; set; }
        public bool IsDeactivated { get; set; }
        public DateTime? DeactivatedOn { get; set; }
        public ExperienceLevelEnum? ExperienceLevel { get; set; }
        public bool IsTopMember { get; set; }
        public string Token { get; set; }
        public string NewEmailChangeRequest { get; set; }
        public bool Locked { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<SocialContact> SocialContacts { get; set; }
        public ICollection<PostComment> PostComment { get; set; }
    }
}
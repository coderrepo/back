using CoderFirst.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Meetup
{
   [Table("Meetup")]
    public class Meetup
    {
        [Key]
        public int MeetupId { get; set; }
        public int MemberId { get; set; }
        public Guid MeetupGuid { get; set; }
        public string Description { get; set; }
        public Guid MemberGuid { get; set; }
        public string MeetupTitle { get; set; }
        public string FriendlyUrl { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string GooleMapUrl { get; set; }
        public int Totalview { get; set; }
        public int TotalParticipant { get; set; }
        public string InterestedGroup { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? PublishOn { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int MaxParticipant { get; set; }
        public MeetupStatusEnum MeetupStatus { get; set; }
        public Member.Member Member { get; set; }
        public List<MeetupParticipant> MeetupParticipants { get; set; }
        public virtual ICollection<MeetupComment> MeetupComment { get; set; }
    }
}

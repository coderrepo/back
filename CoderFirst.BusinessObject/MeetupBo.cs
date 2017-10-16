using System;
using System.Collections.Generic;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject
{
    public class MeetupBo
    {
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
        public string SkillTag { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? PublishOn { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool IsReviewed { get; set; }
        public string PublishedOnText { get; set; }
        public int? MaxParticipant { get; set; }
        public string MemberEmail { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }
        public string MemberJobTitle { get; set; }
        public MeetupStatusEnum MeetupStatus { get; set; }
        public string InterestedGroup { get; set; }
        public string[] InterestedGroups { get; set; }
        public string ReadMoreUrl { get; set; }
        public string MemberName { get; set; }
        public List<MemberBo> Participants { get; set; }

    

        public string MeetupDateText { get; set; }

        public string StartTimeText { get; set; }

        public string ToDateText { get; set; }

        public string CreatedOnText { get; set; }

        public string EndTimeText { get; set; }

        public string StatusText { get; set; }
        public DateTime ConfirmDate { get; set; }
        public MeetupParticipantBo  Participant { get; set; }
        public ParticipantStatusEnum MeetupConfirmationStatus { get; set; }
        public string StatusMessage { get; set; }
        public string StatusColor { get; set; }
        public bool IsEnded { get; set; }
        public string Day { get; set; }
        public string MonthYear { get; set; }
    }
}

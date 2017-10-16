using System;
using System.Collections.Generic;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject
{
    public class MeetupParticipantBo
    {
        public DateTime ConfirmDate { get; set; }
        public ParticipantStatusEnum Status { get; set; }
        public Guid MeetupGuid { get; set; }
        public Guid MemberGuid { get; set; }
        public int MeetupId { get; set; }
        public int MemberId { get; set; }
    }
}

using CoderFirst.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Meetup
{
   [Table("MeetupParticipant")]
    public class MeetupParticipant
    {
        [Key]
        public int MeetupParticipantId { get; set; }
        public Guid MeetupParticipantGuid { get; set; }
        public int MeetupId { get; set; }
        public int MemberId { get; set; }
        public Guid MeetupGuid { get; set; }
        public Guid MemberGuid { get; set; }
        public CoderFirst.DataAccess.Model.Member.Member Member { get; set; }
        public Meetup Meetup { get; set; }
        public DateTime ConfirmDate { get; set; }
        public ParticipantStatusEnum Status { get; set; }

    }
}

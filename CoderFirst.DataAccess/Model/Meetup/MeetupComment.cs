using CoderFirst.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Meetup
{
   [Table("MeetupComment")]
    public class MeetupComment
    {
       [Key]
       public int MeetupCommentId { get; set; }
       public Guid MeetupCommentGuid { get; set; }
       public int MeetupId { get; set; }
       public Guid? ParentGuid { get; set; }
       public Guid MeetupGuid { get; set; }
       public int MemberId { get; set; }
       public string Commment { get; set; }
       public DateTime CommentedOn { get; set; }
       public RecordStatusEnum Status { get; set; }
       public Guid MemberGuid { get; set; }
       public Member.Member Member { get; set; }
       public virtual Meetup Meetup { get; set; }
    }
}

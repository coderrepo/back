using System;

namespace CoderFirst.BusinessObject
{
    public class MeetupCommentBo
    {
       public int MeetupCommentId { get; set; }
       public Guid MeetupCommentGuid { get; set; }
       public int MeetupId { get; set; }
       public Guid? ParentGuid { get; set; }
       public Guid MeetupGuid { get; set; }
       public int MemberId { get; set; }
       public string Commment { get; set; }
       public DateTime CommentedOn { get; set; }
       public Guid MemberGuid { get; set; }
       public string MemberName { get; set; }

       public string MemberImageUrl { get; set; }

        public string MeetupUrl { get; set; }
        public string CommentedByUser { get; set; }
        public string MeetupTile { get; set; }
        public string MeetupOwnerName { get; set; }
        public string MeetupOwnerEmail { get; set; }
        public string ParentEmployeeName { get; set; }
        public string ParentEmployeeEmail { get; set; }
        public string ParentUserName { get; set; }
    }
}

using System;

namespace CoderFirst.BusinessObject
{
    public class PostCommentBo
    {
       public int PostCommentId { get; set; }
       public Guid PostCommentGuid { get; set; }
       public int PostId { get; set; }
       public Guid? ParentGuid { get; set; }
       public Guid PostGuid { get; set; }
       public int MemberId { get; set; }
       public string Commment { get; set; }
       public DateTime CommentedOn { get; set; }
       public Guid MemberGuid { get; set; }
       public string MemberName { get; set; }

       public string MemberImageUrl { get; set; }

        public string PostUrl { get; set; }
        public string CommentedByUser { get; set; }
        public string PostTile { get; set; }
        public string PostOwnerName { get; set; }
        public string PostOwnerEmail { get; set; }
        public string ParentEmployeeName { get; set; }
        public string ParentEmployeeEmail { get; set; }
        public string ParentUserName { get; set; }
    }
}

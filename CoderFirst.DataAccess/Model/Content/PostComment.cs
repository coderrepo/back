using CoderFirst.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Content
{
   [Table("PostComment")]
    public class PostComment
    {
       [Key]
       public int PostCommentId { get; set; }
       public Guid PostCommentGuid { get; set; }
       public int PostId { get; set; }
       public Guid? ParentGuid { get; set; }
       public Guid PostGuid { get; set; }
       public int MemberId { get; set; }
       public string Commment { get; set; }
       public DateTime CommentedOn { get; set; }
       public RecordStatusEnum Status { get; set; }
       public Guid MemberGuid { get; set; }
       public Member.Member Member { get; set; }
       public virtual Post Post { get; set; }
    }
}

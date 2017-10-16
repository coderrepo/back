using CoderFirst.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Content
{
    [Table("Post")]
   public class Post
    {
       [Key]
       public int PostId { get; set; }
       public int? BlogId { get; set; }
       public Guid PostGuid { get; set; }
       public Guid MemberGuid { get; set; }
       public string PostUrl { get; set; }
       public string FriendlyUrl { get; set; }
       public PostTypeEnum PostType { get; set; }
       public string Title { get; set; }
       public string UserName { get; set; }
       public string Description { get; set; }
       public string MemberName { get; set; }
       public string PostTags { get; set; }
       public bool IsPublicPost { get; set; }
       public string ImageUrl { get; set; }
       public string VideoEmbed { get; set; }
       public int TotalLike { get; set; }
       public int TotalView { get; set; }
       public int? RealView { get; set; }
       public PostPublishStatusEnum PostStatus { get; set; }
       public PostApprovalStatusEnum ApprovalStatus { get; set; }
       public DateTime LastModified { get; set; }
       public DateTime PublishedOn { get; set; }
       public int PostImageWidth { get; set; }
       public int PostImageHeight { get; set; }
       public int MemberId { get; set; }
       public bool CanLoadInIFrame { get; set; }
       public  Member.Member Member { get; set; }
       public string KeyTech { get; set; }
       public  Blog Blog { get; set; }
       public virtual PostImagePositionEnum PostImagePosition { get; set; }
       public virtual ICollection<PostLike> PostLike { get; set; }
       public virtual ICollection<PostComment> PostComment { get; set; }
       public bool SendPostStats { get; set; }
    }
}

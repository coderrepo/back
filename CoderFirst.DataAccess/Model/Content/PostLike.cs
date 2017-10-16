using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Content
{
   [Table("PostLike")]
    public class PostLike
    {
       [Key]
       public int PostLikeId { get; set; }
       public int PostId { get; set; }
       public int MemberId { get; set; }
       public DateTime LikedDate  { get; set; }
       public virtual Post Post { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoderFirst.Common.Enum;

namespace CoderFirst.DataAccess.Model.Member
{
   [Table("Like")]
    public class Like
    {
       [Key]
       public int LikeId { get; set; }
       public int MemberId { get; set; }
       public LikeTypeEnum LikeType { get; set; }
       public int LikeTypeId { get; set; }
       public DateTime ActionedDate { get; set; }
       public int Count { get; set; }
    }
}

using CoderFirst.DataAccess.Model.Job;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Content
{
  [Table("PostInTopic")]
    public class PostInTopic
    {
      [Key]
      public int PostInTopicId { get; set; }
      public int PostId { get; set; }
      public int TopicTagId { get; set; }
      public virtual TopicTag TopicTag { get; set; }
      public virtual Post Post { get; set; }
    }
}

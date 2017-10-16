using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Job
{
   [Table("TopicTag")]
   public class TopicTag
    {
       [Key]
       public int TopicTagId { get; set; }
       public string Value { get; set; }
       public int Status { get; set; }
    }
}

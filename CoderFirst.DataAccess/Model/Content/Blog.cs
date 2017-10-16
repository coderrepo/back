using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Content
{
    [Table("Blog")]
   public class Blog
    {
       [Key]
       public int BlogId { get; set; }
       public string PostContent { get; set; }
       public string Images { get; set; }
    }
}

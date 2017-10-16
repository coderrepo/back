using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Job.Lookup
{
   [Table("SkillTag")]
    public class SkillTag
    {
       [Key]
       public int SkillTagId { get; set; }
       public string Value { get; set; }
       public int Status { get; set; }
       public bool IsPrimary { get; set; }
    }
}

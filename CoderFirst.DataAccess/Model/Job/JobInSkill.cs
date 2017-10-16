using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoderFirst.DataAccess.Model.Job.Lookup;

namespace CoderFirst.DataAccess.Model.Job
{
  [Table("JobInSkill")]
    public class JobInSkill
    {
      [Key]
      public int JobInSkillId { get; set; }
      public int SkillTagId { get; set; }
      public int JobId { get; set; }
      public virtual SkillTag SkillTag { get; set; }
      public virtual Job Job { get; set; }
    }
}

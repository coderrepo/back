using CoderFirst.DataAccess.Model.Job.Lookup;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Member
{
  [Table("MemberInSkill")]
  public class MemberInSkill
    {
      [Key]
      public int MemberInSkillId { get; set; }
      public int SkillTagId { get; set; }
      public int MemberId { get; set; }
      public virtual SkillTag SkillTag { get; set; }
      public virtual Member Member { get; set; }
    }
}

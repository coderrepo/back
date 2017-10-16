using CoderFirst.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoderFirst.DataAccess.Model.Member
{
    public class SocialContact
    {
       [Key]
       public int SocialContactId { get; set; }
       public int MemberId { get; set; }
       public string UserNameUrl { get; set; }
       public SocialContactEnum ContactType { get; set; }
       public bool ShowPublic { get; set; }
       public virtual Member Member{ get; set; }
    }
}

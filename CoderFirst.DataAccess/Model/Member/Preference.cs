using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoderFirst.DataAccess.Model.Member
{
    [Table("Preference")]
    public class Preference
    {
        [Key]
        public int PreferenceId { get; set; }
        public int MemberId { get; set; }
        public Guid MemberGuid { get; set; }
        public bool ReceiveJobEamil { get; set; }
        public bool ReceivePostEamil { get; set; }
        public bool ReceiveAds { get; set; }
        public bool ShowProfileOnSearch { get; set; }
        public string Token { get; set; }
        public virtual Member Member { get; set; }
    }
}

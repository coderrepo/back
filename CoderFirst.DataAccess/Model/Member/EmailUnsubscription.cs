using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoderFirst.Common.Enum;

namespace CoderFirst.DataAccess.Model.Member
{
    [Table("EmailUnsubscription")]
    public class EmailUnsubscription
    {
        [Key]
        public int EmailUnsubscriptionId { get; set; }
        public int MemberId { get; set; }
        public string MemberToken { get; set; }
        public EmailUnsubscriptionEnum Type { get; set; }
        public DateTime Date { get; set; }
    }
}
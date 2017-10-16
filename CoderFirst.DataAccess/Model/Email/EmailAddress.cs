using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Email
{
   [Table("EmailAddress")]
    public class EmailAddress
    {
        [Key]
        public int EmailAddressId { get; set; }
        public int EmailListId { get; set; }
        public string EmailAdress { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Token { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastSentOn { get; set; }
        public int? EmailTemplateId { get; set; }
        public bool? Stopped { get; set; }
        public bool? IsBounced { get; set; }
        public virtual EmailList EmailList { get; set; }
        public virtual EmailTemplate EmailTemplate { get; set; }
    }
}

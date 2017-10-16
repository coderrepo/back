using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CoderFirst.DataAccess.Model.Email
{ 
   [Table("EmailList")]
    public class EmailList
    {
        [Key]
        public int EmailListId { get; set; }       
        public string EmailListName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastSentOn { get; set; }
        public virtual ICollection<EmailAddress> EmailAddress { get; set; }
    }
}

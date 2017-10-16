using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Email
{
   [Table("EmailTemplate")]
    public class EmailTemplate
    {
        [Key]
        public int EmailTemplateId { get; set; }       
        public string HtmlTemplate { get; set; }
        public string Subject { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

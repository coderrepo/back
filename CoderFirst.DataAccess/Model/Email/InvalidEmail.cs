using CoderFirst.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Email
{
   [Table("InvalidEmail")]
    public class InvalidEmail
    {
        [Key]
        public int InvalidEmailId { get; set; }
        public string EmailAddress { get; set; }
        public InvalidEmailEnum Type { get; set; }
        public DateTime Date { get; set; }
    }
}

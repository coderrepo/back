using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.App
{
    [Table("Subscription")]
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        public string EmailAdress { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public string Token { get; set; }
        public int Status { get; set; }
    }
}

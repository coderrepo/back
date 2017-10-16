using System;

namespace CoderFirst.BusinessObject
{
    public class SubscriptionBo
    {
        public int SubscriptionId { get; set; }
        public string EmailAddress { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public string Token { get; set; }
        public int Status { get; set; }
    }
}

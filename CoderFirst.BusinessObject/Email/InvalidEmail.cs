using System;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject.Email
{
    public class InvalidEmailBo
    {
        public int InvalidEmailId { get; set; }
        public string EmailAddress { get; set; }
        public InvalidEmailEnum Type { get; set; }
        public DateTime Date { get; set; }
    }
}

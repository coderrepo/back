using System;
using System.Collections.Generic;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject.Email
{
    public class EmailUnsubscriptionBo
    {
        public int EmailUnsubscriptionId { get; set; }
        public int MemberId { get; set; }
        public string MemberToken { get; set; }
        public EmailUnsubscriptionEnum Type { get; set; }
        public DateTime Date { get; set; }
    }
}
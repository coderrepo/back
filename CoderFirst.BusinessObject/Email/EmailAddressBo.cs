using System;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject.Email
{
    public class EmailAddressBo
    {
        public int EmailAddressId { get; set; }
        public int EmailListId { get; set; }
        public string EmailAdress { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastSentOn { get; set; }
        public int? EmailTemplateId { get; set; }

        public string Token { get; set; }
    }
}

using System;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject.Email
{
    public class EmailListBo
    {
        public int EmailListId { get; set; }       
        public string EmailListName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastSentOn { get; set; }
        public int TotalEmail { get; set; }
        public int TotalSent { get; set; }
        public int TotalBounced { get; set; }
        public int EmailTemplateId { get; set; }
        public int NoOfEmail2Send { get; set; }
        public string BulkEmails { get; set; }
        public string EmailType { get; set; }
        public InvalidEmailEnum InvalidEmailType { get; set; }
        public bool CheckExsisting { get; set; }

    }
}

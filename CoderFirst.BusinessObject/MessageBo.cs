using System;
namespace CoderFirst.BusinessObject
{
   public class MessageBo
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public DateTime MessageOn { get; set; }
        public bool IsMessageOwner { get; set; }
        public bool IsRequestInterview { get; set; }
        public string Body { get; set; }
        public int FromMemberId { get; set; }
        public int ToMemberId { get; set; }
        public string FromName { get; set; }
        public Guid MessageGuid { get; set; }
        public string FromMemberPhoto { get; set; }
        public bool IsRead { get; set; }
        public string[] SelectedRecipient { get; set; }
        public Guid FromMemberGuid { get; set; }
        public string UserName { get; set; }
        public Guid? ParentGuid { get; set; }
        public string SenderJobTitle { get; set; }
        public string SenderCompanyName { get; set; }
        public string ReceiverPhoto { get; set; }
        public string SenderUserName { get; set; }
        public Guid ThreadId { get; set; }
        public string SenderName { get; set; }
        public Guid MeetupGuid { get; set; }
        public int MonthlySentCount { get; set; }
        public string Salary { get; set; }
        public string Company { get; set; }
        public string RequesteeUserName { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverUserName { get; set; }
        public string ReceiverJobTitle { get; set; }
        public string ReceiverCompanyName { get; set; }
        public string MessageOnText { get; set; }
        public string SenderPhoto { get; set; }
        public string DisplayName { get; set; }
        public string DisplayPhoto { get; set; }
    }
}

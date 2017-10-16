using System;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject
{
    public class SocialContactlBo
    {
        public int SocialContactId { get; set; }
        public int MemberId { get; set; }
        public string UserNameUrl { get; set; }
        public SocialContactEnum ContactType { get; set; }
        public string Type { get; set; }
        public string FacebookUrl { get; set; } 
        public string LinkedinUrl { get; set; } 
        public string TwitterUrl { get; set; }
        public bool ShowPublic { get; set; }
    }
}

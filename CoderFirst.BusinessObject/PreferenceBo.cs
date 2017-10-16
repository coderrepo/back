using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderFirst.BusinessObject
{
    public class PreferenceBo
    {
        public int PreferenceId { get; set; }
        public int MemberId { get; set; }
        public Guid MemberGuid { get; set; }
        public bool ReceiveJobEamil { get; set; }
        public bool ReceivePostEamil { get; set; }
        public bool ShowProfileOnSearch { get; set; }
        public string Token { get; set; }
        public bool ReceiveAds { get; set; }
    }
}

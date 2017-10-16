using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CoderFirst.BusinessObject.Email
{
    public class EmailTemplateBo
    {
        public int EmailTemplateId { get; set; }
        public int MeetupId { get; set; }       
        public string HtmlTemplate { get; set; }
        public string PostIds { get; set; }
        public string[] UserNames { get; set; }
        public string JobIds { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string FromEmail { get; set; }
        public string BulkEmailAddress { get; set; }
        public string FromName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int[] IntPostIds { get; set; }
        public int[] IntJobIds { get; set; }
        public int[] MemberIds { get; set; }

        public string BannerUrl { get; set; }
        public string BannerClickUrl { get; set; }
        public string TotalReg { get; set; }
        public string TotalPageView { get; set; }
        public string TotalJob { get; set; }
        public string TotalPost { get; set; }
        public string ThisMonthTotal { get; set; }
        public IEnumerable<IGrouping<int, JobBo>> JobGroup { get; set; }
        public IEnumerable<IGrouping<int, PostBo>> PostGroup { get; set; }
        public List<JobBo> Jobs { get; set; }
    }
}

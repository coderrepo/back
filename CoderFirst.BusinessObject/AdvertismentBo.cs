using System;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject
{
    public class AdvertismentBo
    {
        public int AdvertismentId { get; set; }
        public Guid AdvertismentGuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ClickUrl { get; set; }
        public string WebUrl { get; set; }
        public DateTime CreatedOn { get; set; }
        public string AddsImageName { get; set; }
        public int TotalClick { get; set; }
        public DateTime ClosingOn { get; set; }
        public  RecordStatusEnum Status { get; set; }
    }
}

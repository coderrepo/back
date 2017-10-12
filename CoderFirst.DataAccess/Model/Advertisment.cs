using CoderFirst.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model
{
   [Table("Advertisment")]
   public class Advertisment
    {
        [Key]
        public int AdvertismentId { get; set; }
        public Guid AdvertismentGuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ClickUrl { get; set; }
        public string WebUrl { get; set; }
        public string AddsImageName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int TotalClick { get; set; }
        public DateTime ClosingOn { get; set; }
        public  RecordStatusEnum Status { get; set; }
    }
}

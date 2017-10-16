using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderFirst.DataAccess.Model.Job
{
   [Table("JobApplication")]
    public class JobApplication
    {
        [Key]
        public int JobApplicationId { get; set; }      
        public int JobId { get; set; }       
        public Guid JobGuid { get; set; }
        public string ApplicantEmailAddress { get; set; }
        public string ApplicantName { get; set; }
        public DateTime AppliedOn { get; set; }
        public  string IpAddress { get; set; }
        public string CoveringLetter { get; set; }
        public string ResumeFileName { get; set; }
        public virtual Job Job { get; set; }
    }
}

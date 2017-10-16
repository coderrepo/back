using System;

namespace CoderFirst.BusinessObject
{
    public class JobApplicationBo
    {
        public int JobApplicationId { get; set; }      
        public int JobId { get; set; }       
        public Guid JobGuid { get; set; }
        public DateTime AppliedOn { get; set; }
        public  string IpAddress { get; set; }
        public string CoveringLetter { get; set; }
        public string JobTitle { get; set; }
        public string ApplicantEmailAddress { get; set; }
        public string ResumeFileName { get; set; }
        public string ApplicantName { get; set; }
        public string IconType { get; set; }
    }
}

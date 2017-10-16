using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class JobApplicationValidation : AbstractValidator<JobApplicationBo>
    {
        public JobApplicationValidation()
        {
            RuleFor(x => x.ApplicantName).NotEmpty().WithMessage("Please provide your name!");
            RuleFor(x => x.ApplicantEmailAddress).NotEmpty().WithMessage("You must provide your email address!");
            RuleFor(x => x.ApplicantEmailAddress).EmailAddress().WithMessage("Please provide a valid email address!");
            RuleFor(x => x.ResumeFileName).NotEmpty().WithMessage("Please upload your resume!");
        }
    }
}
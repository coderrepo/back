using System;
using System.Linq;
using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class JobPostValidation : AbstractValidator<JobBo>
    {
        public JobPostValidation ()
        {
            RuleFor(x => x.JobTitle).NotEmpty().WithMessage("Please provide your job title!");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Please provide your company name!");
            RuleFor(x => x.ExperienceLeavelId).Must(m => m > 0).WithMessage("Please select expected job experience level!");

            RuleFor(x => x.WebsiteUrl).NotEmpty().WithMessage("Please provide valid company website URL!");
            RuleFor(a => a.ApplyEmailAddress).NotEmpty().When(a => a.ApplicationType == 1).WithMessage("Please provide a valid application email address!").EmailAddress().WithMessage("Please provide a valid application email address!");
           
            RuleFor(a => a.ApplyUrl).NotEmpty().When(a => a.ApplicationType == 2).WithMessage("Please provide a valid application website link!");
            RuleFor(m => m.DescriptionImageUrl).NotEmpty().Unless(m => !string.IsNullOrEmpty(m.Description)).WithMessage("Please upload/write your job description!");
            RuleFor(a => a.Description).NotEmpty().When(a => a.JobDescriptionType == "Text").WithMessage("Please write your job description!");
            RuleFor(x => x.SkillTagValue).Must(TechnologyRole).WithMessage("Please select minimum 3 key technology roles!");
            RuleFor(x => x.CouponCode).Must(CouponCodeValidation).WithMessage("The coupon code you entered has expired.!");
        }


        private bool CouponCodeValidation( string code)
        {
            if (code == "48255DD")
                return false;

            return true;
        }

        private bool TechnologyRole(string[] skill)
        {
            if (skill == null || skill.Count() < 3) return false;

            return true;
        }
    }
}
using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class ProfileUpdateValidation : AbstractValidator<MemberBo>
    {
        public ProfileUpdateValidation()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("You must provide first name");
            RuleFor(x => x.LastName).NotNull().WithMessage("You must provide user name");
            RuleFor(x => x.LastName).Matches(@"^([a-zA-Z]{1,999}[\s]*){1,25}$").WithMessage("Last name must not contain numbers or symbols.");
            RuleFor(x => x.FirstName).Matches(@"^([a-zA-Z]{1,999}[\s]*){1,25}$").WithMessage("First name must not contain numbers or symbols.");
            RuleFor(x => x.SkillTag).Must(m=> m != null &&  m.Length > 1).WithMessage("You must provide at least two skills");
            //RuleFor(x => x.MobileNo).Numeric().WithMessage("Please provide a valid mobile number!");
            RuleFor(x => x.SelectedExperienceLevel).Must(m => m > 0).WithMessage("Please select your experience level");
        }
    }
}
using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class RegistrationValidation : AbstractValidator<MemberBo>
    {

        public RegistrationValidation()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("You must provide first name");
            RuleFor(x => x.FirstName).Matches(@"^([a-zA-Z]{1,999}[\s]*){1,25}$").WithMessage("First name must not contain numbers or symbols.");

            RuleFor(x => x.LastName).NotNull().WithMessage("You must provide last name");
            RuleFor(x => x.LastName).Matches(@"^([a-zA-Z]{1,999}[\s]*){1,25}$").WithMessage("Last name must not contain numbers or symbols.");

          //  RuleFor(x => x.EmailAddress).NotNull().WithMessage("You must provide an email");
           // RuleFor(x => x.EmailAddress).Must(memberServices.IsEmailUsed).WithMessage("Email already taken. Please login.");
           // RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Please provide a valid email address!");

         //   RuleFor(x => x.MobileNo).Numeric().WithMessage("Please provide a valid mobile number!");

            RuleFor(x => x.ExperienceLeavel).Must(m => m > 0).WithMessage("Please select your seniority level.");

            RuleFor(x => x.SkillTagValue).Must(TechnologyRole).WithMessage("Please select minimum 3 key technology roles!");

            RuleFor(x => x.Password).NotNull().WithMessage("We need a password to create your account.");
            RuleFor(x => x.Password).Length(8, 100).WithMessage("Password must be at least 8 characters long");
            RuleFor(x => x.PasswordScore).Must(m=>m >= 26).WithMessage("Please choose a more secure password.");

            RuleFor(x => x.ConfirmPassword).NotNull().WithMessage("You must provide confirm password");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Your new password and confirmation password must match.");

            RuleFor(x => x.UserName).NotNull().WithMessage("You must provide user name");
            RuleFor(x => x.UserName).Matches(@"^([a-zA-Z]{1,999}[\s]*){1,25}$").WithMessage("Profile name must not contain numbers or symbols.");

            RuleFor(x => x.UserName).Length(4, 20).WithMessage("Profile name must be at least 4 characters long.");
           // RuleFor(x => x.UserName).Must(memberServices.IsUserNameTaken).WithMessage("Profile name already taken. Please provide a different one.");
           
            RuleFor(x => x.IsTermAccepted).Equal(true).WithMessage("You must accept terms and condition");

        }

        private bool TechnologyRole(string[] skill)
        {
            if (skill == null || skill.Length < 3) return false;

            return true;
        }
    }
}
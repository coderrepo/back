using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class ResetPasswordValidation : AbstractValidator<MemberBo>
    {
        public ResetPasswordValidation()
        {
            RuleFor(x => x.EmailAddress).NotNull().WithMessage("You must provide your email address");
            RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Please provide a valid email address!");
        }
    }
}
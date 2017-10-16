using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class ChangePasswordValidation : AbstractValidator<MemberBo>
    {
        public ChangePasswordValidation()
        {
            RuleFor(x => x.NewPassword).NotNull().WithMessage("We need a password to create your account.");
            RuleFor(x => x.ConfirmPassword).NotNull().WithMessage("You must provide confirm password");
            RuleFor(x => x.NewPassword).Length(6, 20).WithMessage("Password must be at least 6 characters long");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.NewPassword).WithMessage("Your new password and confirmation password must match");
        }
    }
}
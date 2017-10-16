using FluentValidation;

//namespace CoderFirst.API.ModelValidation
//{
//    public class PasswordChangeValidation : AbstractValidator<ManageUserViewModel>
//    {
//        public PasswordChangeValidation()
//        {
//            RuleFor(x => x.OldPassword).NotNull().WithMessage("You must provide your current password!");
//            RuleFor(x => x.NewPassword).NotNull().WithMessage("You must provide new password");
//            RuleFor(x => x.NewPassword).Length(6, 20).WithMessage("Password must be at least 6 characters long");
//            RuleFor(x => x.ConfirmPassword).NotNull().WithMessage("You must provide confirm password");
//            RuleFor(x => x.ConfirmPassword).Equal(x => x.NewPassword).WithMessage("Your new password and confirmation password must match");
//        }
//    }
//}
using CoderFirst.BusinessObject;
using FluentValidation;


namespace CoderFirst.API.ModelValidation
{
    public class MessageValidation : AbstractValidator<MessageBo>
    {
        
        public MessageValidation()
        {
            RuleSet("false", () =>
            {
                RuleFor(x => x.Subject).NotNull().WithMessage("You must provide your message subject.");
                RuleFor(x => x.Message).NotNull().WithMessage("You must provide your message.");
                RuleFor(x => x.SelectedRecipient).NotNull().WithMessage("Please select at least one recipient.");
                RuleFor(x => x.MonthlySentCount).LessThanOrEqualTo(5).WithMessage("You have reached maximum of 5 for sending messages per month.");

            });

            RuleSet("true", () =>
            {
                RuleFor(x => x.Subject).NotNull().WithMessage("You must provide your job title.");
                RuleFor(x => x.Company).NotNull().WithMessage("Please provide your company name.");
                RuleFor(x => x.Message).NotNull().WithMessage("You must provide your message.");
                RuleFor(x => x.SelectedRecipient).NotNull().WithMessage("Please select at least one recipient.");
                RuleFor(x => x.MonthlySentCount).LessThanOrEqualTo(5).WithMessage("You have reached maximum of 5 for sending request interview per month.");

            });

        }
    }
}
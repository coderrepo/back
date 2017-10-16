using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class LinkPostValidation : AbstractValidator<PostBo>
    {
        public LinkPostValidation()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("You must provide post title");
            RuleFor(x => x.Description).NotNull().WithMessage("You must provide post description");
            RuleFor(x => x.PostTags).Must(m => m != null && m.Length > 1).WithMessage("You must provide at least two technology");
        }
    }
}
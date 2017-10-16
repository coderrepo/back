using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class BlogPostValidation : AbstractValidator<PostBo>
    {
        public BlogPostValidation()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("You must provide post title");
            RuleFor(x => x.Description).NotNull().WithMessage("You must provide blog content");
            RuleFor(x => x.PostTags).Must(m => m != null && m.Length > 1).WithMessage("You must provide at least two technology");
        }
    }
}
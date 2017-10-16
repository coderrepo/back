using System;
using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class SocialContactUpdateValidation : AbstractValidator<SocialContactlBo>
    {
        public SocialContactUpdateValidation()
        {
            RuleFor(x => x.FacebookUrl).Must(IsValidUrl).WithMessage("Please provide valid Facebook profile URL!");
            RuleFor(x => x.LinkedinUrl).Must(IsValidUrl).WithMessage("Please provide valid Linkedin profile URL!");
            RuleFor(x => x.TwitterUrl).Must(IsValidUrl).WithMessage("Please provide valid Twitter profile URL!");

        }

        private bool IsValidUrl(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                Uri myUri;
                Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out myUri);
                if (myUri != null && myUri.IsAbsoluteUri == false)
                {
                    return false;
                }
                return true;
            }

            return true;
        }

    }
}
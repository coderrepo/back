using System;
using System.Linq;
using CoderFirst.BusinessObject;
using FluentValidation;

namespace CoderFirst.API.ModelValidation
{
    public class MeetupPostValidation : AbstractValidator<MeetupBo>
    {
        public MeetupPostValidation ()
        {
            RuleFor(x => x.MeetupTitle).NotEmpty().WithMessage("Please provide your Meetup title!");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Please provide your meetup location name!");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Please provide your meetup address!");
            RuleFor(a => a.Description).NotEmpty().WithMessage("Please write/upload your meetup description!");
            RuleFor(x => x.InterestedGroups).Must(InterestedGroup).WithMessage("Please select minimum 3 interested group!");
            RuleFor(a => a.FromDate).NotEmpty().WithMessage("Please select meetup start date and time!");
            RuleFor(a => a.MaxParticipant).NotEmpty().WithMessage("Please enter maximum attendees for this meetup!");
            RuleFor(a => a.ToDate).NotEmpty().WithMessage("Please select meetup end date and time!");
            RuleFor(a => a.ToDate).GreaterThanOrEqualTo(a => a.FromDate).When(w=>w.FromDate != null && w.ToDate != null).WithMessage("Meetup from Date cannot be after the To Date!");
            RuleFor(a => a.GooleMapUrl).Must(IsValidUrl).When(a => !string.IsNullOrWhiteSpace( a.GooleMapUrl)).WithMessage("Please provide a valid google map url!");
            RuleFor(a => a.ToDate).GreaterThanOrEqualTo(a => a.FromDate).When(w => w.FromDate != null && w.ToDate != null).WithMessage("Meetup from Date cannot be after the To Date!");
           // RuleFor(a => a.ToDate).LessThan(a => a.FromDate).WithMessage("Meetup Date cannot be after the To Date!");

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

            return false;
        }

        private bool InterestedGroup(string[] group)
        {
            if (group == null || group.Count() < 3) return false;

            return true;
        }
    }
}
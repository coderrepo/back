using CoderFirst.DataAccess;
using Microsoft.Extensions.Logging;
using CoderFirst.BusinessObject;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoderFirst.DataAccess.Model;
using CoderFirst.DataAccess.Model.App;

namespace CMS.UIServices.Advertisment
{
    public class MemberService : IMemberService
    {
        private readonly BaseContext _context;
        private readonly ILogger _logger;

        public MemberService(BaseContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("DataAccessMySqlProvider");
        }

        public async void Addsubscription(SubscriptionBo subscriptionBo)
        {
            _context.Subscription.Add(new Subscription()
            {
                EmailAdress = subscriptionBo.EmailAddress,
                SubscriptionDate = subscriptionBo.SubscriptionDate,
                Token = subscriptionBo.Token
            });

            await _context.SaveChangesAsync();
        }

    }
}

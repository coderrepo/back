using System.Collections.Generic;
using CoderFirst.DataAccess.BusinessObject;
using System.Threading.Tasks;

namespace CMS.UIServices.Advertisment
{
    public interface IAdvertismentService
    {
        Task<List<AdvertismentBo>> GetAdvertismentsAsync();
    }
}

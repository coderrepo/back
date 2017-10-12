using Microsoft.AspNetCore.Mvc;
using CMS.UIServices.Advertisment;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoderFirst.DataAccess.BusinessObject;

namespace CoderFirst.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Advertisment")]
    public class AdvertismentController : Controller
    {
        private readonly IAdvertismentService _advertismentService;

        public AdvertismentController(IAdvertismentService advertismentService)
        {
            _advertismentService = advertismentService;
        }

        // GET api/values
        [HttpGet]
        public async Task<List<AdvertismentBo>> GetAsync()
        {
            return await _advertismentService.GetAdvertismentsAsync();
        }
    }
}
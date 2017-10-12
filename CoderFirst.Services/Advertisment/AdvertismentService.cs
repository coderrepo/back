using System;
using System.Collections.Generic;
using System.Linq;
using CoderFirst.DataAccess.BusinessObject;
using CoderFirst.DataAccess;
using Microsoft.Extensions.Logging;
using CoderFirst.Common.Enum;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CMS.UIServices.Advertisment
{
    public class AdvertismentService  : IAdvertismentService
    {
        private readonly BaseContext _context;
        private readonly ILogger _logger;

        public AdvertismentService(BaseContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("DataAccessMySqlProvider");
        }

        public async  Task<List<AdvertismentBo>> GetAdvertismentsAsync()
        {
            var result = await _context.Advertisment.Where(w => w.Status == RecordStatusEnum.Active && w.ClosingOn >= DateTime.Now).ToListAsync();
            return result.Select(AdvertismentMapper.BuildBo).ToList();
        }
    }
}

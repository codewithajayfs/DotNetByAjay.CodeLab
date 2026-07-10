using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace API.Cache.AzureRedisCache.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminControllers : ControllerBase
    {
        private readonly ILogger<AdminControllers> _logger;
        private readonly IDistributedCache _cache;

        public AdminControllers(ILogger<AdminControllers> logger, IDistributedCache cache)
        {
            _logger = logger;
            _cache = cache;
        }

        [HttpGet("admin/getappadminlist")]
        public IEnumerable<string> GetAppAdminList()
        {
            IEnumerable<string> appAdmins = new List<string>();

            // If we don't have admin list in cache, then fetch it from database
            if (string.IsNullOrEmpty(_cache.GetString("ListOfAdmins")))
            {
                appAdmins = GetAppAdmins();
                
                // Cache Miss Rate - Everytime you are not finding record in cache, it means there is Cache Miss
                // For testing commented below code, now everytime data will fetch from database
                // _cache.SetString("ListOfAdmins", JsonConvert.SerializeObject(appAdmins));
                return appAdmins;
            }
            // else fetch it from Redis cache
            else
            {
                var appAdminSerialized = _cache.GetString("ListOfAdmins");
                appAdmins = JsonConvert.DeserializeObject<List<string>>(appAdminSerialized);

                return appAdmins;
            }
        }

        private IEnumerable<string> GetAppAdmins()
        {
            return new List<string>() { "James", "Ajay" };
        }

        private void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
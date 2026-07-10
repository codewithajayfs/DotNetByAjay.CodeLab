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
            if (string.IsNullOrEmpty(_cache.GetString("ListOfAdmins")))
            {
                appAdmins = GetAppAdmins();
                _cache.SetString("ListOfAdmins", JsonConvert.SerializeObject(appAdmins));
                return appAdmins;
            }
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
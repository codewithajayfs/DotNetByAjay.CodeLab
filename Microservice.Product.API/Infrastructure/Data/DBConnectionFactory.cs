using Microsoft.Data.SqlClient;
using System.Data;

namespace Microservice.Product.API.Infrastructure.Data
{
    public class DBConnectionFactory : IDBConnectionFactory
    {
        private readonly IConfiguration _configuration;
        public DBConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}

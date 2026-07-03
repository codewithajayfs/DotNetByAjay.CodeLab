using System.Data;

namespace Microservice.Product.API.Infrastructure.Data
{
    public interface IDBConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}

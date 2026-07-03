using Dapper;
using System.Data;

namespace Microservice.Product.API.Infrastructure.Data
{
    public interface IGenericRepository
    {
        Task<IEnumerable<T>> QueryAsync<T>(string command, object? parameters = null,
            IDbTransaction? transaction = null, CommandType commandType = CommandType.Text);

        Task<T?> QuerySingleAsync<T>(string command, object? parameters = null,
            IDbTransaction? transaction = null, CommandType commandType = CommandType.Text);

        Task<int> ExecuteAsync(string command, object? parameters = null,
            IDbTransaction? transaction = null, CommandType commandType = CommandType.Text);

        Task<T?> ExecuteScalerAsync<T>(string command, object? parameters = null,
            IDbTransaction? transaction = null, CommandType commandType = CommandType.Text);

        Task<SqlMapper.GridReader> QueryMultipleAsync(string command, object? parameters = null,
            IDbTransaction? transaction = null, CommandType commandType = CommandType.Text);
    }
}

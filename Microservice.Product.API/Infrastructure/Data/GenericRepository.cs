using Dapper;
using System.Data;

namespace Microservice.Product.API.Infrastructure.Data
{
    public class GenericRepository : IGenericRepository
    {
        IDBConnectionFactory _dbConnectionFactory;

        public GenericRepository(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        /// <summary>
        /// Saves the data to the database based on the provided command and parameters.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<int> ExecuteAsync(string command, object? parameters = null, IDbTransaction? transaction = null, CommandType commandType = CommandType.Text)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            return await connection.ExecuteAsync(command, parameters, transaction, commandType: commandType);
        }

        /// <summary>
        /// Single data from the database based on the provided command and parameters.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<T?> ExecuteScalerAsync<T>(string command, object? parameters = null, IDbTransaction? transaction = null, CommandType commandType = CommandType.Text)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            return await connection.ExecuteScalarAsync<T>(command, parameters, transaction, commandType: commandType);
        }

        /// <summary>
        /// Lists the data from the database based on the provided command and parameters.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> QueryAsync<T>(string command, object? parameters = null, IDbTransaction? transaction = null, CommandType commandType = CommandType.Text)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            return await connection.QueryAsync<T>(command, parameters, transaction, commandType: commandType);
        }

        /// <summary>
        /// Multiple data from the database based on the provided command and parameters.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<SqlMapper.GridReader> QueryMultipleAsync(string command, object? parameters = null, IDbTransaction? transaction = null, CommandType commandType = CommandType.Text)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            return await connection.QueryMultipleAsync(command, parameters, transaction, commandType: commandType);
        }

        /// <summary>
        /// Single data from the database based on the provided command and parameters.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<T?> QuerySingleAsync<T>(string command, object? parameters = null, IDbTransaction? transaction = null, CommandType commandType = CommandType.Text)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<T>(command, parameters, transaction, commandType: commandType);
        }
    }
}

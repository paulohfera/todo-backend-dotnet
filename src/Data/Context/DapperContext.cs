using System.Data;
using System.Data.SqlClient;
using Domain.Model.Settings;

namespace Data.Context
{
    public class DapperContext
    {
        private readonly string _connection;

        public DapperContext(MssqlSettings settings)
        {
            _connection = settings.ConnectionString;
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connection);
    }
}

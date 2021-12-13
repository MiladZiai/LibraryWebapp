using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<I>> LoadData<I, J>(string sql, J parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<I>(sql, parameters);

                return rows.ToList();
            }
        }

        public Task StoreData<I>(string sql, I parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}

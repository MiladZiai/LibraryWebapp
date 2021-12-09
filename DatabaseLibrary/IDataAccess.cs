using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDataAccess
    {
        Task<List<I>> LoadData<I, J>(string sql, J parameters, string connectionString);
        Task StoreData<I>(string sql, I parameters, string connectionString);
    }
}
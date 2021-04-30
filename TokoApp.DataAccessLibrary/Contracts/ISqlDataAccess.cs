using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace TokoApp.DataAccessLibrary.Contracts
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task DeleteData<T>(string sql, T parameters);
        Task<int> InsertDataSet<T, U>(string storedProcedureName, DataTable dataTable, U parameters);
        Task<List<T>> LoadDataAsync<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}
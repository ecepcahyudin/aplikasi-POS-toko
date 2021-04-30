using System.Collections.Generic;
using System.Threading.Tasks;
using TokoApp.Shared.Models;

namespace TokoApp.DataAccessLibrary.Contracts
{
    public interface IMasterBarangData
    {
        Task InsertAsync(MasterBarangViewModel data);
        Task DeleteAsync(int kdBarang);
        Task<List<MasterBarangViewModel>> GetAsync(string top = "25");
    }
}
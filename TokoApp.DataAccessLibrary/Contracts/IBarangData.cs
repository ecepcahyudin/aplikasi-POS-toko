using System.Collections.Generic;
using System.Threading.Tasks;
using TokoApp.Shared.Models;

namespace TokoApp.DataAccessLibrary.Contracts
{
    public interface IBarangData
    {
        Task<List<BarangModel>> GetBarangsAsync(string top);
        Task<List<BarangModel>> GetHargasAsync(string top);
    }
}
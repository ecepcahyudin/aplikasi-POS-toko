using System.Collections.Generic;
using System.Threading.Tasks;
using TokoApp.Shared.Models;

namespace TokoApp.DataAccessLibrary.Contracts
{
    public interface IPenerimaanData
    {
        Task<List<PenerimaanViewModel>> GetPenerimaanAsync(string top, string namaBarang);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using TokoApp.Shared.Models;

namespace TokoApp.DataAccessLibrary.Contracts
{
    public interface IPenjualanData
    {
        Task<int> Insert(List<PenjualanViewModel> datas);
    }
}
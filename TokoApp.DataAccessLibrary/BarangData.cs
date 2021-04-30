using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using TokoApp.DataAccessLibrary.Contracts;
using TokoApp.Shared.Models;

namespace TokoApp.DataAccessLibrary
{
    public class BarangData : IBarangData
    {
        private readonly ISqlDataAccess _db;

        public BarangData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<List<BarangModel>> GetBarangsAsync(string top)
        {
            var p = new
            {
                top = Int16.Parse(top)
            };

            string sql = @"select top(@Top) kdBarang, namaBarang, satuan from barang_m ";
            return await _db.LoadDataAsync<BarangModel, dynamic>(sql, p);
        }

        public async Task<List<BarangModel>> GetHargasAsync(string top)
        {
            var p = new
            {
                top = Int16.Parse(top)
            };

            string sql = @"select top(@Top) noPenerimaan, kdBarang, namaBarang, harga, satuan, stok from v_harga ";
            return await _db.LoadDataAsync<BarangModel, dynamic>(sql, p);
        }
    }
}

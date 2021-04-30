using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TokoApp.DataAccessLibrary.Contracts;
using TokoApp.Shared.Models;

namespace TokoApp.DataAccessLibrary
{
    public class PenerimaanData : IPenerimaanData
    {
        private readonly ISqlDataAccess _db;

        public PenerimaanData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<List<PenerimaanViewModel>> GetPenerimaanAsync(string top, string namaBarang)
        {
            var p = new
            {
                top = Int16.Parse(top),
                namaBarang = namaBarang
            };

            string sql = @"select top(@Top) noPenerimaan, noFaktur, kdBarang, namaBarang, jmlTerima, harga 
                            from v_penerimaan where namaBarang like '%' + @NamaBarang + '%' ";

            return await _db.LoadDataAsync<PenerimaanViewModel, dynamic>(sql, p);
        }
    }
}

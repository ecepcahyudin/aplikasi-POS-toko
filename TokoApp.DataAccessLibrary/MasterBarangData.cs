using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TokoApp.DataAccessLibrary.Contracts;
using TokoApp.Shared.Models;

namespace TokoApp.DataAccessLibrary
{
    public class MasterBarangData : IMasterBarangData
    {
        private readonly ISqlDataAccess _db;

        public MasterBarangData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task InsertAsync(MasterBarangViewModel data)
        {
            
            string sql = @"insert into barang_m (namaBarang, satuan, status) values(@NamaBarang,@KdSatuan,@Status)";

            await _db.SaveData(sql, data);
        }

        public async Task DeleteAsync(int kdBarang)
        {
            var p = new
            {
                kdBarang = kdBarang
            };

            string sql = @"delete barang_m where kdBarang=@kdBarang";
            await _db.DeleteData<dynamic>(sql,p);
        }

        public async Task<List<MasterBarangViewModel>> GetAsync(string top="25")
        {
            var p = new
            {
                top = Int16.Parse(top)
            };

            string sql = @"select top(@Top) kdBarang, namaBarang, satuan from barang_m";
            return await _db.LoadDataAsync<MasterBarangViewModel, dynamic>(sql,p);
        }

    }
}

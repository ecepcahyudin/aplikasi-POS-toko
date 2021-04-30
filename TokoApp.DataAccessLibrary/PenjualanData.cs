using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TokoApp.DataAccessLibrary.Contracts;
using TokoApp.Shared.Models;

namespace TokoApp.DataAccessLibrary
{
    public class PenjualanData : IPenjualanData
    {
        private readonly ISqlDataAccess _db;

        public PenjualanData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<int> Insert(List<PenjualanViewModel> datas)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("noPenerimaan");
            dataTable.Columns.Add("kdBarang");
            dataTable.Columns.Add("jmlBeli");
            dataTable.Columns.Add("harga");
            dataTable.Columns.Add("diskon");
            dataTable.Columns.Add("idUser");

            foreach (var item in datas)
            {
                dataTable.Rows.Add(item.NoPenerimaan, item.KdBarang, item.JmlBeli, item.Harga, item.Diskon, "11111");
            }

            var p = new
            {
                data = dataTable.AsTableValuedParameter("penjualanUDT")

            };

            return await _db.InsertDataSet<PenjualanViewModel, dynamic>("dbo.sp_penjulan", dataTable, p);
        }
    }
}

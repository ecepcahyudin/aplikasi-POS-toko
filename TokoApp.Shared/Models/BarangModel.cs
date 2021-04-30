using System;
using System.Collections.Generic;
using System.Text;

namespace TokoApp.Shared.Models
{
    public class BarangModel
    {
        public string NoPenerimaan { get; set; }
        public string KdBarang { get; set; }
        public string NamaBarang { get; set; }
        public int Harga { get; set; }
        public string Satuan { get; set; }
        public int Stok { get; set; }
    }
}

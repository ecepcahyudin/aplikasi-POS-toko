using System;
using System.Collections.Generic;
using System.Text;

namespace TokoApp.Shared.Models
{
    public class PenerimaanViewModel
    {
        public string NoPenerimaan { get; set; }
        public string NoFaktur { get; set; }
        public string KdBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Satuan { get; set; }
        public int JmlTerima { get; set; }
        public int Harga { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TokoApp.Shared.Models
{
    public class MasterBarangViewModel
    {
        public int KdBarang { get; set; }
        public string NamaBarang { get; set; }
        public int? KdSatuan { get; set; }
        public string Satuan { get; set; }
        public bool Status { get; set; }
    }
}

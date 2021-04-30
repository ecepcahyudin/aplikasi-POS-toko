using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokoApp.Shared.Models
{
    public class PenjualanViewModel
    {
        public string NoPenerimaan { get; set; }
        public string KdBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Satuan { get; set; }
        public int JmlBeli { get; set; }
        public int Harga { get; set; }
        public int Diskon { get; set; }
        
        public int Biaya {
            
            get
            {
                return JmlBeli * Harga;
            }

        }

        public int JmlBayar {

            get
            {
                return Biaya - Diskon;
            }

        }


    }
}

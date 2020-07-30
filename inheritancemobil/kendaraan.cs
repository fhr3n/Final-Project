using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancemobil
{
    class kendaraan
    {   
        
        
        public string Nama { get; set; }
        public string Tipe { get; set; }
        public int cc { get; set; }
        public int Roda { get; set; }

       
        public void ciriciri()
        {
            Console.WriteLine("Nama kendaraan {0} , Tipe {1} , cc {2} , Roda {3}", Nama ,Tipe ,cc ,Roda);

        }
    }
}

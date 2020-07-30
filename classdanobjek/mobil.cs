using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdanobjek
{
    class mobil
    {
        //properties
        public string nama { get; set; }
        public string tipe { get; set; }
        public int jumlah { get; set; }
        public string warna { get; set; }

       //method
       public void mobilsaya()
        {
            Console.WriteLine("Nama mobil saya {0}", nama);
            Console.WriteLine("Tipe Mobil saya {0} ", tipe);
            Console.WriteLine("Jumlah mobil saya {0}", jumlah);
            Console.WriteLine("Warna mobil saya {0}", warna);
        }

        public void punya()
        {
            Console.WriteLine("{0} adalah mobil saya " ,nama);
        }

    }
}

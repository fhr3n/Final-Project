using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancemobil
{
    class motor : kendaraan
    {
        public int penumpang { get; set; }

        public void gesit()
        {
            Console.WriteLine("motor cuma dapat membawa {0} penumpnag dan motor lebih gesit ketimbang mobil ",penumpang);
        }
    }
}

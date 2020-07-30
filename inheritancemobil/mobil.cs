using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancemobil
{
    class mobil : kendaraan
    {
        /*beberapa informasi yg sama tidak perlu kita buat lagi
        seperti properties dan method yang ada pada class kendaraan
        kemudian kelas turunan ini cukup melakukan konsep inheritance melalui perintah titik dua 
        karena kelas mobil ini merupakan kelas turunan dari kelas kendaraan 
        otomatis member kelas nya baik properti maupun method akan
        diwaris kelas turunannya*/

        public int pintu { get; set; }

        public void muatan()
        {
            Console.WriteLine("Mobil memeliki 4 pintu dan lebih bagus untuk membawa muatan lebih");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancemobil
{
    class Program
    {
        static void Main(string[] args)
        {
            mobil Mobil; 
            Mobil = new mobil();
            Mobil.Nama = "ASX";
            Mobil.Tipe = "1190";
            Mobil.cc = 3000;
            Mobil.Roda = 4;
            Mobil.pintu = 4;
            Mobil.ciriciri();
            Mobil.muatan();

            motor Motor;
            Motor = new motor();
            Motor.Nama = "CSX";
            Motor.Tipe = "25";
            Motor.Roda = 2;
            Motor.cc = 250;
            Motor.penumpang = 1;
            Motor.ciriciri();
            Motor.gesit();

            Console.ReadKey();

        }
    }
}

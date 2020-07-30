using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdanobjek
{
    class Program
    {
        static void Main(string[] args)
        {
            mobil mobilku;               //ini merupakan pointer yg dimana
                                         //mobil adalah nama class yang kita buat sebelumnya,
                                         //sedangkan mobilku adalah pointer yang akan menjadi
                                         // penunjuk atribut atau method mana yang kita maksud di class mobil

            mobilku = new mobil();       //disini kita telah membuat objek dari mobil 

            mobilku.nama = "Nissan";     //kita sedang memberi nilai dari atribut di class mobil , 
            mobilku.tipe = "r35";        //tipe data disesuaikan dengan atribut di class mobil , 
            mobilku.jumlah = 1;          //seperti integer atau string.
            mobilku.warna = "putih";

            mobilku.mobilsaya();        //objek mobilku sedang memberi nilai pada method mobilsaya dan punya, 
            mobilku.punya();            // dimana objek ini akan melakukan aksi yg telah kita 
                                        //ketik pada method yang berada di kelas mobil


            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace JurnalModul4_103082400008
{
    public class Program
    {
        static void Main(string[] args)
    
        {
            kodeBuah kodeBuah = new kodeBuah();

            Console.Write("Masukkan nama buah: ");

            string namaBuah = Console.ReadLine();

            string hasilKode = kodeBuah.getkodeBuah(namaBuah);

            Console.WriteLine("Kode buah " + namaBuah + " adalah: " + hasilKode);


            Console.WriteLine("\nPosisi Kareakter Game\n");

            int nim = 1030824008;
            PosisiKarakterGame pemain = new PosisiKarakterGame();

            Console.WriteLine(" Simulasi Perubahan State: ");

            pemain.TekanTombol("Tombol W", nim);
            pemain.TekanTombol("Tombol X", nim);
            pemain.TekanTombol("Tombol S", nim);
            pemain.TekanTombol("Tombol W", nim);
        }
    }
}

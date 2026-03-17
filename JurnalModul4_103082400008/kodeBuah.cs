using System;
using System.Collections.Generic;
using System.Text;

namespace JurnalModul4_103082400008
{
    internal class kodeBuah
    {
        public string getkodeBuah(string namaBuah)
        {
            List<string> buah = new List<string>()

        {
            "Apel", "Aprikot", "Alpukat", 
            "Pisang", "Paprika", "Blackberry",
            "Ceri", "Kelapa", "Jagung", 
            "Kurma", "Durian", "Anggur", "Melon", "Semangka"
        };
            List<string> kode = new List<string>()
            {
                "A00", "B00", "C00",
                "D00", "E00", "F00",
                "H00", "I00", "J00",
                "K00", "L00", "M00",
                "N00", "O00"

            };

            for (int i = 0; i < buah.Count; i++)
            {
                if (buah[i] == namaBuah)
                {
                    return kode[i];
                }
            }
            return "buah tidak ditemukan";

        }
    }
}

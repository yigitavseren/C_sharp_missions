using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[21];

            for (int x = 0; x <= 20; ++x)
            {
                sayilar[x] = x + 1;
            }

            for (int x = 0; x <= 20; ++x) {
                Console.WriteLine(sayilar[x]);

            }

            Console.WriteLine("\nTek sayılar bunlardır: ");
            for (int x = 0; x <= 20; ++x) 
            {
                if (sayilar[x] % 2 == 1)
                {
                    Console.WriteLine(sayilar[x]);
                }
            }

            int toplam = 0;
            for (int x = 0; x <= 20; ++x)
            {
                toplam += sayilar[x];
            }

            double ort = 0;
            ort = toplam / 21;

            Console.WriteLine($"\nToplam şudur: {toplam}");
            Console.WriteLine($"Ortalama şudur: {ort}");
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Sayı {i + 1}: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enbuyuk = sayilar[0];
            int enkucuk = sayilar[0];

            for(int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enbuyuk)
                {
                    enbuyuk = sayilar[i];
                }

                if (sayilar[i] < enkucuk)
                {
                    enkucuk = sayilar[i];
                }
            }

            Console.WriteLine($"En büyük değer {enbuyuk}");
            Console.WriteLine($"En küçük değer {enkucuk}");
        }
    }
}

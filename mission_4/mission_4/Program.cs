using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] sayilar = new int[11];

            for (int x = 0; x <= 10; ++x)
            {
                sayilar[x] = x;
            }

            Console.WriteLine("Dizinin elemanları. ");
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}

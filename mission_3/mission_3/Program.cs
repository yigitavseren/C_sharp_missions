using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayı pozitiftir.");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Sayı sıfırdır. ");
            }
            else 
            {
                Console.WriteLine("Sayı negatiftir ");
            }
            
            Console.WriteLine("\nYaşınızı giriniz ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi2 > 18)
            {
                Console.WriteLine("Ehliyet alabilirsiniz. ");
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsınız yaşınız tutmuyor. ");
            }
        }
    }
}

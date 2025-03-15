using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            double y = 6.7;
            string f = "Mahmut";
            bool s = false;

            Console.WriteLine("Lütfen bir isim giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine($"Merhaba, {isim}!");

            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            double kare = Math.Pow(sayi, 2);
            Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");

            Console.ReadLine();
        }
    }
}

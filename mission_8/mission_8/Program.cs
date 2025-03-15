using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+ , - , * , /) ");
            char islem = Convert.ToChar(Console.ReadLine());

            double sonuc = 0;

            switch (islem)
            {
                case '+':
                    sonuc = topla(sayi1 , sayi2);
                    break;
                case '-':
                    sonuc = cıkar(sayi1 , sayi2);
                    break;
                case '*':
                    sonuc = carp(sayi1 , sayi2);
                    break;
                case '/':
                    if (sayi2 != 0)
                    {
                        sonuc = bol(sayi1 , sayi2);
                    }
                    else
                    {
                        Console.WriteLine("Hata:Bir sayı sıfıra bölünemez.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçtiniz tekrar deneyiniz.");
                    return;
                    
            }
            Console.WriteLine($"Sonuç:{sonuc}");

        }
        static double topla(double sayi1, double sayi2) => sayi1 + sayi2;
        static double cıkar(double sayi1, double sayi2) => sayi1 - sayi2;
        static double carp(double sayi1, double sayi2) => sayi1 * sayi2;
        static double bol(double sayi1, double sayi2) => sayi1 / sayi2;

    }
}

using System;

namespace mission_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            static int ikilecarp(int sayi)
            {
                return sayi * 2;
            }

            Console.WriteLine(ikilecarp(sayi));

            Console.WriteLine("Karesi alıncak sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            static double kareal(double sayi2)
            {
                return Math.Pow(sayi2,2);
            }

            Console.WriteLine(kareal(sayi2));

            Console.WriteLine("Bir pozitif sayı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            static string tekmiciftmi(int sayi3)
            {
                if (sayi3 < 0)
                {
                    return "Sayı negatiftir tekrar deneyiniz. ";
                }
                else if (sayi3 % 2 == 0)
                {
                    return "Sayı çifttir ";
                }
                else
                {
                     return "Sayı tektir ";
                }

          
            }

            Console.WriteLine(tekmiciftmi(sayi3));

            Console.WriteLine("Faktöriyeli yazılcak sayıyı giriniz: ");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            static int faktoriyel(int sayi4)
            {
                int sonuc = 1;
                for (; sayi4 > 0; --sayi4)
                {
                    sonuc *= sayi4;
                    
                }
                return sonuc;
            }

            Console.WriteLine(faktoriyel(sayi4));
        }
    }
}

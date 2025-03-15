using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane değer girmek istediğinizi yazınız: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i+1}. sayi: ");
                int deger = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = deger;
            }

            terscevir(sayilar);

            Console.WriteLine("Ters çevrilmiş dizi: ");
            Console.WriteLine(string.Join(",", sayilar));
        }
        static void terscevir(int[] dizi)
        {
            int uzunluk = dizi.Length;
            for(int i = 0;i < uzunluk / 2; i++)
            {
                int temp = dizi[i];
                dizi[i] = dizi[uzunluk - 1 - i];
                dizi[uzunluk - 1 - i] = temp;
            }
        }
    }
}

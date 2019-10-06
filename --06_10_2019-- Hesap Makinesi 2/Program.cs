using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __06_10_2019___Hesap_Makinesi_2
{
    class Program
    {
        static void Main(string[] args)
        {
        basa:
            Console.Clear();
            int s1, s2;
            char secim,devammi;
            Console.WriteLine("1. Sayıyı Giriniz");
            s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz");
            s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("İşlem Seçiniz \n+: Toplama \n-: Çıkarma \n*: Çarpma \n/: Bölme");
            secim = char.Parse(Console.ReadLine());
            switch (secim)
            {
                case '+':
                    Console.WriteLine("Toplam: {0}", s1 + s2);
                    break;
                case '-':
                    Console.WriteLine("Fark: {0}", s1 - s2);
                    break;
                case '*':
                    Console.WriteLine("Çarpım: {0}", s1 * s2);
                    break;
                case '/':
                    Console.WriteLine("Bölüm: {0}", s1 / s2);
                    break;
                default:
                    Console.WriteLine("Doğru işlem seçmediniz");
                    break;
            }
            Console.Write("Devam Etmek İstiyormusunuz?:(e,E/h,H)");
            devammi = char.Parse(Console.ReadLine());
            if (devammi == 'e' || devammi == 'E')
            goto basa; 
            else
                Console.WriteLine("İşlem Bitti");
            Console.ReadKey();     
        }
    }
}

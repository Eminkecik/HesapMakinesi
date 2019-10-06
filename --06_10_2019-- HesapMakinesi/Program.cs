using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __06_10_2019___HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ksecim;
            Console.WriteLine("--- 4 İşlemli Hesap Makinesi ---");
            Console.WriteLine();
            Console.WriteLine("[+] : Toplama İşlemi");
            Console.WriteLine("[-] : Çıkarma İşlemi");
            Console.WriteLine("[*] : Çarpma İşlemi");
            Console.WriteLine("[/] : Bölme İşlemi");
            Console.WriteLine();
            Console.Write("4 İşlemden Bir Tanesini Seçiniz: ");
            ksecim = Console.ReadLine();
            switch (ksecim)
            {
                case "+": Console.WriteLine("Toplama İşlemini Seçtiniz");break;
                case "-": Console.WriteLine("Çıkarma İşlemini Seçtiniz");break;
                case "*": Console.WriteLine("Çarpma İşlemini Seçtiniz");break;
                case "/": Console.WriteLine("Bölme İşlemini Seçtiniz");break;
                default: Console.WriteLine("Yanlış Sembol Girişi!!");break;
            }
            int s1, s2, t, f, c, b;
            Console.Write("Birinci Sayıyı Giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            switch (ksecim)
            {
                case "+": t = s1 + s2; Console.WriteLine("Toplam: "+t);break;
                case "-": f = s1 - s2; Console.WriteLine("Fark: " + f);break;
                case "*": c = s1 * s2; Console.WriteLine("Çarpım: "+c);break;
                case "/": b = s1 / s2; Console.WriteLine("Bölüm: " +b);break;
            }

            Console.ReadLine();

        }
    }
}

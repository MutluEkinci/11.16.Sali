using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp6
{
    class Program
    {
        static void Islem(int s)
        {
            Console.WriteLine("Metod icinde [once] {0}", s);
            s = 111;
            Console.WriteLine("Metod icinde [sonra] {0},", s);
        }

        static void Islem(int[] s)
        {
            Yaz(s, "metod icinde[once] ");
            for (int i = 0; i < s.Length; i++)
                s[i] = 111;
            Yaz(s, "metod icinde[sonra] ");
        }

        static void Yaz(int[] dizi, string str) { };


        static void Main(string[] args)
        {

            int sayi = -11;
            Islem(sayi);
            Console.WriteLine("Metod cagirildiktan sonra {0}",sayi);

            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            Islem(sayilar);
            Yaz(sayilar,"metod cagirildiktan sonra");
            





        }
    }
}

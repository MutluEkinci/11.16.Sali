using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] TekSayilar(int[] sayilar)
        {
            int sayac = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 1)
                    sayac++;
            }
            int[] tekSayilar = new int[sayac];
            int counter = 0;
            foreach(int sayi in sayilar)
            {
                if(sayi % 2 ==1)
                {
                    tekSayilar[counter] = sayi;
                    counter++;
                }

            }
            return tekSayilar;


        }
        static void Main(string[] args)
        {

            //Soru1: Paremetre olarak tamsayı dizisi göbderilen bir method ile dizinin tek sayı olan elemanlarını geriye döndüren metohodu yazınız.

            int[] dizi = { 1, 2, 4, 5, 8, 10, 12, 16, 9 };
            
            foreach(int s in TekSayilar(dizi))
                Console.WriteLine(s);
            Console.WriteLine(TekSayilar(dizi));


        }
    }
}

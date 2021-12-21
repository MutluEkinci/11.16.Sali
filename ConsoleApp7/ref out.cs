using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Test(ref int sayi)
        {
            sayi = 111;
        }
        static void Test_out(out int sayi)
        {
            sayi = 111;
        }
        static void Main(string[] args)
        {
            //ref out
            int s = 12;
            Test(ref s);
            Console.WriteLine(s);
            //ramdaki karşılığı 111 olduğu için 111 yazdı.12 referans bir numara.

            //out
            int s2;
            Test_out(out s2);;
            Console.WriteLine(s2);

            //Soru : TryParse metodunu kullanınız.

            //int sayi = int.Parse();
            //Console.WriteLine(sayi);

            //int sonuc; ekstra değişken tanımlamak yerine out kullanırken parantez içinde tanımlayabilirsin.
            bool kontrol = int.TryParse(Console.ReadLine(), out int sonuc);
            if(kontrol)
                Console.WriteLine(sonuc);
            




        }
    }
}

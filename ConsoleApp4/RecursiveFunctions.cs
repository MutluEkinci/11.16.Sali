using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        //stackoverflow olacağından işletim sistemi programı sonlandırır...
        static int hesapla(int sayi)
        {
            return hesapla(sayi);
        }
        static long Faktoriyel(long sayi)
        {
            if (sayi == 1) return 1; //sonlandırıcı
            return sayi * Faktoriyel(sayi-1);
        }
        static void Main(string[] args)
        {

            //Recursive Functions(yinelemeli fonksiyonlar)
            //Bir fonksiyonun sürekli kendini çağırması 
            //hesapla(12);

            Console.WriteLine(Faktoriyel(30));

            //byte max değeri 256dır ve biz 300 yazdığımız zaman 256lık yer dolar ve bi sonrakine geçer ve saymaya baştan başlar.O yüzden 44 yazar.Tüm değişkenler için geçerlidir.
            int sayi = 300;
            byte b = (byte)sayi;
            Console.WriteLine(b);
            


        }
    }
}

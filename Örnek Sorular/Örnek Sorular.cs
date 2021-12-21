using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Sorular
{
    class Program
    {
        static int SayiTut ()
        {
            Random rnd = new Random();
            return rnd.Next(1,101);
        }
        
        static string HakGoster(byte hak)
        {
            string str = "";
            for (int i = 0; i < hak; i++)
                str += "0";
            return str;   
        }
        static string UzaklıkDurumu(int tutulansayi,int tahmin)
        {
            string mesaj = " ";
            int uzaklık = Math.Abs(tutulansayi - tahmin);
            if (uzaklık <= 10) mesaj = "Çok yakın";

            else if (uzaklık >10 && uzaklık <=20)
                    mesaj = "Yakın";

            else if (uzaklık > 20  && uzaklık <= 30) 
                    mesaj = "Uzak";

            else if (uzaklık > 30) 
                mesaj = "Çok Uzak...";


            return mesaj;
        }
        static void Main(string[] args)
        {
            //Soru 4:Sayı tutma oyunu 
            //pc 1-100 arasında bir sayı tutacak...
            //5 deneme hakkı var.her denemede 1 azalacak
            //10 birim yakınsa: çok yakın 
            //10-20 arası : yakın 
            //20-30 arası uzak
            //30 dan büyükse çok uzak
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(1, 101));            
            //Console.WriteLine(Math.Abs(-10));

            int tutulanSayi =  SayiTut();
            byte hak = 5;

            Console.WriteLine(tutulanSayi);
            do
            {                
                Console.WriteLine(HakGoster(hak));
                Console.Write("Değer giriniz");
                int tahmin = int.Parse(Console.ReadLine());
                hak--;

                if (tutulanSayi == tahmin)
                {
                    Console.WriteLine("Tebrikler");
                    break;
                }

                Console.WriteLine(UzaklıkDurumu(tutulanSayi, tahmin));


            } while (hak > 0);

            Console.WriteLine("Oyun Bitti");

            








        }
    }
}

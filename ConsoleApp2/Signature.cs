using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Yaz()
        {
            Console.WriteLine("Yaz");
        }
        static void Yaz(string str)
        {
            Console.WriteLine("Yaz" + str);
        }
        static void Yaz(int ins)
        {
            Console.WriteLine("Yaz" + ins);
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            //Metodlarda İmza(Signature):Aynı isimde birden fazla metod yazmak istiyorsak 'İMZA'ları farklı olmak zorunda.
            //İmzayı oluşturan iki kriter vardır.
            //Birincisi parametre sayısı.
            //İkinicisi parametre tipleri.Bu ikisi birbirinden farklı olduğu sürece istediğimiz kadar yazabiliriz.
            

            Yaz();
            Yaz("Merhaba");
            Yaz(12);


        }
    }
}

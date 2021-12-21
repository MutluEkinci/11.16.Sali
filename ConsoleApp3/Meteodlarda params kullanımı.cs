using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void GTA()
        {
            Console.WriteLine("GTA");
        }

        static void GTA(string gta3)
        {
            Console.WriteLine("GTAV" + gta3);
        }
        static void GTA(int online)
        {
            Console.WriteLine("GTA" + online);
        }
        static void GTA(double V)
        {
            Console.WriteLine("GTA" + V);
        }

        static void GTA(byte III)
        {
            Console.WriteLine("GTA" + III);
        }
        static void GTA(long IV)
        { 
            Console.WriteLine("GTA" + IV);
        }

        static int Sum(params int[] sayilar)
        {
            int total = 0;
            foreach (int sayi in sayilar)
                total += sayi;
            return total;

        }        
        static void Main(string[] args)
        {
            //Meteodlarda params kullanımı...
            //Bİrden fazla parametre olan durumlarda params en son parametre olmak zorunda!!
            GTA(12);
            Console.WriteLine(Sum(1,23,4));
            Console.WriteLine(Sum(1, 23, 4,45,76,7,3));
            Console.WriteLine(Sum(1, 23, 4,6,7,87,87,8,98,9,31,1,1,1));


        }
    }
}

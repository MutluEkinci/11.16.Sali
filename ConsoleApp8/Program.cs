using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static string[] Bol(string str, char c = ' ')
        {
            int sayac = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == c) sayac++;
            sayac++;
            Console.WriteLine(sayac);

            string ifade = "";
            int indis = 0;
            string[] kelimeler = new string[sayac];

            for (int i=0;i< str.Length;i++)
            {
                if (str[i] != c)
                {
                    ifade += str[i];
                }
                else
                {
                    kelimeler[indis] = ifade;
                    indis++;
                    ifade = "";
                }
            }
            kelimeler[indis] = ifade;
            return kelimeler;
        }
        static void Main(string[] args)
        {
            //soru 5: Kullanıcı tarafından girilen herhangi bir string ifadeyi istenilen char'a göre bölen metodu yazınız ,eğer herhangi bir char belirtilmemişse boşluk karakterine göre bölüm dizi döndürcek.


            string mesaj = "Bugün hava ne güzel...";

            foreach(string s in Bol(mesaj,'0'))
                Console.WriteLine(s);
        }
    }
}

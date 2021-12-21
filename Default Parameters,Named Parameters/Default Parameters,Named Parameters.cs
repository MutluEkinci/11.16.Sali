using System;

namespace Default_Parameters_Named_Parameters
{
    class Program
    {
        static void MethodA(int s1, int s2, bool kontrol = true)
        {
            Console.WriteLine($"{s1} {s2} {kontrol}");

        }
        static void Main(string[] args)
        {
            //Default Parameters,Named Parameters
            //(c# 4.0 ile gelmiştir.)
            
            MethodA(11, 22);
            MethodA(33, 44, false);
            //metod içerisinde köşeli parantes "[]" olursa isteğe bağlı kullanıldığı anlamına gelir.DEFAULT PARAMETERS OLARAK GEÇER.


            MethodA(s2: 111, kontrol:false, s1: 1);
            //iki nokta ":" olduğu zaman sıralamanın bi önemi kalmıyor.fazla tercih edilmez işi uzatır.ama okunabilirliği arttırır. NAMED PARAMETERS OLARAK GEÇER.


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aritmetik Operatorler
            /*
             * 1- Toplama (+)
             * 2- Çıkarma (-)
             * 3- Çarpma (*)
             * 4- Bölme (/)
             * 5- Mod Alma (%)
             */

            int sayi1 = 11; 
            int  sayi2 = 2;
            Console.WriteLine("Toplama: " + (sayi1 + sayi2));
            Console.WriteLine("Çıkarma: " + (sayi1 - sayi2));
            Console.WriteLine("Çarpma: " + (sayi1 * sayi2));
            Console.WriteLine("Bölme: " + (sayi1 / sayi2 ));
            Console.WriteLine("Mod: " + (sayi2 % sayi1));

            /* 
             * Karşılaştırma Operatörleri
             * 1- Küçüktür (<)
             * 1- Büyüktür (>)
             * 1- Küçük Eşittir (<=)
             * 1- Büyük Eşittir (>=)
             * 1- Eşit Eşittir yani denktir (==)
             * 1- Eşit Değildir (!=)
            

            int sayi3 = 3;
            int sayi4 = 4;

            Console.WriteLine(sayi3 < sayi4);
            Console.WriteLine(sayi3 > sayi4);
            Console.WriteLine(sayi3 <= sayi4);
            Console.WriteLine(sayi3 >= sayi4);
            Console.WriteLine(sayi3 == sayi4);
            Console.WriteLine(sayi3 != sayi4);
            */

            /* MANTIKSAL OPERATÖRLER
             * 1- Ve &&
             * 2- Veya ||
             * 3- Değil !
             */



            Console.ReadKey();
        }
    }
}

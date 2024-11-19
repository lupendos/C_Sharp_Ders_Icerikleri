using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosullar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * if -> Eğer
             * Else -> Başka
             * Else if -> Eğer başka
             */
            int odenecekTutar = 0;
            Console.WriteLine("Nur-Han Restaurant'a Hoşgeldiniz.");
            Console.WriteLine("1)Ana Yemekler\n2)Ara Yemekler\n3)Tatlılar\n4)İçecekler");
            Console.Write("Seçmek istediğiniz işlemin numarasını giriniz: ");
            int menuSecim = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (menuSecim == 1)
            {
                anaYemekBaslangic:
                Console.WriteLine("Ana Yemekler");
                Console.WriteLine("1- Köfte: 50₺");
                Console.WriteLine("2- Lahmacun: 90₺");
                Console.WriteLine("3- Cağ Kebabı: 385₺");
                Console.Write("Seçmek istediğiniz yemeğin numarasını giriniz: ");
                int anaYemekSecim = Convert.ToInt32(Console.ReadLine());
                if (anaYemekSecim == 1)
                    odenecekTutar += 50;
                else if(anaYemekSecim == 2)
                    odenecekTutar += 90;
                else if (anaYemekSecim == 3)
                    odenecekTutar += 385;
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız. Lütfen 1-3 arası değer giriniz.");
                    goto anaYemekBaslangic;
                }
                Console.WriteLine("Ödeyeceğiniz Toplam Tutar: " + odenecekTutar);
                secim:
                Console.WriteLine("Ana Yemeklere dönmek için 1, Çıkış yapmak için 2 giriniz");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    goto anaYemekBaslangic;
                }
                else if(secim == 2)
                {
                    Console.WriteLine("Bizi tercih ettiğiniz için Teşekkürler, yine bekleriz.");
                }
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız. Lütfen tekrar deneyiniz.");
                    goto secim;
                }
            }




            Console.ReadKey();
        }
    }
}

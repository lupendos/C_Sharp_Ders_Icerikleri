using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Tipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* TAMSAYILAR 
            byte sayi1 = 255; //Max Sayı
            short sayi2 = -32768;
            int sayi3 = -2147483648;
            long sayi4 = 1900000000000000000;

            Console.Write("Kimlik numaranızı giriniz: ");
            long kimlikNo = Convert.ToInt64(Console.ReadLine());

            long bardakSayisi = 250;
            */

            //ONDALIKLI SAYILAR
            /*
            double sayi1 = 12.12;
            float sayi2 = 12.12f;

            string isim = "YAĞIZ+3 VE DEMİ\"RİN-585 HARİTA TAKİP SİSTEMİ";

            char sube = '3';

            bool kapiAcikMi = true;
            bool zilCaldiMi = false;
            */


            //Noktalı virgül: Kod satırının bittiğini gösterir.
            Console.WriteLine("-------------SORU 1---------------");
            //2 sayı tanımlayın. Bu sayıların toplamını ekrana yazdırın.

            byte sayi1 = 12;
            byte sayi2 = 13;
            Console.WriteLine(sayi1 + sayi2);

            //1 sayı tanımlayın. Tanımladığınız sayı 50'den küçükse ekrana true
            //50'den büyükse ekrana false yazsın.
            Console.WriteLine("----------------SORU 2--------------------");
            short sayi3 = 40;
            Console.WriteLine(sayi3<50);

            Console.WriteLine("-----------SORU 3--------------");
            //2 sayı ve bir hafıza oluşturun. 2 sayıyı toplayın hafızaya atın
            int sayi4 = 15;
            int sayi5 = 68;
            int hafiza = sayi4 + sayi5;
            Console.WriteLine(hafiza);

            //Bir sayı tanımlayın. Sayıyı ekrana bir artırarak yazdırın.
            int sayi6 = 20;
            Console.WriteLine(++sayi6);

            //Bir azaltma
            Console.WriteLine(--sayi6);

            Console.WriteLine("YENİ");
            char kontrol = 'a';
            Console.WriteLine((int)kontrol);
            Console.ReadKey();
        }
    }
}

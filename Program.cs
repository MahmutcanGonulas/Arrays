using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            * * Dizi Tanımalama
            */

            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            /**
            * *Dizilere Değer atama ve Erişim
            */
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[0]);

            dizi[3] = 10;
            Console.WriteLine(dizi[3]);

            /**
            * *Döngülerle Dizi
            */
            //Klavyeden girilen n tane sayısının ortalaması
            Console.Write("Sayiyi gir --> ");
            int ort = 0;
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] diziOrt = new int[sayi];

            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Dizinin {0} elamanıı giriniz -> ", i + 1);
                diziOrt[i]=Convert.ToInt32(Console.ReadLine());

                ort = ort + diziOrt[i];
            }

            Console.WriteLine("**********");
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Dizi ["+i+"]= "+diziOrt[i]);
            }
            Console.WriteLine("Ortalama = "+ort/sayi);
        }
    }
}
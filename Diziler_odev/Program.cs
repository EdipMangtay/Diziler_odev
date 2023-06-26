using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlangıç değeri giriniz");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Bitiş değeri giriniz ");
            int n2 = int.Parse(Console.ReadLine());

            int[] sayilar = SayiUret(n1, n2);

            Console.WriteLine("Üretilen  Sayilar ");
            DiziYazdır(sayilar);

            Console.WriteLine("Dizi içerisindeki En büyük değer : " + EnBuyuk(sayilar));
            Console.WriteLine("Dizi içerisindeki En Küçük değer : "  + EnKucuk(sayilar));
            Console.ReadLine();


        }
        public static int[] SayiUret(int n1, int n2)
        {
            Random rnd = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(n1, n2 + 1);
            }
            return sayilar;
        }
        public static void DiziYazdır(int[] dizi)
        {
            foreach (int eleman in dizi)
            {
                Console.WriteLine(eleman + " ");

            }
            Console.WriteLine();
        }
        public static int EnBuyuk(int[] dizi)
        {
            int max = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > max)
                {
                    max = dizi[i];

                }
                
            }
            return max;
        }
        public static int EnKucuk(int[] dizi)
        {
            int min = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < min)
                {
                    min = dizi[i];

                }

            }
            return min;
        }

    }
}

using System;

namespace Donguler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "JAVA";
            string kurs4 = "Python";


            //array - dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Programlamaya baslangic icin temel kurs", "JAVA", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Foreach bitti");

            Console.WriteLine("Sayfa sonu");
        }
    }
}

// 2.Ders tarih : 1:29:30
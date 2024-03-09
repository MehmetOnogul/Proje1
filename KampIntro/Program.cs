using System;

namespace KampIntro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety
            //string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarBugun = 7.35;
            double dolarDun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Esittir Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
        }
    }
}


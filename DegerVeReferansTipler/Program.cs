using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = { 10, 20, 30 };
            int[] sayilar2 = { 100, 200, 300 };
            int[] sayilar3 = { 5, 6, 7 };
            sayilar1 = sayilar2;
            sayilar2 = sayilar3;
            sayilar3[0] = 34;
            Console.WriteLine(sayilar1[0]);

            //testtest


        }
    }
}
using System;

namespace sayıyazdır
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı yazdır");
            int sayı = 1;
            int max = 10;


            while (sayı <= max)
            {
                Console.Write(sayı + " ");
                sayı++;

            };
            Console.WriteLine();
            for (int i = 1; i <= max; i++)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            for (int i = 1; i <= max; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.Write(i + " ");

            }
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i +" ");
                if (i % 2 == 0 && i % 3 == 0)
                break;
            
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

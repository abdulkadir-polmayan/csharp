using System;

namespace not_ortalam_kaydetme
{
    class Program
    {
        static void Main(string[] args)
        {
            yukarı:
            Console.WriteLine("not bulma uygulaması");
            Console.Write("puann ver");
            decimal puan = Convert.ToDecimal(Console.ReadLine());

            char harf;
            if (puan < 0 || puan > 100)
            {
                Console.WriteLine("hatalı girdun lan");
                goto yukarı;
            }
            else if (puan < 45)
            {
                harf = 'f';
            }
            else if (puan < 70)
            {
                harf = 'd';
            }
            else
            {
                harf = 'a';
            };

            Console.WriteLine("notnunu: " + harf);
            goto yukarı;


            Console.ReadKey();
        }
    }
}

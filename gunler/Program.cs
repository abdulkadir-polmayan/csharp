
using System;

namespace gunler
{
    class Program
    {
        static void Main(string[] args)
        {
            dunler:
            Console.Write("gunn vver");
            int hgun = Convert.ToInt32(Console.ReadLine());
            string gun;
            switch (hgun)
            {
                case 1:
                    gun = "pazartesi";
                    break;
                case 2:
                    gun = "salı";
                    break;
                case 3:
                    gun = "çrasfad";
                    break;
                case 4:
                    gun = "perş";
                    break;
                case 5:
                    gun = "cuma";
                    break;
                case 6:
                    gun = "sacmerreta";
                    break;
                case 7:
                    gun = "pazer";
                    break;
                default:
                    gun = "güzgün gir len";
                    break;
            };

            Console.WriteLine(gun);
            goto dunler;

            Console.ReadKey();
        }
    }
}

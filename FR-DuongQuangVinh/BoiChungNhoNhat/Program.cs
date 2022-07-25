using System;

namespace BoiChungNhoNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b , BCNN;

            Console.WriteLine("Mời nhập a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập b");
            b = Convert.ToInt32(Console.ReadLine());
            BCNN = (a > b) ? a : b;
            while (true)
            {
                if (BCNN % a == 0 && BCNN % b == 0)
                {
                    Console.WriteLine("Boi chung nho nhat cua {0} va {1} la: {2}", a, b, BCNN);
                    break;
                }
                BCNN++;
            }

        }
    }
}

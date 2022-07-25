using System;

namespace SoHoanHao
{
    class Program
    {
        static void Main(string[] args)
        {
            int N ,S = 0;
            Console.WriteLine("Mời nhập số n:");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < N-1; i++)
            {
                if (N % i == 0)
                {
                    S += i;
                }
            }
            if (N == S )
            {
                Console.WriteLine("{0} là số hoàn hảo",N);
            }
            else
            {
                Console.WriteLine("{0} không phải số hoàn hảo",N);
            }
        }
    }
}

using System;

namespace DaySoFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Mời nhập n số đầu tiên của dãy số Fibonacci");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} so dau tien cua day so Fibonacci:",n);
            for ( int i = 0; i < n; i++)
            {
                Console.Write("{0} ", fibonacci(i));
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static int fibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;

            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}

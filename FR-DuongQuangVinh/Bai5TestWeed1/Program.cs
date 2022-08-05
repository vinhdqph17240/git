using System;

namespace Bai5TestWeed1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 6 };
            Service service = new Service();
            Console.WriteLine("Tổng lớn nhất là:",service.SumOfLongestArithmeticSequence(arr));
        }
    }
}
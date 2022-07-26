using System;

namespace MangHaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mời bạn nhập số dòng:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số cột:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arrayHaiChieu = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("phần tử arrayHaiChieu[{0},{1}] là:",i+1,j+1);
                    arrayHaiChieu[i, j] = Convert.ToInt32(Console.ReadLine()) ;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("phần tử arrayHaiChieu[{0},{1}] là: {2}", i + 1, j + 1, arrayHaiChieu[i, j]);
                    
                }
            }

        }
    }
}

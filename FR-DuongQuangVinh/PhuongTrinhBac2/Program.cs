using System;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c,x1, x2;
            Console.WriteLine("Mời nhập a:");
            a = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mời nhập b:");
            b = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mời nhập c:");
            c = (float)Convert.ToDouble(Console.ReadLine());
            float denta = (b * b) - (4 * a * c);
            Console.WriteLine("denta được tính ra là:"+ denta);
            if (denta < 0 )
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if(denta == 0)
            {
                x1 = x2 = -(b / (2 * a));
                Console.WriteLine("Phương trình có nghiệm kép"+ x1);
            }
            else
            {
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt");
                x1 = (float)(-b + Math.Sqrt(denta)) / (2 * a);
                Console.WriteLine("Nghiệm 1:"+ x1);
                x2 = (float)(-b - Math.Sqrt(denta)) / (2 * a);
                Console.WriteLine("Nghiệm 2:"+x2);
            }
        }
    }
}

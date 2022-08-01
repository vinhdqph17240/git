using System;

namespace TinhKeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            int _menu;
            do
            {
                Console.WriteLine("có cac service sau:");
                Console.WriteLine("1.Add vào list");
                Console.WriteLine("2.Xuat list");
                Console.WriteLine("3.Add vào arraylist");
                Console.WriteLine("4.Xuay arraylist");
                Console.WriteLine("5.Thoat");   
                Console.WriteLine("Moi chon sẻvice");
                _menu = int.Parse(Console.ReadLine());
                switch (_menu)
                {
                    case 1:
                        service.AddList();
                        break;
                    case 2:
                        service.XuatList();
                        break;
                    case 3:
                        service.AddArrayList();
                        break;
                    case 4:
                        service.XuatArray();
                        break;

                    default:

                        break;
                } 
            } while (_menu != 5);


        }
    }
}

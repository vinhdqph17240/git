using System;

namespace TinhDaHinh
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
                Console.WriteLine("1.Quan Ly");
                Console.WriteLine("2.Nha Khoa Hoc");
                Console.WriteLine("3.Nhan Vien");
                Console.WriteLine("4. Thoat");               
                Console.WriteLine("Moi chon sẻvice");
                _menu = int.Parse(Console.ReadLine());
                switch (_menu)
                {
                    case 1:
                        service.AddQuanLy();
                        service.XuatListQuanly();
                        break;
                    case 2:
                        service.AddNhaKhoaHoc();
                        service.XuatListNhaKhoaHoc();
                        break;
                    case 3:
                        service.AddNhanVien();
                        service.XuatListNhanVien();
                        break;
                    default:

                        break;
                }
            } while (_menu != 4);

        }
    }
}

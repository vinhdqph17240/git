using System;

namespace BaiLuyenTapOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceBook serviceBook = new ServiceBook();
            int _menu;
            do
            {
                Console.WriteLine("có cac service sau:");
                Console.WriteLine("1.Nhap sach");
                Console.WriteLine("2.Xuat sach");
                Console.WriteLine("3.Sap xep theo nam san xuat");
                Console.WriteLine("4.Sap xep theo ten tac gia");
                Console.WriteLine("5.Sap xep theo ten sach");
                Console.WriteLine("6.Update");
                Console.WriteLine("7.Delete");
                Console.WriteLine("8.Search theo ten sach");
                Console.WriteLine("9.Thoat");
                Console.WriteLine("Moi chon sẻvice");
                _menu = int.Parse(Console.ReadLine());
                switch (_menu)
                {
                    case 1:
                        serviceBook.Add();
                       
                        break;
                    case 2:

                        serviceBook.Xuat();
                        break;
                    case 3:
                        serviceBook.SapXepTheoNamXuatBan();
                        break;
                    case 4:
                        serviceBook.SapXepTheoTenTacGia();
                        break;
                    case 5:
                        serviceBook.SapXepTheoTenSach();
                        break;
                    case 6:
                        serviceBook.Update();
                        break;
                    case 7:
                        serviceBook.Delete();
                        break;
                    case 8:
                        serviceBook.SearchTenSach();
                        break;
                    default:
                        Console.WriteLine("hen gap lai");
                        break;
                }
            } while (_menu < 9);
        }
    }
}

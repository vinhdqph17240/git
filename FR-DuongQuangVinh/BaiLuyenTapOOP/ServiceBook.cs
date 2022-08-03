using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLuyenTapOOP
{
    public class ServiceBook : IServiceBook
    {
        private int _input;
        private List<Book> _lstbooks = new List<Book>();
        string _menu;
        public void Add()
        {
            Console.WriteLine("Mời bạn nhập số lượng muốn them sach : ");
            _input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _input; i++)
            {
                Book book = new Book();
                Console.WriteLine("Moi ban nhap ma sach: ");
                book.MaSach = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập ten sach: ");
                book.TenSach = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập ten tac gia: ");
                book.TenTacGia = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập nha xuat ban: ");
                book.NhaXuatBan = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập nam xuat ban: ");
                book.NamSanXuat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập so hieu ISBN: ");
                book.SoHieuISBN = Convert.ToInt32(Console.ReadLine());
                _lstbooks.Add(book);
            }
        }

        public void Delete()
        {
            Console.WriteLine("moi ban nhap ma sach can xoa: ");
            string maSach = Console.ReadLine();
            foreach (var x in _lstbooks)
            {
                if (x.MaSach == maSach)
                {
                    _lstbooks.Remove(x);
                    return;
                }
            }
        }

        public void SapXepTheoNamXuatBan()
        {
            List<Book> list = _lstbooks.OrderBy(c => c.NamSanXuat).ToList();
            foreach (var x in list)
            {
                x.inRaManHinh();
            }

        }

        public void SapXepTheoTenSach()
        {
            List<Book> list = _lstbooks.OrderBy(c => c.TenSach).ToList();
            foreach (var x in list)
            {
                x.inRaManHinh();
            }
        }

        public void SapXepTheoTenTacGia()
        {
            List<Book> list = _lstbooks.OrderBy(c => c.TenTacGia).ToList();
            foreach (var x in list)
            {
                x.inRaManHinh();
            }
        }

        public void SearchTenSach()
        {
            Console.WriteLine("moi nhap ten sach can tim:");
            string tenSach = Console.ReadLine();

            _lstbooks.Where(c => c.TenSach == tenSach).FirstOrDefault().inRaManHinh(); 
        }

        public void Update()
        {
            Console.WriteLine("moi ban nhap ma sach can sua: ");
            string maSach = Console.ReadLine();
            do
            {
                Console.WriteLine("1.Ten sach");
                Console.WriteLine("2.Ten tac gia");
                Console.WriteLine("3.Nha xuat ban  ");
                Console.WriteLine("4.Nam san xuat");
                Console.WriteLine("5.So hieu ISBN");
                Console.WriteLine("6. Khong muon sua nua=))");
                Console.WriteLine("ban muon sua gi ");
                _menu = Console.ReadLine();
                switch (_menu)
                {
                    case "1":
                        Console.WriteLine("Ten sach cu: " + _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().TenSach);
                        Console.WriteLine("moi ban nhap ten sach can sua: ");
                        _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().TenSach = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Ten tac gia cu: " + _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().TenTacGia);
                        Console.WriteLine("moi ban nhap ten sach can sua: ");
                        _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().TenTacGia = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Ten nha xuat ban cu: " + _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().NhaXuatBan);
                        Console.WriteLine("moi ban nhap nha xuat ban can sua: ");
                        _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().NhaXuatBan = Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("Nam xuat ban cu: " + _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().NamSanXuat);
                        Console.WriteLine("moi ban nhap nam xuat ban can sua: ");
                        _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().NamSanXuat = Convert.ToInt32(Console.ReadLine()) ;
                        break;
                    case "5":
                        Console.WriteLine("So hieu ISBN cu: " + _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().SoHieuISBN);
                        Console.WriteLine("moi ban nhap so hieu ISBN can sua: ");
                        _lstbooks.Where(c => c.MaSach == maSach).FirstOrDefault().SoHieuISBN = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Hen gap lai");
                        break;
                }
            } while (_menu != "6");
        }

        public void Xuat()
        {
            foreach (var x in _lstbooks)
            {
                x.inRaManHinh();
            }
        }
    }
}

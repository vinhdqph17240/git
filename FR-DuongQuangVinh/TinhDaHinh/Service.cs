using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    public class Service
    {
        private int _n;
        private List<QuanLy> _lstquanLies = new List<QuanLy>();
        private List<NhaKhoaHoc> _lstnhaKhoaHocs = new List<NhaKhoaHoc>();
        private List<NhanVien> _lstnhanViens = new List<NhanVien>();
        public void AddQuanLy()
        {
            Console.WriteLine("Moi nhap so luong quan ly muon them: ");
            _n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _n; i++)
            {
                QuanLy quanLy = new QuanLy();
                Console.WriteLine("moi nhap ten:");
                quanLy.HoTen = Console.ReadLine();
                Console.WriteLine("moi nhap nam sinh:");
                quanLy.NamSinh = Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine("moi nhap bang cap:");
                quanLy.BangCap = Console.ReadLine();
                quanLy.ChucVu = "Quan ly";
                Console.WriteLine("moi nhap bac luong:");
                quanLy.BacLuong = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("moi nhap so ngay cong:");
                quanLy.SoNgayCongTrongThang = Convert.ToInt32(Console.ReadLine());                
                _lstquanLies.Add(quanLy);
            }
        }
        public void XuatListQuanly()
        {
            foreach (var x in _lstquanLies)
            {
                x.inRaManHinhQuanLy();
            }
        }
        public void AddNhaKhoaHoc()
        {
            Console.WriteLine("Moi nhap so luong nha khoa hoc muon them: ");
            _n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _n; i++)
            {
                NhaKhoaHoc nhaKhoaHoc = new NhaKhoaHoc();
                Console.WriteLine("moi nhap ten:");
                nhaKhoaHoc.HoTen = Console.ReadLine();
                Console.WriteLine("moi nhap nam sinh:");
                nhaKhoaHoc.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("moi nhap bang cap:");
                nhaKhoaHoc.BangCap = Console.ReadLine();
              
                nhaKhoaHoc.ChucVu = "Nha Khoa Hoc";
                Console.WriteLine("moi nhap bac luong:");
                nhaKhoaHoc.BacLuong = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("moi nhap so ngay cong:");
                nhaKhoaHoc.SoNgayCongTrongThang = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("moi nhap son bai bao da cong bo:");
                nhaKhoaHoc.SoBaiBaoDaCongBo = Convert.ToInt32(Console.ReadLine());
                _lstnhaKhoaHocs.Add(nhaKhoaHoc);
            }
        }
        public void XuatListNhaKhoaHoc()
        {
            foreach (var x in _lstnhaKhoaHocs)
            {
                x.inRaManHinhQuanLy();
            }
        }
        public void AddNhanVien()
        {
            Console.WriteLine("Moi nhap so luong nhan vien muon them: ");
            _n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _n; i++)
            {
                NhanVien nhanVien = new NhanVien();
                Console.WriteLine("moi nhap ten:");
                nhanVien.HoTen = Console.ReadLine();
                Console.WriteLine("moi nhap nam sinh:");
                nhanVien.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("moi nhap bang cap:");
                nhanVien.BangCap = Console.ReadLine();

               
                Console.WriteLine("moi nhap luong trong thang:");
                nhanVien.LuongTrongThang = Convert.ToInt32(Console.ReadLine());
                
                _lstnhanViens.Add(nhanVien);
            }
        }
        public void XuatListNhanVien()
        {
            foreach (var x in _lstnhanViens)
            {
                x.inRaManHinhNhanVien();
            }
        }

    }
}

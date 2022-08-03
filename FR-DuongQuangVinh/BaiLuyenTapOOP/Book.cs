using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLuyenTapOOP
{
    class Book
    {
        private string maSach;
        private string tenSach;
        private string tenTacGia;
        private string nhaXuatBan;
        private int namSanXuat;
        private int soHieuISBN;
        public Book()
        {

        }

        public Book(string maSach, string tenSach, string tenTacGia, string nhaXuatBan, int namSanXuat, int soHieuISBN)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.TenTacGia = tenTacGia;
            this.NhaXuatBan = nhaXuatBan;
            this.NamSanXuat = namSanXuat;
            this.SoHieuISBN = soHieuISBN;
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
        public int NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public int SoHieuISBN { get => soHieuISBN; set => soHieuISBN = value; }

        public void inRaManHinh()
        {
            Console.WriteLine(" Ma sach: {0} | TenSach: {1} | TenTacGia: {2} | NhaXuatBan: {3} | NamXuatBan: {4} | SoHieuISBN: {5} ",MaSach,TenSach,TenTacGia,NhaXuatBan,NamSanXuat,SoHieuISBN);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
   public class QuanLy
    {
        private string hoTen;
        private int namSinh;
        private string bangCap;
        private string chucVu;
        private int soNgayCongTrongThang;
        private int bacLuong;
        public QuanLy()
        {

        }
        public QuanLy(string hoTen, int namSinh, string bangCap, string chucVu, int soNgayCongTrongThang, int bacLuong)
        {
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
            this.BangCap = bangCap;
            this.ChucVu = chucVu;
            this.SoNgayCongTrongThang = soNgayCongTrongThang;
            this.BacLuong = bacLuong;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int SoNgayCongTrongThang { get => soNgayCongTrongThang; set => soNgayCongTrongThang = value; }
        public int BacLuong { get => bacLuong; set => bacLuong = value; }
        public void inRaManHinhQuanLy()
        {
            Console.WriteLine("HoTen: {0} | NamSinh: {1} | BangCap: {2} | ChucVu: {3} | SoNgayCongTrongThang: {4} | BacLuong: {5} | Luong: {6}",HoTen,NamSinh,BangCap,ChucVu,SoNgayCongTrongThang,BacLuong,SoNgayCongTrongThang*BacLuong);
        }
    }
}

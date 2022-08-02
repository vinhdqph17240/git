using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
   public class NhanVien
    {
        private string hoTen;
        private int namSinh;
        private string bangCap;
        private int luongTrongThang;
        public NhanVien()
        {

        }

        public NhanVien(string hoTen, int namSinh, string bangCap, int luongTrongThang)
        {
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
            this.BangCap = bangCap;
            this.LuongTrongThang = luongTrongThang;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }
        public int LuongTrongThang { get => luongTrongThang; set => luongTrongThang = value; }
        public void inRaManHinhNhanVien()
        {
            Console.WriteLine("HoTen: {0} | NamSinh: {1} | BangCap: {2} | LuongTrongThang: {3} ", HoTen, NamSinh, BangCap, LuongTrongThang);
        }
    }
}

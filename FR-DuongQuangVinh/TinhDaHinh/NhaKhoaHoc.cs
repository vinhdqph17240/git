using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
   public class NhaKhoaHoc : QuanLy
    {
        private int soBaiBaoDaCongBo;
        public NhaKhoaHoc()
        {

        }

        public NhaKhoaHoc(int soBaiBaoDaCongBo)
        {
            this.SoBaiBaoDaCongBo = soBaiBaoDaCongBo;
        }

        public int SoBaiBaoDaCongBo { get => soBaiBaoDaCongBo; set => soBaiBaoDaCongBo = value; }
        public void inRaManHinhNhaKhoaHoc()
        {
            Console.WriteLine("HoTen: {0} | NamSinh: {1} | BangCap: {2} | ChucVu: {3} | SoNgayCongTrongThang: {4} | BacLuong: {5} | SoBaiBaoDaCongBo: {6} | Luong: {7}", HoTen, NamSinh, BangCap, ChucVu, SoNgayCongTrongThang, BacLuong,SoBaiBaoDaCongBo, SoNgayCongTrongThang * BacLuong);
        }
    }
}

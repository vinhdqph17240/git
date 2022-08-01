using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKeThua
{
    public class Service
    {
        private int _n;
        private List<SinhVien> _lstsinhViens = new List<SinhVien>();
        private ArrayList _ArrSinhVien = new ArrayList();
        public void AddList()
        {
            Console.WriteLine("Moi nhap so luong sinh vien muon them vào list");
            _n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _n; i++)
            {
                SinhVien sinhVien = new SinhVien();
                Console.WriteLine("moi nhap ten:");
                sinhVien.Name1 = Console.ReadLine();
                Console.WriteLine("moi nhap MaSV:");
                sinhVien.MaSV1 = Console.ReadLine();
                Console.WriteLine("moi nhap GioiTinh:");
                sinhVien.GioiTinh1 = Console.ReadLine();
                Console.WriteLine("moi nhap dia chi:");
                sinhVien.Address1 = Console.ReadLine();
                Console.WriteLine("moi nhap email:");
                sinhVien.Email = Console.ReadLine();
                Console.WriteLine("moi nhap tuoi:");
                sinhVien.Tuoi1 = Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine("moi nhap diem:");
                sinhVien.Diem1 = float.Parse(Console.ReadLine()) ;
                Console.WriteLine("moi nhap nganh hoc:");
                sinhVien.Nganh1 = Console.ReadLine();
                _lstsinhViens.Add(sinhVien);
            }

        }
        public void XuatList()
        {
            foreach (var x in _lstsinhViens)
            {
                x.inRaManHinhCuaSinhVien();
            }
        }
        public void AddArrayList()
        {
            Console.WriteLine("Moi nhap so luong sinh vien muon them vào array");
            _n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _n; i++)
            {
                SinhVien sinhVien = new SinhVien();
                Console.WriteLine("moi nhap ten:");
                sinhVien.Name1 = Console.ReadLine();
                Console.WriteLine("moi nhap MaSV:");
                sinhVien.MaSV1 = Console.ReadLine();
                Console.WriteLine("moi nhap GioiTinh:");
                sinhVien.GioiTinh1 = Console.ReadLine();
                Console.WriteLine("moi nhap dia chi:");
                sinhVien.Address1 = Console.ReadLine();
                Console.WriteLine("moi nhap email:");
                sinhVien.Email = Console.ReadLine();
                Console.WriteLine("moi nhap tuoi:");
                sinhVien.Tuoi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("moi nhap diem:");
                sinhVien.Diem1 = float.Parse(Console.ReadLine());
                Console.WriteLine("moi nhap nganh hoc:");
                sinhVien.Nganh1 = Console.ReadLine();
                _ArrSinhVien.Add(sinhVien);
            }
        }
        public void XuatArray()
        {
            foreach (SinhVien x in _ArrSinhVien)
            {
                x.inRaManHinhCuaSinhVien();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKeThua
{
    class SinhVien : People
    {
        private string MaSV;
        private float Diem;
        private string Nganh;
        public SinhVien()
        {

        }
        public SinhVien(string maSV, float diem, string nganh)
        {
            MaSV1 = maSV;
            Diem1 = diem;
            Nganh1 = nganh;
        }

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public float Diem1 { get => Diem; set => Diem = value; }
        public string Nganh1 { get => Nganh; set => Nganh = value; }
        public void inRaManHinhCuaSinhVien()
        {
            Console.WriteLine("Name : {0} | masv: {1} | email: {2} | Tuoi: {3} | Gioitinh: {4} | DiaChi: {5} | Nganh: {6} | Diem: {7}", Name1, MaSV1, Email, Tuoi1, GioiTinh1,Address1,Nganh1,Diem1);
        }
    }
}

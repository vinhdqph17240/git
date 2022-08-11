using System;
using System.Collections.Generic;

namespace Delegate_Event
{
    class Program
    {
        public delegate void SuKienThongBao<T>(List<T> list);
        static void Main(string[] args)
        {
            GiaDinh giaDinh = new GiaDinh();
            NgThan ngThan = new NgThan();
            giaDinh.nhanCuocGoi(ngThan);
            ngThan.GoiGD();
            ngThan.NhanThongBao(giaDinh);
            giaDinh.DuaTre();
        }
    }
}

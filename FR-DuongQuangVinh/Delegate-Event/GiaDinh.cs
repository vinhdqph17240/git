using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegate_Event.Program;

namespace Delegate_Event
{
    class GiaDinh
    {
        private string name;
        private DateTime thoiGianRaDoi;
        public event SuKienThongBao<GiaDinh> suKienThongBao;
        public List<GiaDinh> giaDinhs;
        public GiaDinh()
        {
            giaDinhs = new List<GiaDinh>();
        }

        public GiaDinh(string name, DateTime thoiGianRaDoi)
        {
            this.Name = name;
            this.ThoiGianRaDoi = thoiGianRaDoi;
        }

        public string Name { get => name; set => name = value; }
        public DateTime ThoiGianRaDoi { get => thoiGianRaDoi; set => thoiGianRaDoi = value; }
        public void DuaTre()
        {
            GiaDinh giaDinh = new GiaDinh();
            Console.WriteLine("Moi nhap ten dua tre:");
            giaDinh.Name = Console.ReadLine();
            Console.WriteLine("Thoi gian dau tre sinh ra");
            giaDinh.ThoiGianRaDoi = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            giaDinhs.Add(giaDinh);
            suKienThongBao?.Invoke(giaDinhs);

        }
        public void CuocGoi(List<NgThan> ngThans)
        {
            foreach (var x in ngThans)
            {
                Console.WriteLine(" Gia dinh da nhan duoc cuoc goi tu {0}, se thong bao cho {0} khi dua tre ra doi",x.Name);
            }
        }
        public void nhanCuocGoi(NgThan ngThan)
        {
            ngThan.suKienThongBao += CuocGoi;
        }
    }
}

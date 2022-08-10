using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegate_Event.Program;

namespace Delegate_Event
{
    class Service
    {
        public List<GiaDinh> giaDinhs;
        List<NgThan> ngThans;
        public event SuKienThongBao suKienThongBao;
        public Service()
        {
            ngThans = new List<NgThan>();
            giaDinhs = new List<GiaDinh>();
            NgThan ngThan = new NgThan("Nguyen Van A", "01649888445");
            ngThans.Add(ngThan);
            ngThan = new NgThan("Nguyen Van B", "01649888446");
            ngThans.Add(ngThan);
            ngThan = new NgThan("Nguyen Van C", "01649888447");
            ngThans.Add(ngThan);

        }
        public void DuaTre()
        {
            GiaDinh giaDinh = new GiaDinh();
            Console.WriteLine("Moi nhap ten dua tre:");
            giaDinh.Name = Console.ReadLine();
            Console.WriteLine("Thoi gian dau tre sinh ra");
            giaDinh.ThoiGianRaDoi = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            giaDinhs.Add(giaDinh);
            suKienThongBao?.Invoke(giaDinh.ThoiGianRaDoi);

        }
        public void ThongBao(DateTime dateTime)
        {
            foreach (var x in ngThans)
            {
                Console.WriteLine("Dau tre sinh ra vao luc {0} moi {1} den benh vien tham gia dinh", dateTime,x.Name);
            }
        }
        public void NhanThongBao() 
        {
            suKienThongBao += ThongBao;
        }
    }
}

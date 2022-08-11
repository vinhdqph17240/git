using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegate_Event.Program;

namespace Delegate_Event
{
    class NgThan
    {
        private string name;
        private string numberPhone;
        List<NgThan> ngThans;
        public event SuKienThongBao<NgThan> suKienThongBao;
        public List<NgThan> _lstDKy = new List<NgThan>();
        public NgThan()
        {
            ngThans = new List<NgThan>();

            NgThan ngThan = new NgThan("Nguyen Van A", "01649888445");
            ngThans.Add(ngThan);
            ngThan = new NgThan("Nguyen Van B", "01649888446");
            ngThans.Add(ngThan);
            ngThan = new NgThan("Nguyen Van C", "01649888447");
            ngThans.Add(ngThan);
        }

        public NgThan(string name, string numberphone)
        {
            this.name = name;
            this.numberPhone = numberphone;
        }

        public string Name { get => name; set => name = value; }
        public string Numberphone { get => numberPhone; set => numberPhone = value; }
        public void ThongBao(List<GiaDinh> giaDinhs)
        {
            foreach (var x in _lstDKy)
            {
                Console.WriteLine("Dau tre sinh ra vao luc {0} moi {1} den benh vien tham gia dinh", giaDinhs.ToList().Select(c => c.ThoiGianRaDoi).First(), x.Name);
            }
        }
        public void NhanThongBao(GiaDinh giaDinh)
        {
            giaDinh.suKienThongBao += ThongBao;
        }
        public void GoiGD()
        {
            foreach (var x in ngThans)
            {
                Console.WriteLine("Nguoi than ten {0} co muon goi cho gia dinh de nhan thong bao ve dua tre khong:(y/n)", x.name);
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "y")
                {
                    _lstDKy.Add(x);
                }
            }
            suKienThongBao?.Invoke(_lstDKy);
        }
        
    }
}

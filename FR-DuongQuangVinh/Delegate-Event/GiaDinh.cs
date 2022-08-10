using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class GiaDinh
    {
        private string name;
        private DateTime thoiGianRaDoi;
        public GiaDinh()
        {

        }

        public GiaDinh(string name, DateTime thoiGianRaDoi)
        {
            this.Name = name;
            this.ThoiGianRaDoi = thoiGianRaDoi;
        }

        public string Name { get => name; set => name = value; }
        public DateTime ThoiGianRaDoi { get => thoiGianRaDoi; set => thoiGianRaDoi = value; }
    }
}

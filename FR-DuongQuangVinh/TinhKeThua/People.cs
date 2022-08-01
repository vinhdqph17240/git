using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKeThua
{
   public class People
    {
        private string Name;
        private int Tuoi;
        private string GioiTinh;
        private string Address;
        private string email;

        public People()
        {

        }

        public People(string name, int tuoi, string gioiTinh, string address, string email)
        {
            Name1 = name;
            Tuoi1 = tuoi;
            GioiTinh1 = gioiTinh;
            Address1 = address;
            this.Email = email;
        }

        public string Name1 { get => Name; set => Name = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Email { get => email; set => email = value; }
       
    }
}

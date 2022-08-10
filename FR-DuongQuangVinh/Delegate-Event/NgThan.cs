using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class NgThan
    {
        private string name;
        private string numberPhone;
        public NgThan()
        {

        }

        public NgThan(string name, string numberphone)
        {
            this.name = name;
            this.numberPhone = numberphone;
        }

        public string Name { get => name; set => name = value; }
        public string Numberphone { get => numberPhone; set => numberPhone = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTimeSpan
{
    class Service
    {
        public void KhaiBao()
        {
            DateTime dateTime = new DateTime(2005, 11, 20, 12, 1, 10);
            Console.WriteLine(string.Format("{0:dd mm yyyy}", dateTime));
            string a = "2011-03-21 13:26";
            DateTime dt = DateTime.Parse(a);
            Console.WriteLine(dt);
        }
        public void SoSanh()
        {
            DateTime date1 = new DateTime(2009, 8, 1, 0, 0, 0);
            DateTime date2 = new DateTime(2009, 8, 1, 12, 0, 0);
            int result = DateTime.Compare(date1, date2);
            string relationship;

            if (result < 0)
            {
                relationship = "sớm hơn";
            }

            else if (result == 0)
            {
                relationship = "cùng thời gian với";
            }
            else
            {
                relationship = "muộn hơn";
            }


            Console.WriteLine("{0} {1} {2}", date1, relationship, date2);
        }
        public void Add()
        {
            DateTime d1 = new DateTime(2019, 3, 7, 8, 0, 15);
            TimeSpan span = new TimeSpan(115, 0, 0, 0);
            DateTime d2 = d1.Add(span);
            System.Console.WriteLine("Ban đầu DateTime = {0:y} {0:dd}", d1);
            System.Console.WriteLine("Mới DateTime = {0:y} {0:dd}", d2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string s;
            Employee people = new Employee();
            // linq where binh thuong
            foreach (Employee pp in people.lstemployees.Where(c => c.Id > 10))
            {
                pp.printToTheScreen();
            }

            Console.WriteLine("---------------------------------");
            //ExtensionMethod
            Console.WriteLine("Nhap chuoi de tim kiem");
            s = Console.ReadLine();
            foreach (Employee pp in people.lstemployees.WhereExtension(c => c.Name.Contains(s)))
            {
                pp.printToTheScreen();
            }


        }
    }
}

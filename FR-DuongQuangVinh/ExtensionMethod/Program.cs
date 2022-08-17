using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // linq where binh thuong
            string s;
            People people = new People();
            foreach (People pp in people._lstpeoples.Where(c => c.Sex == "Nu"))
            {
                pp.printToTheScreen();
            }
            Console.WriteLine("---------------------------------");
            //ExtensionMethod
            Console.WriteLine("Nhap chuoi de tim kiem");
            s = Console.ReadLine();
            foreach (People pp in people._lstpeoples.WhereExtension(s))
            {
                pp.printToTheScreen();
            }
            

        }
    }
}

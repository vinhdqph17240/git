using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class Employee
    {
        private int id;
        private string name;
        private DateTime birthday;
        public List<Employee>  lstemployees;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public Employee()
        {
            lstemployees = new List<Employee>();
            Employee employee = new Employee(1,"Nguyen Van A",DateTime.Parse("11/11/2002"));
            lstemployees.Add(employee);
            employee = new Employee(2,"Nguyen Van B",DateTime.Parse("11/12/2000"));
            lstemployees.Add(employee);
            employee = new Employee(3,"Nguyen Van C", DateTime.Parse("11/10/2003"));
            lstemployees.Add(employee);
            employee = new Employee(10, "Nguyen Van E", DateTime.Parse("11/10/2003"));
            lstemployees.Add(employee);
            employee = new Employee(11, "Nguyen Van G", DateTime.Parse("11/10/2003"));
            lstemployees.Add(employee);
            employee = new Employee(12, "Nguyen Van H", DateTime.Parse("11/10/2003"));
            lstemployees.Add(employee);
        }

        public Employee(int id, string name, DateTime birthday)
        {
            this.Id = id;
            this.Name = name;
            this.Birthday = birthday;
        }

        public void printToTheScreen()
        {
            Console.WriteLine($"ID: {Id} Name: {Name} | Birthday: {Birthday}");
        }
    }
}

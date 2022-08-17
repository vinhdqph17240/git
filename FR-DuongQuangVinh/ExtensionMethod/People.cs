using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class People
    {
        private string name;
        private string numberPhone;
        private string sex;
        public List<People> _lstpeoples;

        public People()
        {
            _lstpeoples = new List<People>();
            People people = new People("Nguyen Van A", "01649888445", "Nam");
            _lstpeoples.Add(people);
            people = new People("Nguyen Van B", "01649888446", "Nu");
            _lstpeoples.Add(people);
            people = new People("Nguyen Van C", "01649888447", "Nam");
            _lstpeoples.Add(people);
        }
        public People(string name, string numberPhone, string sex)
        {
            this.Name = name;
            this.NumberPhone = numberPhone;
            this.Sex = sex;
        }

        public string Name { get => name; set => name = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public string Sex { get => sex; set => sex = value; }
        public void printToTheScreen()
        {
            Console.WriteLine($"Name: {Name} | NumberPhone: {NumberPhone} | Sex: {Sex}");
        }
    }
}

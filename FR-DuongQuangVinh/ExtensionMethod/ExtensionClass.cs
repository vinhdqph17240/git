using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtensionClass
    {
        public static List<People> WhereExtension(this List<People> peoples, string s)
        {
            List<People> lstpeoples = new List<People>();
            foreach (var x in peoples)
            {
                if (x.Sex == s || x.Name == s || x.NumberPhone == s)
                {
                    lstpeoples.Add(x);
                }
            }
            return lstpeoples;
        }
    }
}


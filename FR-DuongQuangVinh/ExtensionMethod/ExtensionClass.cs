using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtensionClass
    {
        public static List<T> WhereExtension<T>(this List<T> peoples, Func<T,bool> predicate)
        {
            List<T> lstpeoples = new List<T>();
            foreach (var x in peoples)
            {
                if (predicate(x))
                {
                    lstpeoples.Add(x);
                }
            }
            return lstpeoples;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfomanceArray
{
    class C : IComparable
    {
        public int i { get; set; }
        public C (int integer)
        {
            i = integer;
        }

        public int CompareTo(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                throw new NullReferenceException();
            }
            C c = (C)obj;

            return i.CompareTo(c.i);
        }
    }
}

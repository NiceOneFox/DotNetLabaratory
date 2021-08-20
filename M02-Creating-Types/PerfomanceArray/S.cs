using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfomanceArray
{
    struct S : IComparable
    {
        public int i { get; set; }

        public S (int integer)
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
            S tempObj = (S)obj;
           
            return i.CompareTo(tempObj.i);
        }
    }
}

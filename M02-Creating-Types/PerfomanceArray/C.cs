using System;

namespace PerfomanceArray
{
    public class C : IComparable<C>
    {
        public int i { get; set; }
        public C (int integer)
        {
            i = integer;
        }

        public int CompareTo(C other)
        {
            // If other is not a valid object reference, this instance is greater.
            if (other == null) return 1;

            return i.CompareTo(other.i);
        }
    }
}

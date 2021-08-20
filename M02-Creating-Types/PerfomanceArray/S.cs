using System;

namespace PerfomanceArray
{
    struct S : IComparable<S>
    {
        public int i { get; set; }

        public S (int integer)
        {
            i = integer;
        }

        public int CompareTo(S other)
        {

            return i.CompareTo(other.i);
        } 
    }
}

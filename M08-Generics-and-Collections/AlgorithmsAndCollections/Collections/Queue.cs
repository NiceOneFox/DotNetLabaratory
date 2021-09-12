using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndCollections.Collections
{
    public class Queue<T>
    {
        public LinkedList<T> collection { get; set; }

        public T Dequeue()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("Queue was empty when Dequeue called");
            }
            return collection.Last();
        }

        public void Enqueue(T value)
        {          
            collection.AddFirst(value);
        }

    }
}

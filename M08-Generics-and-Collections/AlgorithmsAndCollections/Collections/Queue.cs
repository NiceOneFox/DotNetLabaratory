using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndCollections.Collections
{
    public class Queue<T> : IEnumerable<T>
    {
        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; private set; }

        public int Count { get; private set; } = 0;

        /// <summary>
        /// Retrieve object from Queue
        /// </summary>
        public T Dequeue()
        {
            if (Count == 0)
            {
                //return default; 
                throw new InvalidOperationException("Queue was empty");
            }

            T output = Head.Value;
            Head = Head.Next;
            Count--;

            return output;
        }

        /// <summary>
        /// Adds object to Queue
        /// </summary>
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            Node<T> tempNode = Tail;
            Tail = node;

            if (Count == 0)
                Head = Tail;
            else
                tempNode.Next = Tail;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        public class Node<U>
        {
            public Node<U> Next { get; set; }
            public U Value { get; set; }
            public Node(U value)
            {
                Value = value;
            }
        }

    }
}

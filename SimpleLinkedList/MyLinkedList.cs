using System;
using System.Data.SqlTypes;

namespace SimpleLinkedList
{
    public class MyLinkedList<T> : ISimpleLinkedList<T>
    {
        private readonly Node<T> _head = new Node<T>();


        // Big-O = 1
        public void AddFirst(T data)
        {
            _head.Next = new Node<T>(data, _head.Next);
        }

        // Big-O = 1
        public void Clear()
        {
            _head.Next = null;
        }

        // Big-O = N
        public void Print()
        {
            var iterator = _head.Next;

            while (iterator != null)
            {
                Console.WriteLine(iterator.Data);

                iterator = iterator.Next;
            }
        }

        // Big-O = N
        public void Insert(int index, T data)
        {
            var currentIndex = -1;
            var iterator = _head;

            while (iterator != null)
            {
                currentIndex += 1;

                if (currentIndex == index)
                {
                    iterator.Next = new Node<T>(data, iterator.Next);
                    return;
                }

                iterator = iterator.Next;
            }

            throw new IndexOutOfRangeException();
        }

        // Big-O = 1
        public void RemoveFirst()
        {
            if (_head.Next == null) return;

            _head.Next = _head.Next.Next;
        }

        // Big-O = 1
        public T GetFirst()
        {
            return _head.Next == null ? default(T) : _head.Next.Data;
        }
    }
}
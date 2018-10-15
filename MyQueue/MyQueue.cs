using System;
using System.Collections;

namespace MyQueue
{
    public class MyQueue<T> : IQueue<T>
    {
        private ArrayList _queue = new ArrayList();


        public bool IsEmpty()
        {
            return _queue.Count == 0;
        }

        public void MakeEmpty()
        {
            _queue = new ArrayList();
        }

        public T Dequeue()
        {
            var dequeued = (T) _queue[0];
            _queue.RemoveAt(0);

            return dequeued;
        }

        public void Enqueue(T data)
        {
            _queue.Add(data);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{
    public class PriorityQueue<T> where T : IComparable
    {
        private const int DefaultSize = 100;
        private readonly T[] _heap = new T[DefaultSize + 1];
        private int _currentSize;

        /// <summary>
        /// Create empty PriorityQueue
        /// </summary>
        public PriorityQueue()
        {
        }


        /// <summary>
        /// Creates a PriorityQueue from the given collection
        /// </summary>
        /// <param name="collection"></param>
        public PriorityQueue(IReadOnlyCollection<T> collection)
        {
            _currentSize = collection.Count;

            var i = 1;
            foreach (var element in collection)
                _heap[i++] = element;

            BuildHeap();
        }

        /// <summary>
        /// Gets the first element in the priority queue
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NoSuchElementException"></exception>
        public T Peek()
        {
            if (IsEmpty())
                throw new NoSuchElementException();

            return _heap[1];
        }

        /// <summary>
        /// Checks if heap is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() =>
            _currentSize == 0;

        public void Clear() =>
            _currentSize = 0;

        /// <summary>
        /// Add given element on correct position in priority queue
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Enqueue(T value)
        {
            var hole = ++_currentSize;
            _heap[0] = value;

            for (; value.CompareTo(_heap[hole / 2]) < 0; hole /= 2)
                _heap[hole] = _heap[hole / 2];

            _heap[hole] = value;

            PercolateDown(hole);

            return true;
        }

        /// <summary>
        /// Removes the smallest item in the priority queue
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            // Temporarily save the first element
            var minItem = Peek();

            // Remove first element from queue
            _heap[1] = _heap[_currentSize--];
            PercolateDown(1);

            return minItem;
        }

        /// <summary>
        /// Methods to percolate down in the heap
        /// </summary>
        /// <param name="hole">The index at which the percolate begins</param>
        private void PercolateDown(int hole)
        {
            int child;
            var temporary = _heap[hole];

            for (; hole * 2 <= _currentSize; hole = child)
            {
                child = hole * 2;

                if (child != _currentSize && _heap[child + 1].CompareTo(_heap[child]) < 0)
                    child++;

                if (_heap[child].CompareTo(temporary) < 0)
                    _heap[hole] = _heap[child];

                else
                    break;
            }

            _heap[hole] = temporary;
        }

        /// <summary>
        /// Establish heap order property from an arbitrary
        /// arrangement of items. Runs in linear time
        /// </summary>
        private void BuildHeap()
        {
            for (var i = _currentSize / 2; i > 0; i--)
                PercolateDown(i);
        }

        /// <summary>
        /// Print priority queue pre-order
        /// </summary>
        /// <returns></returns>
        public string ToStringPreOrder(PriorityQueue<T> queue)
        {
            if (queue.IsEmpty()) return "";

            var result = queue.Dequeue().ToString();

            while (!queue.IsEmpty())
                result += " " + queue.Dequeue().ToString();

            return result;
        }

        public string ToStringPreOrder() => ToStringPreOrder(this);
    }

    #region Custom error classes

    internal class NoSuchElementException : Exception
    {
    }

    #endregion
}
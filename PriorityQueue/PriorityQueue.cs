using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{
    public class PriorityQueue<T> where T : IComparable
    {
        public T[] _heap;
        private int _currentSize;

        /// <summary>
        /// Create empty PriorityQueue
        /// </summary>
        public PriorityQueue()
        {
            _heap = new T[2];
        }


        /// <summary>
        /// Creates a PriorityQueue from the given collection
        /// </summary>
        /// <param name="collection"></param>
        public PriorityQueue(IReadOnlyCollection<T> collection)
        {
            _currentSize = collection.Count;
            _heap = new T[_currentSize + 1];

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

        /// <summary>
        /// Sets the _currentSize to 0, this implies that the queue has been cleared.
        /// </summary>
        public void Clear() =>
            _currentSize = 0;

        /// <summary>
        /// Add given element on correct position in priority queue
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Enqueue(T value)
        {
            if (_currentSize + 1 == _heap.Length)
                DoubleArray();

            // Percolate up
            var hole = ++_currentSize;
            _heap[0] = value;

            for (; value.CompareTo(_heap[hole / 2]) < 0; hole /= 2)
                _heap[hole] = _heap[hole / 2];

            _heap[hole] = value;

            return true;
        }

        /// <summary>
        /// Removes the smallest item in the priority queue
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            var minItem = Peek();

            // Get rid of the last leaf/decrement
            _heap[1] = _heap[_currentSize--];

            // Arrange the tree to fulfill the properties
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
        /// Double array to make sure we can insert more items
        /// </summary>
        private void DoubleArray()
        {
            Array.Resize(ref _heap, _heap.Length * 2);
        }

        /// <summary>
        /// It's not possible to print a priority queue without from lowest to highest value without
        /// dequeuing every value and thus emptying the queue. To work around this issue a new PriorityQueue instance
        /// is created.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        /// <returns></returns>
        public override string ToString()
        {
            var heapCopy = new T[_currentSize];
            Array.Copy(_heap, 1, heapCopy, 0, _currentSize);
            
            var queue = new PriorityQueue<T>(heapCopy);
            var processedQueue = "";
            
            while (!queue.IsEmpty())
                processedQueue += queue.Dequeue() + " ";

            return processedQueue;
        }

        /// <summary>
        /// Print PriorityQueue with pre-order traversal
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string ToStringPreOrder(int index = 0)
        {
            if (index >= _currentSize)
                return "";

            var result = _heap[index + 1] + " "; // Root
            result += ToStringPreOrder((2 * index) + 1); // Left subtree
            result += ToStringPreOrder((2 * index) + 2); // Right subtree

            return result;
        }

        /// <summary>
        /// Print PriorityQueue with pre-order traversal
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string ToStringPostOrder(int index = 0)
        {
            if (index >= _currentSize)
                return "";

            var result = ToStringPostOrder((2 * index) + 1); // Left subtree
            result += ToStringPostOrder((2 * index) + 2); // Right subtree
            result += _heap[index + 1] + " "; // Root

            return result;
        }

        /// <summary>
        /// Print PriorityQueue with pre-order traversal
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string ToStringInOrder(int index = 0)
        {
            if (index >= _currentSize)
                return "";

            var result = ToStringInOrder((2 * index) + 1); // Left subtree
            result += _heap[index  + 1] + " "; // Root
            result += ToStringInOrder((2 * index) + 2); // Right subtree

            return result;
        }
    }

    #region Custom error classes

    internal class NoSuchElementException : Exception
    {
    }

    #endregion
}
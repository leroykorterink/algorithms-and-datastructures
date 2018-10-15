using System;

namespace SinglyLinkedList
{
    public class SinglyLinkedList
    {
        private readonly ListNode _head = new ListNode();

        /// <summary>
        /// Checks whether the SinglyLinkedList head empty
        /// </summary>
        public bool IsEmpty() => _head.Next == null;

        /// <summary>
        /// Checks whether SinglyLinkedList is empty
        /// </summary>
        public void MakeEmpty() => _head.Next = null;

        /// <summary>
        /// Return an iterator representing the header node
        /// </summary>
        /// <returns></returns>
        public SinglyLinkedListIterator Zeroth() => new SinglyLinkedListIterator(_head);

        /// <summary>
        /// Return an iterator representing the first node in the list
        /// </summary>
        /// <returns></returns>
        public SinglyLinkedListIterator First() => new SinglyLinkedListIterator(_head.Next);

        /// <summary>
        /// Insert new node into SinglyLinkedList after given iterator
        /// </summary>
        /// <param name="data"></param>
        /// <param name="iterator"></param>
        public void Insert(object data, SinglyLinkedListIterator iterator)
        {
            // Only add new node when node in iterator is not empty
            if (iterator?.Current == null) return;

            // Change current next property to the new ListNode 
            iterator.Current.Next = new ListNode(data, iterator.Current.Next);
        }

        /// <summary>
        /// Removes ListNode that matches given data
        /// </summary>
        /// <param name="data"></param>
        private void Remove(object data)
        {
            var iterator = FindPrevious(data);

            // There is nothing to remove
            if (iterator == null) return;
        }

        /// <summary>
        /// Return iterator corresponding to the first node containing given data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public SinglyLinkedListIterator Find(object data)
        {
            var iterator = _head.Next;

            while (iterator != null && !iterator.Data.Equals(data))
                iterator = iterator.Next;

            return new SinglyLinkedListIterator(iterator);
        }

        /// <summary>
        /// Return iterator prior to the first node containing given data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public SinglyLinkedListIterator FindPrevious(object data)
        {
            var iterator = _head.Next;

            while (iterator != null && !iterator.Next.Data.Equals(data))
                iterator = iterator.Next;

            return new SinglyLinkedListIterator(iterator);
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Current list is empty.");
                return;
            }

            var iterator = First();

            for (; iterator.IsValid(); iterator.Advance())
                Console.Write(iterator.Retrieve() + ", ");
        }
    }
}
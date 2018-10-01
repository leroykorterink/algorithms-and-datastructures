using System;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        private readonly ListNode _head = new ListNode();

        /// <summary>
        /// Checks whether the DoublyLinkedList head emtpy
        /// </summary>
        public bool IsEmpty() => _head.Next == null;

        /// <summary>
        /// Checks whether DoublyLinkedList is emtpy
        /// </summary>
        public void MakeEmpty() => _head.Next = null;

        /// <summary>
        /// Return an iterator representing the header node
        /// </summary>
        /// <returns></returns>
        public DoublyLinkedListIterator Zeroth() => new DoublyLinkedListIterator(_head);

        /// <summary>
        /// Return an iterator representing the first node in the list
        /// </summary>
        /// <returns></returns>
        public DoublyLinkedListIterator First() => new DoublyLinkedListIterator(_head.Next);

        /// <summary>
        /// Insert new node into DoublyLinkedList after given iterator
        /// </summary>
        /// <param name="data"></param>
        /// <param name="iterator"></param>
        public void Insert(object data, DoublyLinkedListIterator iterator)
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
        public DoublyLinkedListIterator Find(object data)
        {
            var iterator = _head.Next;

            while (iterator != null && !iterator.Data.Equals(data))
                iterator = iterator.Next;

            return new DoublyLinkedListIterator(iterator);
        }

        /// <summary>
        /// Return iterator prior to the first node containing given data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public DoublyLinkedListIterator FindPrevious(object data)
        {
            var iterator = _head.Next;

            while (iterator != null && !iterator.Next.Data.Equals(data))
                iterator = iterator.Next;

            return new DoublyLinkedListIterator(iterator);
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Current list is emtpy.");
                return;
            }

            var iterator = First();

            for ( ; iterator.IsValid; iterator.Advance())
                Console.Write(iterator.Retrieve() + ", ");
        }
    }
}
namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        private readonly ListNode _head = new ListNode();

        private ListNode First => _head.Next;

        /// <summary>
        ///     Checks whether SinglyLinkedList is emtpy
        /// </summary>
        private bool IsEmpty()
        {
            return _head.Next == null;
        }

        /// <summary>
        /// </summary>
        /// <param name="data"></param>
        private void Insert(object data)
        {
            var current = _head;

            current.Next = new ListNode(data, current.Next);
        }

        private void Remove()
        {
        }
    }
}
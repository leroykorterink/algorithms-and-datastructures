namespace DoublyLinkedList
{
    public class DoublyLinkedListNode
    {
        public object Data;

        internal DoublyLinkedListNode(object data = null, DoublyLinkedListNode next = null, DoublyLinkedListNode previous = null)
        {
            Data = data;
            Next = next;
            Previous = previous;
        }

        internal DoublyLinkedListNode Next { get; set; }
        
        internal DoublyLinkedListNode Previous { get; set; }
    }
}
namespace DoublyLinkedList
{
    public class ListNode
    {
        private object Data;

        internal ListNode(object data = null, ListNode next = null)
        {
            Data = data;
            Next = next;
        }

        internal ListNode Next { get; set; }
    }
}
namespace DoublyLinkedList
{
    public class DoublyLinkedListIterator
    {
        public ListNode Current;

        public DoublyLinkedListIterator(ListNode listNode)
        {
            Current = listNode;
        }

        public bool IsValid => Current != null;

        public object Retrieve() => IsValid ? Current.Data : null;

        public void Advance()
        {
            if (IsValid)
                Current = Current.Next;
        }
    }
}
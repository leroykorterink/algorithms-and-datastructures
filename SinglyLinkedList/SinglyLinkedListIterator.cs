namespace SinglyLinkedList
{
    public class SinglyLinkedListIterator
    {
        public ListNode Current;

        public SinglyLinkedListIterator(ListNode listNode)
        {
            Current = listNode;
        }

        public bool IsValid() => Current != null;

        public object Retrieve() => IsValid() ? Current.Data : null;

        public void Advance()
        {
            if (IsValid())
                Current = Current.Next;
        }
    }
}
namespace DoublyLinkedList
{
    public class DoublyLinkedListIterator
    {
        public DoublyLinkedListNode Current;

        public DoublyLinkedListIterator(DoublyLinkedListNode doublyLinkedListNode)
        {
            Current = doublyLinkedListNode;
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
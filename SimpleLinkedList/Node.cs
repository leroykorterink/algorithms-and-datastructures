namespace SimpleLinkedList
{
    public class Node<T>
    {
        public Node<T> Next;
        public T Data;

        public Node()
        {
        }

        public Node(T data, Node<T> next) : this(data)
        {
            Next = next;
        }

        public Node(T data)
        {
            Data = data;
        }
    }
}
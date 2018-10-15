namespace MyQueue
{
    public interface IQueue<T>
    {
        bool IsEmpty();

        void MakeEmpty();

        T Dequeue();

        void Enqueue(T data);
    }
}
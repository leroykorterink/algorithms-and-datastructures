using System;
using SimpleLinkedList;

namespace MyStack
{
    public class MyStack<T> : IStack<T>
    {
        private readonly MyLinkedList<T> _stack = new MyLinkedList<T>();
        
        public void Push(T data)
        {
            _stack.AddFirst(data);
        }

        public T Pop()
        {
            var first = _stack.GetFirst();
            _stack.RemoveFirst();

            return first;
        }

        public T Top()
        {
            return _stack.GetFirst();
        }
    }
}
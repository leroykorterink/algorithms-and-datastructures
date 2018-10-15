using System;
using MyStack;
using Xunit;

namespace MyStackTests
{
    public class MyStackTests
    {
        [Fact]
        public void Should_PushToStack()
        {
            var myStack = new MyStack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            Assert.Equal(3, myStack.Top());
        }

        [Fact]
        public void Should_PopFromStack()
        {
            var myStack = new MyStack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            Assert.Equal(3, myStack.Pop());
            Assert.Equal(2, myStack.Top());
        }
    }
}
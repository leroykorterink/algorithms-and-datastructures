using System;
using SimpleLinkedList;
using Xunit;

namespace SimpleLinkedListTests
{
    public class SimpleLinkedListTests
    {
        [Fact]
        public void Should_AddGivenValueToFrontAndGetFirstNode()
        {
            const int expected = 5;

            var myList = new MyLinkedList<int>();
            myList.AddFirst(expected);

            Assert.Equal(expected, myList.GetFirst());
        }

        [Fact]
        public void Should_ClearList()
        {
            var myList = new MyLinkedList<int>();

            myList.AddFirst(5);
            myList.Clear();

            Assert.Equal(0, myList.GetFirst());
        }

        [Fact]
        public void Should_RemoveFirst()
        {
            var myList = new MyLinkedList<int>();

            myList.AddFirst(5);
            myList.AddFirst(2);

            Assert.Equal(2, myList.GetFirst());

            myList.RemoveFirst();

            Assert.Equal(5, myList.GetFirst());
        }

        [Fact]
        public void Should_InsertAtGivenIndex()
        {
            const int expected = 4;
            var myList = new MyLinkedList<int>();

            myList.AddFirst(1);
            myList.AddFirst(2);
            myList.AddFirst(3);
            myList.AddFirst(5);

            myList.Insert(3, expected);

            myList.RemoveFirst();
            myList.RemoveFirst();
            myList.RemoveFirst();

            Assert.Equal(expected, myList.GetFirst());
            Assert.Throws<IndexOutOfRangeException>(() => myList.Insert(3, expected));
        }
    }
}
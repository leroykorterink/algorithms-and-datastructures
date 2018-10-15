using Xunit;
using MyQueue;

namespace MyQueueTests
{
    public class MyQueueTests
    {
        [Fact]
        public void Should_IsEmpty()
        {
            var emptyQueue = new MyQueue<int>();
            var notEmptyAfterEnqueue = new MyQueue<int>();
            var emptyAfterDequeue = new MyQueue<int>();

            notEmptyAfterEnqueue.Enqueue(1);

            emptyAfterDequeue.Enqueue(1);
            emptyAfterDequeue.Dequeue();

            Assert.True(emptyQueue.IsEmpty());
            Assert.False(notEmptyAfterEnqueue.IsEmpty());
            Assert.True(emptyAfterDequeue.IsEmpty());
        }

        [Fact]
        public void Should_MakeEmpty()
        {
            var myQueue = new MyQueue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            myQueue.MakeEmpty();

            Assert.True(myQueue.IsEmpty());
        }

        [Fact]
        public void Should_Dequeue()
        {
            var myQueue = new MyQueue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            Assert.Equal(1, myQueue.Dequeue());
        }

        [Fact]
        public void Should_Enqueue()
        {
            var myQueue = new MyQueue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);

            Assert.Equal(1, myQueue.Dequeue());
        }
    }
}
using System.Collections.ObjectModel;
using PriorityQueue;
using Xunit;
using Xunit.Abstractions;

namespace PriorityQueueTests
{
    public class PriorityQueueTests
    {
        private readonly ITestOutputHelper _output;

        public PriorityQueueTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Should_IsEmpty()
        {
            var queue = new PriorityQueue<int>();

            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void Should_BuildHeap()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73});

            Assert.Equal(
                "12 17 20 21 25 37 45 47 55 61 63 64 73 83 92",
                queue.ToStringPreOrder()
            );
        }

        [Fact]
        public void Should_Add()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63});

            queue.Enqueue(5);
            _output.WriteLine(queue.ToStringPreOrder());
            Assert.Equal(5, queue.Dequeue());            

            queue.Enqueue(15);
            _output.WriteLine(queue.ToStringPreOrder());

            Assert.Equal(5, queue.Dequeue());
        }
    }
}
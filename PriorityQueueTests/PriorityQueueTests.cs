using System;
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
        public void Should_Clear()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73});

            queue.Clear();

            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void Should_BuildHeap()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73});


            var processedQueue = "";

            while (!queue.IsEmpty())
                processedQueue += queue.Dequeue() + " ";


            Assert.Equal(
                "12 17 20 21 25 37 45 47 55 61 63 64 73 83 92 ",
                processedQueue
            );
        }

        [Fact]
        public void Should_Enqueue_And_Dequeue()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63});

            queue.Enqueue(5);
            _output.WriteLine(queue.ToStringPreOrder());

            Assert.Equal(5, queue.Dequeue());

            queue.Enqueue(15);
            _output.WriteLine(queue.ToStringPreOrder());

            Assert.Equal(12, queue.Dequeue());
        }

        [Fact]
        public void Should_ToStringPreOrder()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73});

            _output.WriteLine(queue.ToStringPreOrder());

            Assert.Equal(
                "12 17 20 91 61 21 55 37 25 45 47 64 63 83 73",
                queue.ToStringPreOrder()
            );
        }

        [Fact]
        public void Should_ToStringPostOrder()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73});

            _output.WriteLine(queue.ToStringPostOrder());

            Assert.Equal(
                "92 61 20 55 21 37 17 47 64 45 83 73 63 25 12 ",
                queue.ToStringPostOrder()
            );
        }

        [Fact]
        public void Should_ToStringInOrder()
        {
            var hoi = new [] {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73};
            
            var queue = new PriorityQueue<int>();
            var queue2 = new PriorityQueue<int>(hoi);

            foreach (var i in hoi)
                queue.Enqueue(i);

            _output.WriteLine(queue.ToString());
            _output.WriteLine(queue2.ToString());

            Assert.Equal(
                "92 20 61 17 55 21 37 12 47 45 64 25 83 63 73 ",
                queue.ToStringInOrder()
            );
        }

        [Fact]
        public void Should_ToString()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73});


            Assert.Equal(
                "12 17 20 21 25 37 45 47 55 61 63 64 73 83 92 ",
                queue.ToString()
            );
        }
    }
}
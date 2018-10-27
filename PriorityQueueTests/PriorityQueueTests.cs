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

            Assert.Equal(
                "12 17 20 21 25 37 45 47 55 61 63 64 73 83 92 ",
                queue.ToString()
            );
        }

        [Fact]
        public void Should_Enqueue_And_Dequeue()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63});

            queue.Enqueue(5);
            Assert.Equal(5, queue.Dequeue());

            queue.Enqueue(15);
            Assert.Equal(12, queue.Dequeue());
        }

        [Fact]
        public void Should_ToStringPreOrder()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73});

            _output.WriteLine(queue.ToStringPreOrder());
            
            Assert.Equal(
                "12 17 20 61 92 37 55 47 21 25 45 64 63 83 73 ",
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
                "61 92 20 55 47 37 17 45 64 25 83 73 63 21 12 ",
                queue.ToStringPostOrder()
            );
        }

        [Fact]
        public void Should_ToStringInOrder()
        {
            var queue = new PriorityQueue<int>(new Collection<int>
                {92, 47, 21, 20, 12, 25, 63, 61, 17, 55, 37, 45, 64, 83, 73});
            
            _output.WriteLine(queue.ToStringInOrder());
            
            Assert.Equal(
                "61 20 92 17 55 37 47 12 45 25 64 21 83 63 73 ",
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
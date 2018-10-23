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

            
            _output.WriteLine(queue.ToStringPreOrder());
        }
    }
}
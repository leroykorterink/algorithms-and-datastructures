using Xunit;

namespace DoublyLinkedListTests
{
    public class Tests
    {
        [Fact]
        public void Should_ReturnTrue_When_DoublyLinkedListIsEmpty()
        {
            var doublyLinkedList = new DoublyLinkedList.DoublyLinkedList();

            Assert.True(doublyLinkedList.IsEmpty());
        }

        [Fact]
        public void Should_HaveHeadNode()
        {
            var doublyLinkedList = new DoublyLinkedList.DoublyLinkedList();

            Assert.True(doublyLinkedList.Zeroth().Retrieve() == null);
        }

        [Fact]
        public void Should_InsertANode()
        {
            var doublyLinkedList = new DoublyLinkedList.DoublyLinkedList();

            // Add new node after the head node
            doublyLinkedList.Insert(5, doublyLinkedList.Zeroth());

            Assert.True((int) doublyLinkedList.First().Retrieve() == 5);
        }

        [Fact]
        public void Should_BeEmpty_When_EmptyingList()
        {
            var doublyLinkedList = new DoublyLinkedList.DoublyLinkedList();

            // Add new node after the head node
            doublyLinkedList.Insert(5, doublyLinkedList.Zeroth());

            // Empty listz
            doublyLinkedList.MakeEmpty();

            Assert.True(doublyLinkedList.First().Retrieve() == null);
        }

        [Fact]
        public void Should_FindNodeMatchingGivenData()
        {
            var doublyLinkedList = new DoublyLinkedList.DoublyLinkedList();

            const int data = 2;

            // Add new node after the head node
            doublyLinkedList.Insert(3, doublyLinkedList.Zeroth());
            doublyLinkedList.Insert(data, doublyLinkedList.Zeroth());
            doublyLinkedList.Insert(1, doublyLinkedList.Zeroth());

            Assert.True((int) doublyLinkedList.Find(data).Retrieve() == data);
        }

        [Fact]
        public void Should_FindNodePriorToNodeMatchingGivenData()
        {
            var doublyLinkedList = new DoublyLinkedList.DoublyLinkedList();

            const int data = 2;
            const int prior = 1;

            // Add new node after the head node
            doublyLinkedList.Insert(3, doublyLinkedList.Zeroth());
            doublyLinkedList.Insert(data, doublyLinkedList.Zeroth());
            doublyLinkedList.Insert(prior, doublyLinkedList.Zeroth());
            
            doublyLinkedList.Print();

            Assert.Equal(prior, doublyLinkedList.FindPrevious(data).Retrieve());
        }
    }
}
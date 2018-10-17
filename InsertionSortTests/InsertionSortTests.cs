using InsertionSort;
using Xunit;

namespace InsertionSortTests
{
    public class InsertionSortTests
    {
        [Fact]
        public void Should_SortIntegersWithInsertionSort()
        {
            var input = new[] {8, 5, 9, 2, 6, 3};
            var sortedInput = new[] {2, 3, 5, 6, 8, 9};

            InsertionSort<int>.SortArray(input);

            Assert.Equal(sortedInput, input);
        }

        [Fact]
        public void Should_SortCharactersWithInsertionSort()
        {
            var input = new[] {'d', 'c', 'a', 'b', 'f'};
            var sortedInput = new[] {'a', 'b', 'c', 'd', 'f'};

            InsertionSort<char>.SortArray(input);

            Assert.Equal(sortedInput, input);
        }
    }
}
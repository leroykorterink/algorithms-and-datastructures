using MergeSort;
using Xunit;

namespace MergeSortTests
{
    public class MergeSortTests
    {
        [Fact]
        public void Should_SortIntegersWithMergeSort()
        {
            var input = new[] {8, 5, 9, 2, 6, 3};
            var sortedInput = new[] {2, 3, 5, 6, 8, 9};

            var result = MergeSort<int>.SortArray(input);

            Assert.Equal(result, sortedInput);
        }

        [Fact]
        public void Should_SortCharactersWithMergeSort()
        {
            var input = new[] {'d', 'c', 'a', 'b', 'f'};
            var sortedInput = new[] {'a', 'b', 'c', 'd', 'f'};

            var result = MergeSort<char>.SortArray(input);

            Assert.Equal(result, sortedInput);
        }
    }
}
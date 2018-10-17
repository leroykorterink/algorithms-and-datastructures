using QuickSort;
using Xunit;

namespace QuickSortTests
{
    public class QuickSortTests
    {
        [Fact]
        public void Should_SortIntegers_With_QuickSort()
        {
            var input = new[] {8, 5, 9, 2, 6, 3};
            var sortedInput = new[] {2, 3, 5, 6, 8, 9};

            QuickSort<int>.SortArray(input);

            Assert.Equal(sortedInput, input);
        }

        [Fact]
        public void Should_SortCharacters_With_QuickSort()
        {
            var input = new[] {'d', 'c', 'a', 'b', 'f'};
            var sortedInput = new[] {'a', 'b', 'c', 'd', 'f'};

            QuickSort<char>.SortArray(input);

            Assert.Equal(sortedInput, input);
        }
    }
}
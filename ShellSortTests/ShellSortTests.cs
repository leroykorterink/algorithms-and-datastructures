using ShellSort;
using Xunit;

namespace ShellSortTests
{
    public class ShellSortTests
    {
        [Fact]
        public void Should_SortIntegersWithShellSort()
        {
            var input = new[] {8, 5, 9, 2, 6, 3};
            var sortedInput = new[] {2, 3, 5, 6, 8, 9};

            var result = ShellSort<int>.SortArray(input);

            Assert.Equal(result, sortedInput);
        }

        [Fact]
        public void Should_SortCharactersWithShellSort()
        {
            var input = new[] {'d', 'c', 'a', 'b', 'f'};
            var sortedInput = new[] {'a', 'b', 'c', 'd', 'f'};

            var result = ShellSort<char>.SortArray(input);

            Assert.Equal(result, sortedInput);
        }
    }
}
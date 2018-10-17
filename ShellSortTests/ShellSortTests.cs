using System;
using ShellSort;
using Xunit;

namespace ShellSortTests
{
    public class ShellSortTests
    {
        [Fact]
        public void Should_SortIntegers_With_ShellSort()
        {
            var input = new[] {8, 5, 9, 2, 6, 3};
            var sortedInput = new[] {2, 3, 5, 6, 8, 9};

            ShellSort<int>.SortArray(input);

            Assert.Equal(sortedInput, input);
        }

        [Fact]
        public void Should_SortCharacters_With_ShellSort()
        {
            var input = new[] {'d', 'c', 'a', 'b', 'f'};
            var sortedInput = new[] {'a', 'b', 'c', 'd', 'f'};

            ShellSort<char>.SortArray(input);

            Assert.Equal(sortedInput, input);
        }

        [Fact]
        public void Should_SortIntegers_With_ShellSort_With_GivenSequence()
        {
            var input = new[] {8, 5, 9, 2, 6, 3, 12, 13, 14, 15, 16, 17, 18};
            var sortedInput = new[] {2, 3, 5, 6, 8, 9, 12, 13, 14, 15, 16, 17, 18};

            ShellSort<int>.SortArray(input, 4);

            Assert.Equal(sortedInput, input);
        }

        [Fact]
        public void Should_ThrowError_When_GivenSequenceIsTooHigh()
        {
            const int sequence = 4; // The sequence is too high because the initial sequence is 3. 7 / 2 = 3
            var input = new[] {8, 5, 9, 2, 6, 3, 12}; // Input length 7

            Assert.Throws<ArgumentException>(() => ShellSort<int>.SortArray(input, sequence));
        }
    }
}
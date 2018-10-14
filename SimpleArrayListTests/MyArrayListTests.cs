using System;
using Xunit;
using SimpleArrayList;

namespace SimpleArrayListTests
{
    public class SimpleArrayListTests
    {
        [Fact]
        public void Should_AddGivenValueAddFirstEmptyLocation()
        {
            const int expectedValue = 5;

            var listOfNumbers = new MyArrayList(3);
            listOfNumbers.Add(expectedValue);

            Assert.Equal(expectedValue, listOfNumbers.Get(0));
        }

        [Fact]
        public void Should_GetValueOnGivenIndex()
        {
            const int expectedValue = 3;

            var listOfNumbers = new MyArrayList(3);

            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(expectedValue);

            Assert.Equal(expectedValue, listOfNumbers.Get(2));
        }


        [Fact]
        public void Should_ThrowError_When_GettingValueOnInvalidIndex()
        {
            const int expectedValue = 3;

            var listOfNumbers = new MyArrayList(3);

            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(expectedValue);

            Assert.Throws<IndexOutOfRangeException>(() => listOfNumbers.Get(3));
        }

        [Fact]
        public void Should_ThrowError_When_GivenIndexIsOutOfRange()
        {
            var listOfNumbers = new MyArrayList(3);

            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(3);

            Assert.Throws<InvalidOperationException>(() => listOfNumbers.Add(4));
        }

        [Fact]
        public void Should_CountOccurrences()
        {
            var listOfNumbers = new MyArrayList(5);

            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(1);

            Assert.Equal(3, listOfNumbers.CountOccurrences(1));
            Assert.Equal(2, listOfNumbers.CountOccurrences(2));
        }

        [Fact]
        public void Should_ClearList()
        {
            var listOfNumbers = new MyArrayList(5);

            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(1);
            listOfNumbers.Add(2);
            listOfNumbers.Add(1);

            listOfNumbers.Clear();

            Assert.Equal(5, listOfNumbers.CountOccurrences(0));
        }

        [Fact]
        public void Should_SetGivenValueOnGivenIndex()
        {
            var listOfNumbers = new MyArrayList(4);

            listOfNumbers.Add(1);
            listOfNumbers.Add(2);

            listOfNumbers.Set(0, 50);
            listOfNumbers.Set(3, 100);

            Assert.Equal(50, listOfNumbers.Get(0));
            Assert.Equal(100, listOfNumbers.Get(3));
        }
    }
}
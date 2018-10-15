using System;
using System.Collections.Generic;
using Xunit;

namespace PrintRecursiveTests
{
    public class PrintRecursiveTests
    {
        [Fact]
        public void Should_PrintForwards()
        {
            var instance = new PrintRecursive.PrintRecursive();
            var myList = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Assert.Equal("3456789", instance.PrintForwards(myList, 3));
        }

        [Fact]
        public void Should_PrintBackwards()
        {
            var instance = new PrintRecursive.PrintRecursive();
            var myList = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Assert.Equal("9876543", instance.PrintBackwards(myList, 3));
        }
    }
}
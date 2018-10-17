using System;

namespace InsertionSort
{
    public class InsertionSort<T> where T : IComparable
    {
        public static void SortArray(T[] input)
        {
            for (var index = 1; index < input.Length; index++)
            {
                var currentElement = input[index];
                var fromIndex = index;

                for (
                    ;
                    fromIndex > 0 && currentElement.CompareTo(input[fromIndex - 1]) < 0;
                    fromIndex--
                )
                    input[fromIndex] = input[fromIndex - 1];

                input[fromIndex] = currentElement;
            }
        }
    }
}
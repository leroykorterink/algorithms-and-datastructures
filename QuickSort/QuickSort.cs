using System;
using System.Collections.Generic;
using InsertionSort;

namespace QuickSort
{
    public class QuickSort<T> where T : IComparable
    {
        private const int Cutoff = 2;

        /// <summary>
        /// QuickSort
        /// </summary>
        /// <param name="input"></param>
        public static void SortArray(T[] input)
        {
            SortArray(input, 0, input.Length - 1);
        }

        private static void SortArray(T[] input, int low, int high)
        {
            if (low + Cutoff > high)
            {
                InsertionSort<T>.SortArray(input);
                return;
            }

            int middle = (low + high) / 2;

            if (input[middle].CompareTo(input[low]) < 0)
                SwapReferences(input, low, middle);

            if (input[high].CompareTo(input[low]) < 0)
                SwapReferences(input, low, high);

            if (input[high].CompareTo(input[middle]) < 0)
                SwapReferences(input, middle, high);

            // Place pivot at position high - 1
            SwapReferences(input, middle, high - 1);
            var pivot = input[high - 1];

            int i, j;
            for (i = low, j = high - 1;;)
            {
                while (input[++i].CompareTo(pivot) < 0)
                    ;
                while (pivot.CompareTo(input[--j]) < 0)
                    ;

                if (i >= j)
                    break;

                SwapReferences(input, i, j);
            }

            // Restore pivot
            SwapReferences(input, i, high - 1);

            SortArray(input, low, i - 1);
            SortArray(input, i + 1, high);
        }

        /// <summary>
        /// Function to help us swap references in single dimension array
        /// </summary>
        /// <param name="input"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void SwapReferences(IList<T> input, int a, int b)
        {
            var temporary = input[a];

            input[a] = input[b];
            input[b] = temporary;
        }
    }
}
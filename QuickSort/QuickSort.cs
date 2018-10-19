using System;
using InsertionSort;
using SortingUtilities;

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

            var middle = (low + high) / 2;

            if (input[middle].CompareTo(input[low]) < 0)
                Utilities.SwapReferences(input, low, middle);

            if (input[high].CompareTo(input[low]) < 0)
                Utilities.SwapReferences(input, low, high);

            if (input[high].CompareTo(input[middle]) < 0)
                Utilities.SwapReferences(input, middle, high);

            // Place pivot at position high - 1
            Utilities.SwapReferences(input, middle, high - 1);
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

                Utilities.SwapReferences(input, i, j);
            }

            // Restore pivot
            Utilities.SwapReferences(input, i, high - 1);

            SortArray(input, low, i - 1);
            SortArray(input, i + 1, high);
        }
    }
}
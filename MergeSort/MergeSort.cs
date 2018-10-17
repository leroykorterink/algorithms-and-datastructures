using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class MergeSort<T> where T : IComparable
    {
        /// <summary>
        /// MergeSort algorithm
        /// </summary>
        /// <param name="input">An array of IComparable items</param>
        public static void SortArray(T[] input)
        {
            SortArray(input, new T[input.Length], 0, input.Length - 1);
        }

        /// <summary>
        /// Method that makes recursive divides and merges the input into sub-arrays
        /// 
        /// [1432]        -- 1st recursive call (SortArray)
        /// [14][32]      -- 2st recursive call (SortArray)
        /// [1][4][3][2]  -- 3st recursive call (SortArray -> Merge)
        /// [14][23]                            (Merge of 2nd recursive call)
        /// [1234]                              (Merge of 1st recursive call)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="sortedInput"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void SortArray(IList<T> input, IList<T> sortedInput, int left, int right)
        {
            if (left >= right) return;

            var center = (left + right) / 2;
            SortArray(input, sortedInput, left, center);
            SortArray(input, sortedInput, center + 1, right);

            // Divide left sub-array
            Merge(input, sortedInput, left, center + 1, right);
        }

        /// <summary>
        /// Method that merges two halves of a sub-array 
        /// </summary>
        /// <param name="input">An array of comparable items</param>
        /// <param name="sortedInput">An array that is used to temporary store the sorted result</param>
        /// <param name="leftPosition">The left-most index of the sub-array</param>
        /// <param name="rightPosition">The index of the start of the second half</param>
        /// <param name="rightEnd">The right-most index of the sub-array</param>
        private static void Merge(
            IList<T> input,
            IList<T> sortedInput,
            int leftPosition,
            int rightPosition,
            int rightEnd
        )
        {
            var leftEnd = rightPosition - 1;
            var temporaryPosition = leftPosition;
            var numberOfElements = rightEnd - leftPosition + 1;

            // Sort elements
            while (leftPosition <= leftEnd && rightPosition <= rightEnd)
                sortedInput[temporaryPosition++] =
                    input[leftPosition].CompareTo(input[rightPosition]) <= 0
                        ? input[leftPosition++]
                        : input[rightPosition++];

            // Copy rest of left half into sorted input
            while (leftPosition <= leftEnd)
                sortedInput[temporaryPosition++] = input[leftPosition++];

            // Copy rest of right half into sorted input
            while (rightPosition <= rightEnd)
                sortedInput[temporaryPosition++] = input[rightPosition++];

            // Copy sortedInput into input
            for (var index = 0; index < numberOfElements; index++, rightEnd--)
                input[rightEnd] = sortedInput[rightEnd];
        }
    }
}
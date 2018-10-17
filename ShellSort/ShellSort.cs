using System;

namespace ShellSort
{
    public class ShellSort<T> where T : IComparable
    {
        /// <summary>
        /// Shellsort (Gapsort) using a sequence suggested by Gonnet
        /// </summary>
        /// <param name="input"></param>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public static T[] SortArray(T[] input, double sequence = 2.2)
        {
            var initialSequence = input.Length / 2;

            if (sequence > initialSequence)
                throw new ArgumentException("`sequence` cannot be higher than the initial sequence (|input| / 2)");

            for (
                var gap = initialSequence;
                gap > 0;
                gap = gap == 2 ? 1 : (int) (gap / sequence)
            )
            {
                for (var index = gap; index < input.Length; index++)
                {
                    var currentElement = input[index];
                    var fromIndex = index;

                    for (
                        ;
                        fromIndex >= gap && currentElement.CompareTo(input[fromIndex - gap]) < 0;
                        fromIndex -= gap
                    )
                        input[fromIndex] = input[fromIndex - gap];

                    input[fromIndex] = currentElement;
                }
            }

            return input;
        }
    }
}
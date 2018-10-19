using System.Collections;

namespace SortingUtilities
{
    public class Utilities
    {
        /// <summary>
        /// Function to help us swap references in single dimension array
        /// </summary>
        /// <param name="input"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void SwapReferences(IList input, int a, int b)
        {
            var temporary = input[a];

            input[a] = input[b];
            input[b] = temporary;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintRecursive
{
    public class PrintRecursive : IPrint
    {
        public string PrintForwards(List<int> list, int i)
        {
            var slicedList = list.Skip(i);
            var value = slicedList.Count() != 0 ? slicedList.First() : default(int);

            if (value == 0) return "";

            // Call PrintForward after getting the element
            return (
                list.Skip(i).First() +
                PrintForwards(list, i + 1)
            );
        }

        public string PrintBackwards(List<int> list, int i)
        {
            var slicedList = list.Skip(i);
            var value = slicedList.Count() != 0 ? slicedList.First() : default(int);

            if (value == 0) return "";

            // Call PrintForward before getting the element
            return (
                PrintBackwards(list, i + 1) +
                value
            );
        }
    }
}
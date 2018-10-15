using System.Collections.Generic;

namespace PrintRecursive
{
    public interface IPrint
    {
        string PrintForwards(List<int> list, int i);

        string PrintBackwards(List<int> list, int i);
    }
}
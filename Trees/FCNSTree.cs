using System.Collections.Generic;

namespace trees
{
    interface IFCNSTree<T>
    {
        int Size();
        void PrintPreOrder();
    }


    public class FCNSTree<T> : IFCNSTree<T>
    {
        public int Size()
        {
            throw new System.NotImplementedException();
        }

        public void PrintPreOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}
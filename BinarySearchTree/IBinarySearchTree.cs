using System;

namespace BinarySearchTree
{
    internal interface IBinarySearchTree<T> where T : IComparable
    {
        void Insert(T x);
        
        void Remove(T x);
        
        void RemoveMin();
        
        T FindMin();
        
        string InOrder();
        
        string ToString();
    }
}
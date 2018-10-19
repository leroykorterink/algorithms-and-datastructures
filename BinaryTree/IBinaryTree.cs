namespace BinaryTree
{
    public interface IBinaryTree<T>
    {
        BinaryNode<T> GetRoot();
        
        int Size();
        
        int Height();
        
        void PrintPreOrder();
        
        void PrintInOrder();
        
        void PrintPostOrder();
        
        void MakeEmpty();
        
        bool IsEmpty();
        
        void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2);
    }
}
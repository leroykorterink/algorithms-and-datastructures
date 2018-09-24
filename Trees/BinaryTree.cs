using System;
using System.Collections.Generic;
using System.Linq;

namespace trees
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryNode<T>
    {
        private BinaryNode<T> Left;
        private BinaryNode<T> Right;

        private readonly int _data;

        private BinaryNode(int value)
        {
            _data = value;

            Left = null;
            Right = null;
        }

        public BinaryNode<T> Insert(BinaryNode<T> node, int data)
        {
            if (node == null)
                return new BinaryNode<T>(data);

            return Insert(node._data < data ? node.Right : node.Left, data);
        }
        
        /// <summary>
        /// 
        /// </summary>
        private bool IsLeaf => Left == null && Right == null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBinaryTree<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        BinaryNode<T> GetRoot();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int Size();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int Height();

        /// <summary>
        /// 
        /// </summary>
        void PrintPreOrder();

        /// <summary>
        /// 
        /// </summary>
        void PrintInOrder();

        /// <summary>
        /// 
        /// </summary>
        void PrintPostOrder();

        /// <summary>
        /// 
        /// </summary>
        void MakeEmpty();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// </summary>
        /// <param name="rootItem"></param>
        /// <param name="firstTree"></param>
        /// <param name="secondTree"></param>
        void Merge(T rootItem, BinaryTree<T> firstTree, BinaryTree<T> secondTree);
    }

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTree<T> : IBinaryTree<T>
    {
        private BinaryTree<T>[] _edges;

        /// <inheritdoc />
        public BinaryNode<T> GetRoot()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public int Size()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public int Height()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void PrintPreOrder()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void PrintInOrder()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void PrintPostOrder()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void MakeEmpty()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool IsEmpty() => !_edges.Any();

        /// <inheritdoc />
        public void Merge(T rootItem, BinaryTree<T> firstTree, BinaryTree<T> secondTree)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int CountNodesWithOneNotNullChild()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int CountNodesWithNotNullChildren()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Diagnostics.CodeAnalysis;

namespace BinaryTree
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        private BinaryNode<T> _rootNode;

        public BinaryTree(T root)
        {
            _rootNode = new BinaryNode<T>(root);
        }

        /// <summary>
        /// Returns this tree's root node
        /// </summary>
        /// <returns></returns>
        public BinaryNode<T> GetRoot() => _rootNode;

        /// <summary>
        /// Calculates the size of the current tree
        /// </summary>
        /// <returns></returns>
        public int Size() => _rootNode != null
            ? BinaryNode<T>.Size(_rootNode)
            : 0;

        /// <summary>
        /// Calculates the high of the current tree
        /// </summary>
        /// <returns></returns>
        public int Height() => _rootNode != null
            ? BinaryNode<T>.Height(_rootNode)
            : 0;

        /// <summary>
        /// Creates a string of current tree pre order
        /// </summary>
        /// <returns></returns>
        public string ToStringPreOrder() => _rootNode != null
            ? BinaryNode<T>.ToStringPreOrder(_rootNode)
            : "";

        /// <summary>
        /// Creates a string of current tree in-order
        /// </summary>
        /// <returns></returns>
        public string ToStringInOrder() => _rootNode != null
            ? BinaryNode<T>.ToStringInOrder(_rootNode)
            : "";

        /// <summary>
        /// Creates a string of current tree post-order
        /// </summary>
        /// <returns></returns>
        public string ToStringPostOrder() => _rootNode != null
            ? BinaryNode<T>.ToStringPostOrder(_rootNode)
            : "";

        /// <summary>
        /// Set root node to null
        /// </summary>
        public void MakeEmpty() => _rootNode = null;

        /// <summary>
        /// Check if current tree is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => _rootNode == null;

        /// <summary>
        /// Merge two trees
        /// </summary>
        /// <param name="rootItem"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Merge(T rootItem, BinaryTree<T> a, BinaryTree<T> b)
        {
            if (a._rootNode == b._rootNode && a._rootNode != null)
                throw new ArgumentException();

            _rootNode = new BinaryNode<T>(rootItem)
            {
                Left = a._rootNode,
                Right = b._rootNode,
            };

            if (this != a)
                a._rootNode = null;

            if (this != b)
                b._rootNode = null;
        }


        // Interface provided by teacher needs to print to the console.
        // I want to create unit tests for these methods, thus I wrap the ToString{SomeOrder}
        // methods here in a Console.WriteLine.
        [ExcludeFromCodeCoverage]
        public void PrintPreOrder() => Console.WriteLine(ToStringPreOrder());
        
        [ExcludeFromCodeCoverage]
        public void PrintInOrder() => Console.WriteLine(ToStringInOrder());
        
        [ExcludeFromCodeCoverage]
        public void PrintPostOrder() => Console.WriteLine(ToStringPostOrder());
    }
}
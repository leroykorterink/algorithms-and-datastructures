using System;
using BinaryTree;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> : IBinarySearchTree<T> where T : IComparable
    {
        public Node<T> RootNode;

        /// <summary>
        /// Inserts given node into tree
        /// </summary>
        /// <param name="x"></param>
        public void Insert(T x) =>
            RootNode = Insert(x, RootNode);

        /// <summary>
        /// Removes given element from the tree
        /// </summary>
        /// <param name="x"></param>
        public void Remove(T x) =>
            RootNode = Remove(x, RootNode);

        /// <summary>
        /// Removes the smallest value from the tree
        /// </summary>
        public void RemoveMin() =>
            RootNode = RemoveMin(RootNode);

        /// <summary>
        /// Find smallest value in tree
        /// </summary>
        /// <returns></returns>
        public T Find(T x) =>
            ElementAt(Find(x, RootNode));

        /// <summary>
        /// Find smallest value in tree
        /// </summary>
        /// <returns></returns>
        public T FindMin() =>
            ElementAt(FindMin(RootNode));

        /// <summary>
        /// Finds biggest value in tree
        /// </summary>
        /// <returns></returns>
        public T FindMax() =>
            ElementAt(FindMax(RootNode));

        /// <summary>
        /// Set the root node to null
        /// </summary>
        public void MakeEmpty() =>
            RootNode = null;

        /// <summary>
        /// Checks if the root node is null
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() =>
            RootNode == null;

        /// <summary>
        /// Returns the element in the given node, if node is null the type default will be returned
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T ElementAt(Node<T> node) =>
            node == null ? default(T) : node.Element;

        #region Recursive method implementation

        /// <summary>
        /// Find given value (x) in given subtree 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="node"></param>
        private static Node<T> Find(T x, Node<T> node)
        {
            while (node != null)
            {
                if (x.CompareTo(node.Element) < 0)
                    node = node.Left;

                else if (x.CompareTo(node.Element) > 0)
                    node = node.Right;
                
                else
                    return node;
            }

            return null;
        }

        /// <summary>
        /// Find the smallest element in the tree by going to the left subtree every iteration
        /// </summary>
        /// <param name="node"></param>
        private static Node<T> FindMin(Node<T> node)
        {
            if (node == null) return null;

            while (node.Left != null)
                node = node.Left;

            return node;
        }

        /// <summary>
        /// Find the largest element in the tree by going to the right subtree every iteration
        /// </summary>
        /// <param name="node"></param>
        private static Node<T> FindMax(Node<T> node)
        {
            if (node == null) return null;

            while (node.Right != null)
                node = node.Right;

            return node;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="x"></param>
        /// <param name="node"></param>
        protected Node<T> Insert(T x, Node<T> node)
        {
            if (node == null)
                node = new Node<T>(x);

            else if (x.CompareTo(node.Element) < 0)
                node.Left = Insert(x, node.Left);

            else if (x.CompareTo(node.Element) > 0)
                node.Right = Insert(x, node.Right);

            else
                throw new DuplicateElementException(x.ToString());

            return node;
        }

        /// <summary>
        /// Method to remove the smallest element from the tree 
        /// </summary>
        /// <param name="node"></param>
        protected Node<T> RemoveMin(Node<T> node)
        {
            if (node == null)
                throw new NodeNotFoundException();

            if (node.Left == null)
                return node.Right;

            node.Left = RemoveMin(node.Left);

            return node;
        }

        /// <summary>
        /// Remove node with given element from tree
        /// </summary>
        /// <param name="x">Element to remove</param>
        /// <param name="node"></param>
        /// <exception cref="NodeNotFoundException"></exception>
        public Node<T> Remove(T x, Node<T> node)
        {
            if (node == null)
                throw new NodeNotFoundException();

            if (x.CompareTo(node.Element) < 0)
                node.Left = Remove(x, node.Left);

            else if (x.CompareTo(node.Element) > 0)
                node.Right = Remove(x, node.Right);

            else if (node.Left != null && node.Right != null)
            {
                node.Element = ElementAt(FindMin(node.Right));
                node.Right = RemoveMin(node.Right);
            }

            else
                node = node.Left ?? node.Right;

            return node;
        }

        #endregion

        #region Methods used to print the tree

        /// <summary>
        /// Print tree in order
        /// </summary>
        /// <returns></returns>
        public string InOrder() =>
            Node<T>.InOrder(RootNode);

        /// <summary>
        /// Prints tree with brackets
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            Node<T>.ToString(RootNode);

        #endregion

        #region Custom error classes

        private class DuplicateElementException : Exception
        {
            public DuplicateElementException(string message) : base(message)
            {
            }
        }

        private class NodeNotFoundException : Exception
        {
        }

        #endregion
    }
}
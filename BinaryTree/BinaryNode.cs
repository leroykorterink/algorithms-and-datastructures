using System;

namespace BinaryTree
{
    public class BinaryNode<T>
    {
        public T Data;

        public BinaryNode<T> Left;

        public BinaryNode<T> Right;

        public BinaryNode(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Calculates the size of the given node recursively
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int Size(BinaryNode<T> node)
        {
            if (node == null) return 0;

            return 1 + Size(node.Left) + Size(node.Right);
        }

        /// <summary>
        /// Calculates the height of the given node recursively
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int Height(BinaryNode<T> node)
        {
            if (node == null) return -1;

            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        /// <summary>
        /// Return a reference to a node that is the root of a duplicate
        /// of the binary tree rooted at the current node.
        /// </summary>
        /// <returns></returns>
        public BinaryNode<T> Duplicate()
        {
            var node = new BinaryNode<T>(Data);

            // Duplicate the left subtree if there is one attached to the current node
            if (Left != null)
                node.Left = Left.Duplicate();

            // Duplicate the right subtree if there is one attached to the current node
            if (Right != null)
                node.Right = Right.Duplicate();

            return node;
        }

        /// <summary>
        /// Prints Data then Left then Right
        /// </summary>
        /// <returns></returns>
        public static string ToStringPreOrder(BinaryNode<T> node)
        {
            if (node == null) return "";

            var result = "";

            // First Data
            result += node.Data;

            // Then Left
            if (node.Left != null)
                result += ToStringPreOrder(node.Left);

            // Then Right
            if (node.Right != null)
                result += ToStringPreOrder(node.Right);

            return result;
        }

        /// <summary>
        /// Prints Left then Data then Right
        /// </summary>
        /// <returns></returns>
        public static string ToStringInOrder(BinaryNode<T> node)
        {
            if (node == null) return "";

            var result = "";

            // First Left
            if (node.Left != null)
                result += ToStringInOrder(node.Left);

            // Then Data
            result += node.Data;

            // Then Right
            if (node.Right != null)
                result += ToStringInOrder(node.Right);

            return result;
        }

        /// <summary>
        /// Prints Right then Left then Data 
        /// </summary>
        /// <returns></returns>
        public static string ToStringPostOrder(BinaryNode<T> node)
        {
            if (node == null) return "";

            var result = "";

            // First Left
            if (node.Left != null)
                result += ToStringPostOrder(node.Left);

            // Then Right
            if (node.Right != null)
                result += ToStringPostOrder(node.Right);

            // Then Data
            result += node.Data.ToString();

            return result;
        }

        /// <summary>
        /// Prints Left then Data then Right with brackets to easily identify nodes
        /// </summary>
        /// <returns></returns>
        public static string ToString(BinaryNode<T> node)
        {
            if (node == null) return "NULL";

            return string.Format(
                "[ {0} {1} {2} ]",
                node.Left != null ? ToString(node.Left) : "NULL",
                node.Data,
                node.Right != null ? ToString(node.Right) : "NULL"
            );
        }
    }
}
using System;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public T Element;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T x)
        {
            Element = x;
            Left = null;
            Right = null;
        }

        /// <summary>
        /// Prints Left then Data then Right
        /// </summary>
        /// <returns></returns>
        public static string InOrder(Node<T> node)
        {
            if (node == null) return "";

            var result = "";

            // First Left
            if (node.Left != null)
                result += $"{InOrder(node.Left)} ";

            // Then Data
            result += node.Element;

            // Then Right
            if (node.Right != null)
                result += $" {InOrder(node.Right)}";

            return result;
        }

        /// <summary>
        /// Prints Left then Data then Right with brackets to easily identify nodes
        /// </summary>
        /// <returns></returns>
        public static string ToString(Node<T> node)
        {
            if (node == null) return "";
            
            return string.Format(
                "{0} {1} {2}",
                node.Left != null ? $"[ {ToString(node.Left)} ]" : "NULL",
                node.Element,
                node.Right != null ? $"[ {ToString(node.Right)} ]" : "NULL"
            );
        }
    }
}
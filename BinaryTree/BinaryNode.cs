namespace BinaryTree
{
    public class BinaryNode<T>
    {
        public T Data;

        public BinaryNode<T> Left;

        public BinaryNode<T> Right;
        
        /// <summary>
        /// Calculates the size of the current node recursively
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int Size(BinaryNode<T> node)
        {
            if (node == null) return 0;

            var result = 1;

            if (node.Left != null)
                result += Size(node.Left);

            if (node.Right != null)
                result += Size(node.Right);

            return result;
        }

        /// <summary>
        /// Prints Data then FirstChild then NextSibling
        /// </summary>
        /// <returns></returns>
        public static string ToStringPreOrder(BinaryNode<T> node)
        {
            if (node == null) return "";

            var result = node.Data.ToString();

            if (node.Left != null)
                result += $", {ToStringPreOrder(node.Left)}";
            
            if (node.Right != null)
                result += $", {ToStringPreOrder(node.Right)}";

            return result;
        }
    }
}
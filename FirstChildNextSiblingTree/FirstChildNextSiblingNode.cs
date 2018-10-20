namespace FirstChildNextSiblingTree
{
    public class FirstChildNextSiblingNode<T>
    {
        public T Data { get; set; }

        public FirstChildNextSiblingNode<T> FirstChild;
        public FirstChildNextSiblingNode<T> NextSibling;

        /// <param name="data"></param>
        public FirstChildNextSiblingNode(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Calculates the size of the current node recursively
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int Size(FirstChildNextSiblingNode<T> node)
        {
            if (node == null) return 0;

            return 1 + Size(node.FirstChild) + Size(node.NextSibling);
        }

        /// <summary>
        /// Prints Data then FirstChild then NextSibling
        /// </summary>
        /// <returns></returns>
        public static string ToStringPreOrder(FirstChildNextSiblingNode<T> node)
        {
            if (node == null) return "";

            return $"{node.Data}, {ToStringPreOrder(node.FirstChild) + ToStringPreOrder(node.NextSibling)}";
        }
    }
}
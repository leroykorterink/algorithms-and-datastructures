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

            var result = 1;

            if (node.FirstChild != null)
                result += Size(node.FirstChild);

            if (node.NextSibling != null)
                result += Size(node.NextSibling);

            return result;
        }

        /// <summary>
        /// Prints Data then FirstChild then NextSibling
        /// </summary>
        /// <returns></returns>
        public static string ToStringPreOrder(FirstChildNextSiblingNode<T> node)
        {
            if (node == null) return "";

            var result = node.Data.ToString();

            if (node.FirstChild != null)
                result += $", {ToStringPreOrder(node.FirstChild)}";
            
            if (node.NextSibling != null)
                result += $", {ToStringPreOrder(node.NextSibling)}";

            return result;
        }
    }
}
using System;

namespace FirstChildNextSiblingTree
{
    public class FirstChildNextSiblingTree<T> : IFirstChildNextSiblingTree<T>
    {
        /// <summary>
        /// The tree's root node
        /// </summary>
        private readonly FirstChildNextSiblingNode<T> _rootNode;

        /// <param name="rootNode"></param>
        public FirstChildNextSiblingTree(FirstChildNextSiblingNode<T> rootNode)
        {
            _rootNode = rootNode;
        }

        /// <summary>
        /// Calculates the size of the current tree
        /// </summary>
        /// <returns></returns>
        public int Size() => FirstChildNextSiblingNode<T>
            .Size(_rootNode);


        /// <summary>
        /// Creates a string of current tree in pre order
        /// </summary>
        /// <returns></returns>
        public string ToStringPreOrder() => FirstChildNextSiblingNode<T>
            .ToStringPreOrder(_rootNode);


        public void PrintPreOrder() => Console.WriteLine(ToStringPreOrder());
    }
}
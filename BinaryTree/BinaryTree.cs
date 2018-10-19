using System;

namespace BinaryTree
{
    public class BinaryTree<T>: IBinaryTree<T>
    {
        private BinaryNode<T> _rootNode;

        public BinaryTree(BinaryNode<T> rootNode)
        {
            _rootNode = rootNode;
        }

        /// <summary>
        /// Returns this tree's root node
        /// </summary>
        /// <returns></returns>
        public BinaryNode<T> GetRoot() => _rootNode;

        public int Size()
        {
            throw new NotImplementedException();
        }

        public int Height()
        {
            throw new NotImplementedException();
        }

        public string ToStringPreOrder()
        {
            throw new NotImplementedException();
        }

        public string ToStringInOrder()
        {
            throw new NotImplementedException();
        }

        public string ToStringPostOrder()
        {
            throw new NotImplementedException();
        }

        public void MakeEmpty()
        {
            _rootNode = null;
        }

        /// <summary>
        /// Checks if current tree is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => _rootNode == null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootItem"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Merge(T rootItem, BinaryTree<T> a, BinaryTree<T> b)
        {
            throw new NotImplementedException();
        }
        

        // Interface provided by teacher needs to print to the console.
        // I want to create unit tests for these methods, converting
        // the result to a string is now abstracted.
        public void PrintPreOrder() => Console.WriteLine(ToStringPreOrder());
        public void PrintInOrder() => Console.WriteLine(ToStringInOrder());
        public void PrintPostOrder() => Console.WriteLine(ToStringPostOrder());
    }
}
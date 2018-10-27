using System;
using BinaryTree;
using Xunit;

namespace BinaryTreeTests
{
    public class BinaryTreeTests
    {
        private static BinaryTree<int> CreateBinaryTree()
        {
            var binaryTree = new BinaryTree<int>(1);

            binaryTree.GetRoot().Left = new BinaryNode<int>(2)
            {
                Left = new BinaryNode<int>(4),
                Right = new BinaryNode<int>(5)
            };

            binaryTree.GetRoot().Right = new BinaryNode<int>(3);

            return binaryTree;
        }

        [Fact]
        public void Should_GetRoot()
        {
            var binaryTree = CreateBinaryTree();

            Assert.NotNull(binaryTree.GetRoot());
            Assert.IsType<BinaryNode<int>>(binaryTree.GetRoot());
        }

        [Fact]
        public void Should_GetSize()
        {
            var binaryTree = CreateBinaryTree();

            Assert.Equal(5, binaryTree.Size());
        }

        [Fact]
        public void Should_GetHeight()
        {
            var binaryTree = CreateBinaryTree();

            Assert.Equal(2, binaryTree.Height());
        }

        [Fact]
        public void Should_ToString()
        {
            var binaryTree = CreateBinaryTree();

            Assert.Equal("[ [ [ NULL 4 NULL ] 2 [ NULL 5 NULL ] ] 1 [ NULL 3 NULL ] ]", binaryTree.ToString());
        }
        
        [Fact]
        public void Should_PrintPreOrder()
        {
            var binaryTree = CreateBinaryTree();

            Assert.Equal("1 2 4 5 3 ", binaryTree.ToStringPreOrder());
        }

        [Fact]
        public void Should_PrintInOrder()
        {
            var binaryTree = CreateBinaryTree();

            Assert.Equal("4 2 5 1 3 ", binaryTree.ToStringInOrder());
        }

        [Fact]
        public void Should_PrintPostOrder()
        {
            var binaryTree = CreateBinaryTree();

            Assert.Equal("4 5 2 3 1 ", binaryTree.ToStringPostOrder());
        }

        [Fact]
        public void Should_MakeEmpty()
        {
            var binaryTree = CreateBinaryTree();

            binaryTree.MakeEmpty();

            Assert.Null(binaryTree.GetRoot());
        }

        [Fact]
        public void Should_IsEmpty()
        {
            var binaryTree = CreateBinaryTree();

            Assert.False(binaryTree.IsEmpty());

            binaryTree.MakeEmpty();

            Assert.True(binaryTree.IsEmpty());
        }

        [Fact]
        public void Should_MergeTrees()
        {
            var treeOne = new BinaryTree<int>(1);
            var treeTwo = new BinaryTree<int>(2);

            treeOne.Merge(3, treeOne, treeTwo);

            Assert.Equal("3 1 2 ", treeOne.ToStringPreOrder());

            Assert.NotNull(treeOne.GetRoot());
            Assert.Null(treeTwo.GetRoot());
        }

        [Fact]
        public void Should_ThrowException_When_MergeTrees()
        {
            var treeOne = new BinaryTree<int>(2);

            Assert.Throws<ArgumentException>(() => treeOne.Merge(1, treeOne, treeOne));
        }
    }
}
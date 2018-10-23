using BinarySearchTree;
using System;
using Xunit;
using Xunit.Abstractions;

namespace BinarySearchTreeTests
{
    public class BinarySearchTreeTests
    {
        private readonly ITestOutputHelper _output;

        public BinarySearchTreeTests(ITestOutputHelper output)
        {
            _output = output;
        }

        
        private static BinarySearchTree<int> CreateTree()
        {
            var tree = new BinarySearchTree<int>();

            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(7);
            tree.Insert(2);
            tree.Insert(5);

            return tree;
        }

        [Fact]
        public void Should_InOrder()
        {
            var tree = CreateTree();

            Assert.Equal("2 4 5 6 7", tree.InOrder());
        }

        [Fact]
        public void Should_Insert()
        {
            var tree = new BinarySearchTree<int>();

            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(5);

            Assert.Equal(5, tree.Find(5));
        }

        [Fact]
        public void Should_Remove()
        {
            var tree = CreateTree();
            tree.Remove(5);

            Assert.Equal(0, tree.Find(5));
        }

        [Fact]
        public void Should_RemoveMin()
        {
            var tree = CreateTree();
            tree.RemoveMin();
            
            Assert.Equal(0, tree.Find(2));
        }

        [Fact]
        public void Should_FindMin()
        {
            var tree = CreateTree();

            Assert.Equal(2, tree.FindMin());
        }

        [Fact]
        public void Should_ToString_When_TreeHasMultipleNodes()
        {
            var fullTree = CreateTree();
            
            Assert.Equal("[ [ NULL 2 NULL ] 4 [ NULL 5 NULL ] ] 6 [ NULL 7 NULL ]", fullTree.ToString());
        }

        [Fact]
        public void Should_ToString_When_TreeHasOneNode()
        {
            var treeWithOneElement = new BinarySearchTree<int>();
            treeWithOneElement.Insert(6);

            Assert.Equal("NULL 6 NULL", treeWithOneElement.ToString());
        }

        [Fact]
        public void Should_ToString_When_TreeIsEmpty()
        {
            var emptyTree = new BinarySearchTree<int>();

            Assert.Equal("", emptyTree.ToString());
        }
    }
}
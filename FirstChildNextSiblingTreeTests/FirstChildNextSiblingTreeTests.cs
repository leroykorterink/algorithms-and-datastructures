using FirstChildNextSiblingTree;
using Xunit;

namespace FirstChildNextSiblingTreeTests
{
    public class FirstChildNextSiblingTests
    {
        [Fact]
        public void Should_PrintPreOrder()
        {
            // 5, 1, 10, 11, 12, 13, 14, 2, 3, 8
            var rootNode = new FirstChildNextSiblingNode<int>(5)
            {
                FirstChild = new FirstChildNextSiblingNode<int>(1)
                {
                    FirstChild = new FirstChildNextSiblingNode<int>(2)
                    {
                        FirstChild = new FirstChildNextSiblingNode<int>(3)
                        {
                            NextSibling = new FirstChildNextSiblingNode<int>(8)
                        }
                    }
                },
                NextSibling = new FirstChildNextSiblingNode<int>(10)
                {
                    NextSibling = new FirstChildNextSiblingNode<int>(11)
                    {
                        NextSibling = new FirstChildNextSiblingNode<int>(12)
                        {
                            NextSibling = new FirstChildNextSiblingNode<int>(13)
                            {
                                NextSibling = new FirstChildNextSiblingNode<int>(14)
                            }
                        }
                    }
                },
            };

            var firstChildNextSiblingTree = new FirstChildNextSiblingTree<int>(rootNode);

            Assert.Equal("5, 1, 2, 3, 8, 10, 11, 12, 13, 14", firstChildNextSiblingTree.ToStringPreOrder());
        }

        [Fact]
        public void Should_CalculateSize()
        {
            // 5, 1, 10, 11, 12, 13, 14, 2, 3, 8
            var rootNode = new FirstChildNextSiblingNode<int>(5)
            {
                FirstChild = new FirstChildNextSiblingNode<int>(1)
                {
                    FirstChild = new FirstChildNextSiblingNode<int>(2)
                    {
                        FirstChild = new FirstChildNextSiblingNode<int>(3)
                        {
                            NextSibling = new FirstChildNextSiblingNode<int>(8)
                        }
                    }
                },
                NextSibling = new FirstChildNextSiblingNode<int>(10)
                {
                    NextSibling = new FirstChildNextSiblingNode<int>(11)
                    {
                        NextSibling = new FirstChildNextSiblingNode<int>(12)
                        {
                            NextSibling = new FirstChildNextSiblingNode<int>(13)
                            {
                                NextSibling = new FirstChildNextSiblingNode<int>(14)
                            }
                        }
                    }
                },
            };

            var firstChildNextSiblingTree = new FirstChildNextSiblingTree<int>(rootNode);

            Assert.Equal(10, firstChildNextSiblingTree.Size());
        }
    }
}
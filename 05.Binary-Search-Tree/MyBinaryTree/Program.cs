
using MyBinaryTree;

var binaryTree = new AbstractBinaryTree<int>(7,
                       new AbstractBinaryTree<int>(4,
                               new AbstractBinaryTree<int>(2,
                                    new AbstractBinaryTree<int>(1),
                                    new AbstractBinaryTree<int>(3)),
                               new AbstractBinaryTree<int>(5,
                                    null,
                                    new AbstractBinaryTree<int>(6))),
                       new AbstractBinaryTree<int>(9,
                               new AbstractBinaryTree<int>(8),
                               new AbstractBinaryTree<int>(11,
                                    null,
                                    new AbstractBinaryTree<int>(10))));




//var testTree = binaryTree.PreOrder();

//var testTree = binaryTree.InOrder();

var testTree = binaryTree.PostOrder();

foreach (var item in testTree)
{
    Console.Write(item.Value + " ");
}
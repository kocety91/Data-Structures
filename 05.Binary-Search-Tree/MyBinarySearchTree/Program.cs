
using MyBinarySearchTree;

var bst = new AbstractBinarySearchTree<int>();

bst.Insert(5);
bst.Insert(20);
bst.Insert(4);


bst.EachInOrder(Console.WriteLine);

using MyBinarySearchTree;

var bst = new AbstractBinarySearchTree<int>();

bst.Insert(5);
bst.Insert(20);
bst.Insert(4);
bst.Insert(3);
bst.Insert(2);
bst.Insert(17);

//var search = bst.Search(2);
var exist = bst.Contains(5);

Console.WriteLine(exist);

using MyBinarySearchTree;

var bst = new AbstractBinarySearchTree<int>();

bst.Insert(5);
bst.Insert(10);
bst.Insert(12);
bst.Insert(2);
bst.Insert(17);
//bst.Delete(122);
//bst.DeleteMin();
//bst.DeleteMax();




//var newBst = bst.Search(20);  //2 17

//bst.DeleteMin();
//bst.DeleteMax();
//bst.Delete(17);

//var gg  = bst.Counter();
//var exist = bst.Contains(5);
var rank = bst.Rank(17);
Console.WriteLine(rank);
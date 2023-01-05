
using MyBinarySearchTree;

var bst = new AbstractBinarySearchTree<int>();

//bst.Insert(5);
//bst.Insert(10);
//bst.Insert(12);
//bst.Insert(2);
//bst.Insert(17);
//bst.Delete(122);
//bst.DeleteMin();
//bst.DeleteMax();
//bst.Range(2,10);

bst.Insert(10);
bst.Insert(5);
bst.Insert(3);
bst.Insert(1);
bst.Insert(4);
bst.Insert(8);
bst.Insert(9);
bst.Insert(37);
bst.Insert(39);
bst.Insert(45);

var floor = bst.Floor(5);
Console.WriteLine(floor);

//var newBst = bst.Search(20);  //2 17

//bst.DeleteMin();
//bst.DeleteMax();
//bst.Delete(17);

//var gg  = bst.Counter();
//var exist = bst.Contains(5);
//var rank = bst.Rank(17);
//Console.WriteLine(rank);
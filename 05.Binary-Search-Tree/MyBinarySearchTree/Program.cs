
using MyBinarySearchTree;

var bst = new AbstractBinarySearchTree<int>();

bst.Insert(5);
bst.Insert(17);
bst.Insert(4);
bst.Insert(3);
bst.Insert(2);
bst.Insert(25);


//var newBst = bst.Search(20);  //2 17

//bst.DeleteMin();
//bst.DeleteMax();
//bst.Delete(17);

var gg  = bst.Counter();

var exist = bst.Contains(5);

Console.WriteLine(gg);
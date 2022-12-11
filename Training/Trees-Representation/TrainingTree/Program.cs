using TrainingTree;

//var tree = new Tree<int>(7,
//                     new Tree<int>(19,
//                        new Tree<int>(1),
//                        new Tree<int>(12),
//                        new Tree<int>(31)),
//                     new Tree<int>(21),
//                     new Tree<int>(14,
//                        new Tree<int>(23),
//                        new Tree<int>(6))
//                     );


var integerTree = new IntegerTree(7,
                     new Tree<int>(19,
                        new Tree<int>(1),
                        new Tree<int>(12),
                        new Tree<int>(31)),
                     new Tree<int>(21),
                     new Tree<int>(14,
                        new Tree<int>(23),
                        new Tree<int>(6))
                     );

var list = integerTree.GetSubtreesWithGivenSum(20);
foreach (var item in list)
{
    Console.Write(item.Key + " ");
}

//foreach (var stack in list)
//{
//    foreach (var num in stack)
//    {
//        Console.Write(num + " ");
//    }
//    Console.WriteLine();
//}

//var gg = tree.GetDeepestKey();
//var gg = tree.GetLongestPath();

//foreach (var item in gg)
//{
//    Console.WriteLine($"{item }");
//}

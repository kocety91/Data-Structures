using MyTree;

//koce -> root
//  misho (value, koce)
//     misho1 
//  neli (value,koce)
//       neli1

var tree = new Tree<string>("koce",//5
        new Tree<string>("misho", //2
                   new Tree<string>("misho1")), //1
        new Tree<string>("neli",//4
                     new Tree<string>("neli1")) //3
    );

tree.AddChild("neli", new Tree<string>("neli2"));

var cc = tree.OrderBfs();

//foreach (var item in cc)
//{
//    //koce misho neli misho1 neli1
//    Console.WriteLine(item);
//}

//var cc2 = tree.OrderDfs();

//foreach (var item in cc2)
//{
//    //misho1 
//    Console.WriteLine(item);
//}


foreach (var item in cc)
{
    Console.WriteLine(item);
}
using MyList;

var list = new AbstractList<string>();
list.Add("Misho");
list.Add("KOce");

list.Insert(1, "Neli");

foreach (var item in list)
{
    Console.WriteLine(item);
}


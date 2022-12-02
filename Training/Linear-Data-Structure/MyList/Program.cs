using MyList;

var list = new AbstractList<string>();
list.Add("Misho");
Console.WriteLine(list[0]);

var ss = list.IndexOf("Misho");
Console.WriteLine(ss);

var ff = new List<string>();


using MyReversedList;

var gg = new AbstractReversedList<string>();

gg.Add("koce");   //0  3
gg.Add("misho"); //1 2
gg.Add("neli"); //2  1


//Console.WriteLine(gg.Remove("nei"));

//gg.Insert(1, "anton");
//Console.WriteLine(gg[2]);

//Console.WriteLine(gg.IndexOf("koce"));

//gg.RemoveAt(1);
gg.Insert(1, "anton");


foreach (var item in gg)
{
    Console.WriteLine(item);
}
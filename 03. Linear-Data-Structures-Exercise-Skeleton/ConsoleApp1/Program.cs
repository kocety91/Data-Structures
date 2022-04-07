using Problem03.ReversedList;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ReversedList<string>() { "koce", "misho", "neli" };

            list.Insert(0, "anton");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}

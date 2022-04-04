using Problem01.List;
using System;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var kocelist = new List<string>();

            kocelist.Add("K");
            kocelist.Add("M");
            kocelist.Add("N");
            kocelist.Add("A");


            kocelist.RemoveAt(1);


            foreach (var item in kocelist)
            {
                Console.WriteLine(item);
            }
        }
    }
}

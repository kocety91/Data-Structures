using Problem01.List;
using Problem03.Queue;
using Problem04.SinglyLinkedList;
using System;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var kocelist = new SinglyLinkedList<string>();

            kocelist.AddFirst("Koce");
            kocelist.AddLast("Misho");
            kocelist.AddLast("Neli");
            kocelist.AddLast("Anton");

            kocelist.GetLast();

        }
    }
}

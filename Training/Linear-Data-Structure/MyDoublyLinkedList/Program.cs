using MyDoublyLinkedList;

var doubly = new DoublyLinkedList<string>();
doubly.AddLast("Koce");
doubly.AddLast("Misho");
doubly.AddLast("Neli");

foreach (var item in doubly)
{
    Console.WriteLine(item);
}
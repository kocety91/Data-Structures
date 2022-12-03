

using MyQueue;

var que = new AbstractQueue<int>();


que.Enqueue(1);
que.Enqueue(2);
que.Enqueue(3);
que.Enqueue(4);
que.Dequeue();
que.Dequeue();
Console.WriteLine(que.Contains(14));


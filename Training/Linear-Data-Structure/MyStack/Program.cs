

using MyStack;

var stack = new AbstractStack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Peek();
stack.Pop();

Console.WriteLine(stack.Contains(200));



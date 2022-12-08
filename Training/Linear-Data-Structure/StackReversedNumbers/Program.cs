
//1 2 3 4 5
var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
var stack = new Stack<int>();

for (int i = 0; i < input.Length-1; i++)
{
    stack.Push(input[i]);
}

Console.WriteLine("xa");
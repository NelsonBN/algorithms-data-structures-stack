var stack = new Stack();

stack.Push(11);
stack.Push(21);
stack.Push(31);
stack.Push(41);
stack.Push(51);
stack.Push(61);

Console.WriteLine($"Is Empty: {stack.IsEmpty()}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");

Console.WriteLine($"Is Empty: {stack.IsEmpty()}");


class Stack
{
    private record Node(int Value, Node? Next);

    private Node? _head;

    public Stack()
        => _head = null;

    public void Push(int item)
        => _head = new Node(item, _head);

    public int Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");

        var value = _head.Value;
        _head = _head.Next;
        return value;
    }

    public int Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
        return _head.Value;
    }

    public bool IsEmpty()
        => _head is null;
}

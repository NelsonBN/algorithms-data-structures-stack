var stack = new Stack(5);

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

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

Console.WriteLine($"Is Empty: {stack.IsEmpty()}");


class Stack
{
    private int[] _items;
    private int _pivot;

    public Stack(int capacity)
    {
        _pivot = -1;
        _items = new int[capacity];
    }

    public void Push(int item)
    {
        if(_pivot == _items.Length - 1) throw new InvalidOperationException("Stack is full");

        _items[++_pivot] = item;
    }

    public int Pop()
    {
        if(IsEmpty()) throw new InvalidOperationException("Stack is empty");

        return _items[_pivot--];
    }

    public int Peek()
        => _items[_pivot];

    public bool IsEmpty()
        => _pivot == -1;
}

var stack = new Stack();

for (var i = 1; i <= 17; i++)
{
    stack.Push(i * 100);
}

while (!stack.IsEmpty())
{
    Console.WriteLine($"Peek: {stack.Peek()}");
    Console.WriteLine($"Pop: {stack.Pop()}");
}



class Stack
{
    private int[] _items;
    private int _pivot;

    public Stack()
    {
        _pivot = -1;
        _items = new int[4];
    }

    public void Push(int item)
    {
        _resize();

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

    private void _resize()
    {
        if(_pivot < _items.Length - 1) return;

        Console.WriteLine($"Resizing stack from {_items.Length} to {_items.Length * 2}");

        var copy = new int[_items.Length * 2];
        Array.Copy(_items, copy, _items.Length);
        _items = copy;
    }
}

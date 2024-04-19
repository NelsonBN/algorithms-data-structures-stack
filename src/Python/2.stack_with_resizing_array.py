class Stack:
    def __init__(self):
        self._pivot = -1
        self._items = [0] * 4

    def push(self, item):
        self._resize()
        self._pivot += 1
        self._items[self._pivot] = item

    def pop(self):
        if self.is_empty():
            raise Exception("Stack is empty")
        item = self._items[self._pivot]
        self._pivot -= 1
        return item

    def peek(self):
        return self._items[self._pivot]

    def is_empty(self):
        return self._pivot == -1

    def _resize(self):
        if self._pivot < len(self._items) - 1:
            return

        print(f"Resizing stack from {len(self._items)} to {len(self._items) * 2}")

        self._items = self._items + [0] * len(self._items)


stack = Stack()

for i in range(1, 18):
    stack.push(i * 100)

while not stack.is_empty():
    print(f"Peek: {stack.peek()}")
    print(f"Pop: {stack.pop()}")

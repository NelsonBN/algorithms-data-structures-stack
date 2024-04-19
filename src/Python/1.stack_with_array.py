class Stack:
    def __init__(self, capacity):
        self._pivot = -1
        self._items = [None] * capacity

    def push(self, item):
        if self._pivot == len(self._items) - 1:
            raise Exception("Stack is full")

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


stack = Stack(5)

stack.push(1)
stack.push(2)
stack.push(3)
stack.push(4)
stack.push(5)

print(f"Is Empty: {stack.is_empty()}")

print(f"Peek: {stack.peek()}")
print(f"Pop: {stack.pop()}")

print(f"Peek: {stack.peek()}")
print(f"Pop: {stack.pop()}")

print(f"Peek: {stack.peek()}")
print(f"Pop: {stack.pop()}")

print(f"Peek: {stack.peek()}")
print(f"Pop: {stack.pop()}")

print(f"Peek: {stack.peek()}")
print(f"Pop: {stack.pop()}")

print(f"Is Empty: {stack.is_empty()}")

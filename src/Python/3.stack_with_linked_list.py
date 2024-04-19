class Node:
    def __init__(self, value, next=None):
        self.value = value
        self.next = next


class Stack:
    def __init__(self):
        self._head = None

    def push(self, item):
        self._head = Node(item, self._head)

    def pop(self):
        if self.is_empty():
            raise Exception("Stack is empty")

        value = self._head.value

        self._head = self._head.next
        return value

    def peek(self):
        if self.is_empty():
            raise Exception("Stack is empty")

        return self._head.value

    def is_empty(self):
        return self._head is None


stack = Stack()

for i in range(1, 18):
    stack.push(i * 100)

while not stack.is_empty():
    print(f"Peek: {stack.peek()}")
    print(f"Pop: {stack.pop()}")

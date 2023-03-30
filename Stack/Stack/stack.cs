using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack
    {
        private Node top;
        private int size;

        protected internal Stack()
        {
            top = null;
            size = 0;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = top;
            top = newNode;
            size++;
        }
        public int Pop()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }

            int value = top.Value;
            top = top.Next;
            size--;
            return value;
        }
        public int Peek()
        {   

            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return top.Value;
        }

        public bool Contains(int value)
        {
            Node current = top;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public int Size()
        {
            return size;
        }

        public int Center()
        {
            if (size % 2 == 0)
            {
                int middleIndex = size / 2;
                Node currentNode = top;
                for (int i = 0; i < middleIndex; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Value;
            }

            Node current = top;
            for (int i = 0; i < size / 2; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        public void Sort()
        {
            if (top == null)
            {
                return;
            }
            Stack tempStack = new Stack();
            while (Size() > 0)
            {
                int temp = Pop();
                while (tempStack.Size() > 0 && tempStack.Peek() > temp)
                {
                    Push(tempStack.Pop());
                }
                tempStack.Push(temp);
            }
            while (tempStack.Size() > 0)
            {
                Push(tempStack.Pop());
            }
        }

        public void Reverse()
        {
            if (top == null)
            {
                return;
            }
            Node current = top;
            Node prev = null;
            while (current != null)
            {
                Node next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            top = prev;
        }

        public void Traverse()
        {
            Node current = top;
            while (current != null)
            {
                Console.Write("{0} ", current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }

       /* public int Centerr()
        {
            if (size % 2 == 0)
            {
                throw new InvalidOperationException("Stack has an even number of elements");
            }
            int middleIndex = size / 2;
            Node currentNode = top;
            for (int i = 0; i < middleIndex; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode.Value;
        }*/
    }
}

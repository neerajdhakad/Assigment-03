using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList 
    {
        private Node head;  
        private int size;

        protected internal LinkedList()
        {
            head = null;
            size = 0;
        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            size++;
        }
        public void InsertAtPosition(int value, int position)
        {
            if (position < 0 || position > size)
            {
                throw new ArgumentOutOfRangeException();
            }
            Node newNode = new Node(value);
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
            size++;
        }

        public void Delete(int value)
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            if (head.data == value)
            {
                head = head.next;
                size--;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == value)
                {
                    current.next = current.next.next;
                    size--;
                    return;
                }
                current = current.next;
            }
            throw new InvalidOperationException();
        }

        public void DeleteAtPosition(int position)
        {
            if (position < 0 || position >= size)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (position == 0)
            {
                head = head.next;
                size--;
                return;
            }
            Node current = head;
            for (int i = 0; i < position - 1; i++)
            {
                current = current.next;
            }
            current.next = current.next.next;
            size--;
        }

        public int Center()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            int mid = size / 2;
            Node current = head;
            for (int i = 0; i < mid; i++)
            {
                current = current.next;
            }
            return current.data;
        }

        public void Sort()
        {
            if (head == null || head.next == null)
            {
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                Node min = current;
                Node inner = current.next;
                while (inner != null)
                {
                    if (inner.data < min.data)
                    {
                        min = inner;
                    }
                    inner = inner.next;
                }
                int temp = current.data;
                current.data = min.data;
                min.data = temp;
                current = current.next;
            }
        }

        public void Reverse()
        {
            if (head == null || head.next == null)
            {
                return;
            }
            Node prev = null;
            Node current = head;
            while (current != null)
            {
                Node next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public int Size()
        {
            return size;
        }

        public void Traverse()
        {
            Node currNode = head;
            while (currNode != null)
            {
                Console.Write(currNode.data + " ");
                currNode = currNode.next;
            }
            Console.WriteLine();
        }
    }
}

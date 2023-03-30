using System;
using System.Collections.Generic;

namespace HashTable
{
    class HashTable
    {
        private readonly int _size;
        private readonly Node[] _nodes;

        public HashTable(int size)
        {
            _size = size;
            _nodes = new Node[_size];
        }

        private int GetIndex(int key)
        {
            return key % _size;
        }

        public void Insert(int key, string value)
        {
            int index = GetIndex(key);
            Node node = new Node(key, value);

            if (_nodes[index] == null)
            {
                _nodes[index] = node;
            }
            else
            {
                Node current = _nodes[index];

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
            }
        }

        public void Delete(int key)
        {
            int index = GetIndex(key);

            if (_nodes[index] == null)
            {
                throw new Exception("Key not found");
            }

            if (_nodes[index].Key == key)
            {
                _nodes[index] = _nodes[index].Next;
                return;
            }

            Node current = _nodes[index];

            while (current.Next != null && current.Next.Key != key)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new Exception("Key not found");
            }

            current.Next = current.Next.Next;
        }

        public bool Contains(int key)
        {
            int index = GetIndex(key);

            if (_nodes[index] == null)
            {
                return false;
            }

            Node current = _nodes[index];

            while (current != null && current.Key != key)
            {
                current = current.Next;
            }

            return current != null;
        }

        public string GetValueByKey(int key)
        {
            int index = GetIndex(key);

            if (_nodes[index] == null)
            {
                throw new Exception("Key not found");
            }

            Node current = _nodes[index];

            while (current != null && current.Key != key)
            {
                current = current.Next;
            }

            if (current == null)
            {
                throw new Exception("Key not found");
            }

            return current.Value;
        }

        public int Size()
        {
            int count = 0;

            for (int i = 0; i < _size; i++)
            {
                if (_nodes[i] != null)
                {
                    Node temp = _nodes[i];
                    while (temp != null)
                    {
                        count++;
                        temp = temp.Next;
                    }
                }
            }
            return count;
        }

        public void Traverse()
        {
            for (int i = 0; i < _size; i++)
            {
                if (_nodes[i] != null)
                {
                    Node temp = _nodes[i];
                    while (temp != null)
                    {
                        Console.WriteLine($"Key: {temp.Key}, Value: {temp.Value}");
                        temp = temp.Next;
                    }
                }
            }
        }
    }
}


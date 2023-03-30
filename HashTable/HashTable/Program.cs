using System;
namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hash = new HashTable(10);
            Hash.Insert(1, "One");
            Hash.Insert(2, "Two");
            Hash.Insert(3, "Three");
            Hash.Insert(4, "Four");
            Hash.Insert(5, "Five");

            Hash.Delete(1);
            Hash.Traverse();

            Console.WriteLine("\nSize of HashTable : " + Hash.Size());
            Console.WriteLine("\nHash Table Contains key 4 ? " + Hash.Contains(4));
            Console.WriteLine("\nValue at key 3 : " + Hash.GetValueByKey(3));
            
            Console.ReadLine();
        }
    }
}

using System;

namespace LinkedList
{   
    class Program : LinkedList
    {
        static void Main(string[] args)
        {
            var LinkedList = new LinkedList();

            LinkedList.Insert(10);
            LinkedList.Insert(20);
            LinkedList.Insert(30);
            LinkedList.Insert(40);
            LinkedList.Insert(50);
            LinkedList.Traverse();

            Console.WriteLine("Size : " + LinkedList.Size());

            LinkedList.InsertAtPosition(100,2);
            LinkedList.Delete(10);
            LinkedList.DeleteAtPosition(3);
            LinkedList.Insert(12);
            LinkedList.Insert(2);

            LinkedList.Sort();
            LinkedList.Traverse();
            Console.WriteLine("Center Element : " + LinkedList.Center());
            //Reverse LinkedList
            LinkedList.Reverse();
            LinkedList.Traverse();

            Console.ReadLine();
        }
    }
}

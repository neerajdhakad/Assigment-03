using System;

namespace Stack
{
    class Program : Stack
    {
        static void Main(string[] args)
        {
            var Stack = new Stack();

            Stack.Push(10);
            Stack.Push(34);
            Stack.Push(23);
            Stack.Push(67);
            Stack.Push(30);
            Stack.Push(65);
            Stack.Push(1);
            Stack.Push(6);
            Stack.Push(23);
            Stack.Traverse();
            
            int poppedValue = Stack.Pop();
            Console.WriteLine("Popped {0} from the stack ", poppedValue);
            Stack.Traverse();

            Console.WriteLine("Stack Contains Element 30 : " + Stack.Contains(30));
            Console.WriteLine("Top Element is  : " + Stack.Peek());

            Console.WriteLine("Center Element is  : " + Stack.Center());
            Console.WriteLine("Reversed Stack :");
            Stack.Reverse();
            Stack.Traverse();

            Console.WriteLine("Stack Size : " + Stack.Size());
            Console.WriteLine("Sorted Stack is : ");
            Stack.Sort();
            Stack.Traverse();

            Console.ReadLine();
        }
    }
}

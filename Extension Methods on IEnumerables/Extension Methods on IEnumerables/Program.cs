using Extension_Methods_on_IEnumerables;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // CustomAll
        bool allEven = numbers.CustomAll(n => n % 2 == 0);
        Console.WriteLine(allEven); // False

        // CustomAny
        bool anyOdd = numbers.CustomAny(n => n % 2 != 0);
        Console.WriteLine(anyOdd); // True

        // CustomMax
        int maxNumber = numbers.CustomMax((a, b) => a.CompareTo(b));
        Console.WriteLine(maxNumber); // 5

        // CustomMin
        int minNumber = numbers.CustomMin((a, b) => a.CompareTo(b));
        Console.WriteLine(minNumber); // 1
    }
}


using System;
using System.Collections.Generic;
namespace Week5.Task5;
class ListDemo
{
    static void Main(string[] args)
    {
        // Creating a List of integers
        List<int> numbers = new List<int>();

        // 1. Adding elements to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // 2. Accessing elements by index
        Console.WriteLine("Element at index 1: " + numbers[1]);

        // 3. Checking if an element exists in the list
        bool flag = numbers.Contains(20);
        Console.WriteLine("List contains 20: " + flag);

        // 4. Removing elements from the list
        numbers.Remove(20);

        // 5. Iterating over the list
        Console.WriteLine("List elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Additional operation: Getting the count of elements
        Console.WriteLine("Number of elements in the list: " + numbers.Count);
    }
}

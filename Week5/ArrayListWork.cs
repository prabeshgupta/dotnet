using System;
using System.Collections;
namespace Week5.Task9;
class ArrayListWork
{
    static void Main(string[] args)
    {
        // Creating an ArrayList to store various data types
        ArrayList list = new ArrayList();

        // 1. Adding elements to the ArrayList
        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);
        list.Add(true);

        // 2. Accessing elements by index
        Console.WriteLine("Element at index 1: " + list[1]);

        // 3. Checking if an element exists in the ArrayList
        bool containsHello = list.Contains("Hello");
        Console.WriteLine("ArrayList contains 'Hello': " + containsHello);

        // 4. Removing an element from the ArrayList
        list.Remove(3.14);

        // 5. Checking the number of elements in the ArrayList
        int count = list.Count;
        Console.WriteLine("Number of elements in the ArrayList: " + count);

        // Additional operation: Iterating over the ArrayList
        Console.WriteLine("Elements in the ArrayList:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

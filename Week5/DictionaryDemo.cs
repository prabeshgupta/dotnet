using System;
using System.Collections.Generic;
namespace Week5.Task8;
class DictionaryDemo
{
    static void Main(string[] args)
    {
        // Creating a dictionary to store age information
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // 1. Adding key-value pairs to the dictionary
        ages["Alice"] = 30;
        ages["Bob"] = 25;
        ages["Charlie"] = 35;

        // 2. Accessing values by key
        Console.WriteLine("Age of Bob: " + ages["Bob"]);

        // 3. Checking if a key exists in the dictionary
        bool containsCharlie = ages.ContainsKey("Charlie");
        Console.WriteLine("Dictionary contains Charlie: " + containsCharlie);

        // 4. Removing a key-value pair from the dictionary
        ages.Remove("Charlie");

        // 5. Checking if the dictionary is empty
        bool isEmpty = ages.Count == 0;
        Console.WriteLine("Dictionary is empty: " + isEmpty);

        // 6. Clearing all key-value pairs from the dictionary
        ages.Clear();
        Console.WriteLine("Cleared all key-value pairs from the dictionary. Count: " + ages.Count);

        // 7. Getting all keys and values from the dictionary
        ages["Alice"] = 30;
        ages["Bob"] = 25;
        ages["Charlie"] = 35;

        Console.WriteLine("All keys in the dictionary:");
        foreach (string key in ages.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("All values in the dictionary:");
        foreach (int value in ages.Values)
        {
            Console.WriteLine(value);
        }

        // 8. Using TryGetValue to safely retrieve a value
        int charlieAge;
        if (ages.TryGetValue("Charlie", out charlieAge))
        {
            Console.WriteLine("Age of Charlie: " + charlieAge);
        }
        else
        {
            Console.WriteLine("Charlie's age is not available.");
        }
    }
}

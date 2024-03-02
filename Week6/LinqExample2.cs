using System;
using System.Linq;
using System.Collections.Generic;

namespace Week6.Task4
{

    class Dog
    {
        public string name { get; set; }
        public int age { get; set; }
    }

    class ObjectWithStringsAndAge
    {
        public List<string> Strings { get; set; }
        public int Age { get; set; }
    }

    class LinqExample2
    {
        public static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>(){
            new Dog {name = "Kaale", age = 2},
            new Dog {name = "Khaire", age = 3},
            new Dog {name = "Setey", age = 4},
            new Dog {name = "Tommy", age = 5},
            new Dog {name = "Monty", age = 7},
        };

            var names = dogs.Select(x => x.name);
            foreach (var dogName in names)
            {
                Console.WriteLine(dogName);
            }

            var sortedDogs = dogs.OrderByDescending(x => x.age);
            foreach (var sorted in sortedDogs)
            {
                Console.WriteLine("Dog {0} is {1} years old. ", sorted.name, sorted.age);
            }



            // Sample data - list of objects with strings and age
            var objects = new List<ObjectWithStringsAndAge>
        {
            new ObjectWithStringsAndAge { Strings = new List<string> { "apple", "banana", "cherry" }, Age = 30 },
            new ObjectWithStringsAndAge { Strings = new List<string> { "date", "elderberry", "fig" }, Age = 25 },
            new ObjectWithStringsAndAge { Strings = new List<string> { "grape", "honeydew", "kiwi" }, Age = 30 }
        };

            // Using SelectMany to flatten the list of strings based on age
            var flattenedStrings = objects.SelectMany(obj => obj.Strings.Select(str => new { Age = obj.Age, String = str }));

            // Output the flattened strings
            Console.WriteLine("Flattened Strings:");
            foreach (var item in flattenedStrings)
            {
                Console.WriteLine($"Age: {item.Age}, String: {item.String}");
            }

            Console.ReadLine();
        }
    }
}
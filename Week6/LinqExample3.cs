using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


namespace Week6.Task5
{

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public int Age { get; set; }
    }
    class LinqExample3
    {
        static void Main(string[] args)
        {
            // Sample data
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var strings = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig" };
            // var strings = new ArrayList() { "apple", "banana", "cherry", "date", "elderberry", "fig", 1, 2 };
            var persons = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 35 },
            new Person { Name = "Carol", Age = 30 },
            new Person { Name = "David", Age = 40 }
        };

            // // Filtering
            // // var filteredNumbers = numbers.Where(n => n % 2 == 0);
            // var filteredNumbers =  from number in numbers where number%3 == 0 select number;
            // Console.WriteLine("Filtered Numbers:");
            // foreach (var num in filteredNumbers)
            // {
            //     Console.WriteLine(num);
            // }
            // Console.WriteLine();

            // var ofTypeStrings = strings.OfType<string>();

            //  foreach (var typeS in ofTypeStrings)
            // {
            //     Console.WriteLine(typeS);
            // }
            // Console.WriteLine();

            // // Sorting
            // var sortedNumbers = numbers.OrderBy(n => n).ThenByDescending(n => n);
            // Console.WriteLine("Sorted Numbers:");
            // foreach (var num in sortedNumbers)
            // {
            //     Console.WriteLine(num);
            // }
            // Console.WriteLine();

            // // Sample data
            // var students = new List<Student>
            // {
            //     new Student { Name = "Alice", Grade = 85, Age = 20 },
            //     new Student { Name = "Bob", Grade = 75, Age = 22 },
            //     new Student { Name = "Carol", Grade = 85, Age = 21 },
            //     new Student { Name = "David", Grade = 90, Age = 19 },
            //     new Student { Name = "Eve", Grade = 75, Age = 20 }
            // };

            // // Sorting first by Grade in ascending order, then by Age in descending order
            // var sortedStudents = students.OrderBy(student => student.Grade)
            //                              .ThenByDescending(student => student.Age);

            // // Display sorted students
            // Console.WriteLine("Sorted Students:");
            // foreach (var student in sortedStudents)
            // {
            //     Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Age: {student.Age}");
            // }

            // Console.ReadLine();

            // // Sample data - list of strings
            // var strings = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig" };

            // // Sorting the strings in descending order based on their length and then reversing the order
            // var reverseSortedStrings = strings.OrderByDescending(s => s.Length).Reverse();

            // // Output the reverse sorted strings
            // Console.WriteLine("Reverse Sorted Strings:");
            // foreach (var str in reverseSortedStrings)
            // {
            //     Console.WriteLine(str);
            // }
            // Grouping
            var groupedPersons = persons.GroupBy(p => p.Age);
            Console.WriteLine("Grouped Persons:");
            foreach (var group in groupedPersons)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
            Console.WriteLine();

            // Creating a lookup based on age
            var ageLookup = persons.ToLookup(p => p.Age);

            // Both methods achieve the same result, but ToLookup creates the lookup structure immediately, providing fast key-based access to elements, while GroupBy defers the grouping operation until it's needed.        Console.WriteLine("Persons grouped by age:");
            foreach (var group in ageLookup)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"- {person.Name}");
                }
            }

            // Join
            var joinedPersons = persons.Join(groupedPersons, p => p.Age, g => g.Key, (p, g) => new { Person = p, Group = g });
            Console.WriteLine("Joined Persons:");
            foreach (var item in joinedPersons)
            {
                Console.WriteLine($"Name: {item.Person.Name}, Age: {item.Person.Age}, Group: {item.Group.Key}");
            }
            Console.WriteLine();

            var groupedJoinedPersons = persons.GroupJoin(groupedPersons, p => p.Age, g => g.Key, (p, g) => new { Person = p, Group = g });

            // Projection
            var projectedNumbers = numbers.Select(n => n * 2);
            Console.WriteLine("Projected Numbers:");
            foreach (var num in projectedNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Aggregation
            var sumOfNumbers = numbers.Sum();
            Console.WriteLine($"Sum of Numbers: {sumOfNumbers}");

            var averageAge = persons.Average(p => p.Age);
            Console.WriteLine($"Average Age: {averageAge}");

            var countOfPersons = persons.Count();
            Console.WriteLine($"Count of Persons: {countOfPersons}");

            var maxValue = numbers.Max();
            Console.WriteLine($"Maximum Value in Numbers: {maxValue}");

            var minAge = persons.Min(p => p.Age);
            Console.WriteLine($"Minimum Age of Persons: {minAge}");
            Console.WriteLine();

            // Quantifiers
            var allNumbersGreaterThanZero = numbers.All(n => n > 0);
            Console.WriteLine($"Are all numbers greater than zero? {allNumbersGreaterThanZero}");

            var anyEvenNumber = numbers.Any(n => n % 2 == 0);
            Console.WriteLine($"Are there any even numbers? {anyEvenNumber}");

            var containsAlice = persons.Select(p => p.Name).Contains("Alice");
            Console.WriteLine($"Does the list contain Alice? {containsAlice}");
            Console.WriteLine();

            // Elements
            var firstNumber = numbers.First();
            Console.WriteLine($"First Number: {firstNumber}");

            var lastString = strings.Last();
            Console.WriteLine($"Last String: {lastString}");

            var singlePersonWithNameJohn = persons.Single(p => p.Name == "John");
            Console.WriteLine($"Single Person with Name John: {singlePersonWithNameJohn.Name}, Age: {singlePersonWithNameJohn.Age}");

            var elementAtThirdPosition = numbers.ElementAt(2);
            Console.WriteLine($"Element at Third Position: {elementAtThirdPosition}");
            Console.WriteLine();

            // Set
            var distinctNumbers = numbers.Distinct();
            Console.WriteLine("Distinct Numbers:");
            foreach (var num in distinctNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            var exceptedNumbers = numbers.Except(new List<int> { 3, 5, 7 });
            Console.WriteLine("Excepted Numbers:");
            foreach (var num in exceptedNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            var intersectedNumbers = numbers.Intersect(new List<int> { 5, 6, 7 });
            Console.WriteLine("Intersected Numbers:");
            foreach (var num in intersectedNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            var unionOfNumbers = numbers.Union(new List<int> { 11, 12, 13 });
            Console.WriteLine("Union of Numbers:");
            foreach (var num in unionOfNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Partitioning
            var skippedNumbers = numbers.Skip(3);
            Console.WriteLine("Skipped Numbers:");
            foreach (var num in skippedNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            var takenWhileLessThanFive = numbers.TakeWhile(n => n < 5);
            Console.WriteLine("Taken While Less Than Five:");
            foreach (var num in takenWhileLessThanFive)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Concatenation
            var concatenatedLists = numbers.Concat(new List<int> { 11, 12, 13 });
            Console.WriteLine("Concatenated Lists:");
            foreach (var num in concatenatedLists)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Equality
            var areEqual = numbers.SequenceEqual(Enumerable.Range(1, 10));
            Console.WriteLine($"Are numbers equal to sequence 1 to 10? {areEqual}");
            Console.WriteLine();

            // Generation
            var emptyCollection = Enumerable.Empty<int>();
            Console.WriteLine("Empty Collection:");
            foreach (var num in emptyCollection)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            var repeatedNumber = Enumerable.Repeat(5, 3);
            Console.WriteLine("Repeated Number:");
            foreach (var num in repeatedNumber)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace Week6.Task3
{

    class LinqExample1
    {
        public static void Main(string[] args)
        {
            //LINQ Query to Array
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
            var shortWords = from word in words where word.Length <= 5 select word;
            foreach (var sword in shortWords)
            {
                Console.WriteLine(sword);
            }

            //LINQ query to List

            List<string> stringList = new List<string>{
            "C# tutorials","Java Tutorials","C tutorials","Learn C++","MVC Tutorials"
        };
            var results = from l in stringList where l.Contains("Learn") select l;
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }


            // Linq Method Syntax

            var lambdaResults = stringList.Where(x => x.Contains("MVC"));
            foreach (var r in lambdaResults)
            {
                Console.WriteLine(r);
            }


            // Linq lambda expression

            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var evenNumbers = intList.Where(x => x % 2 == 0);
            foreach (var eve in evenNumbers)
            {
                Console.WriteLine("{0}", eve);
            }

        }
    }
}
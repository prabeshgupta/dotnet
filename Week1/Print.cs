using System;

namespace Week1
{
    class Print
    {
        static void Main(string[] args)
        {
            int num = 10;
            // First way
            Console.WriteLine("The number is " + num);
            // Second Way
            Console.WriteLine("+1 Addition on number is {0}", (num + 1));
            // Third way
            Console.WriteLine($"Number x 10 is {num * 10}");

        }
    }
}
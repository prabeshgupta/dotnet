using System;

namespace app
{
    class Swapping
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            // Console.WriteLine("Number 1: " + num1);
            // Console.WriteLine("Number 2: " + num2);

            Console.WriteLine("Number 1: {0}\nNumber 2: {1}", num1, num2);

        }
    }
}
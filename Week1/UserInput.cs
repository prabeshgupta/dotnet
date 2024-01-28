using System;

namespace Week1.Task3;
class UserInput
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("Sum is {0}", sum);
    }
}
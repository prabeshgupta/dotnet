using System;

namespace Week3;
class OutKeyword
{
    static void MultiplyByTwo(int input, out int result)
    {
        result = input * 2;
    }

    static void Main(string[] args)
    {
        int number = 5;
        int multipliedNumber;

        MultiplyByTwo(number, out multipliedNumber);

        Console.WriteLine($"Original number: {number}");
        Console.WriteLine($"Multiplied by two: {multipliedNumber}");
    }
}

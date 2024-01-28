using System;
namespace Week2.Task5;
class SumOfInteger
{
    public static void Main(string[] args)
    {
        int temp = 0;
        for (int i = 1; i <= 100; i++)
        {
            temp += i;
        }
        Console.WriteLine(temp);
    }
}
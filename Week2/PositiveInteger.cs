using System;
namespace Week2.Task8;
class PositiveInteger
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num;
        do
        {
            num = Convert.ToInt32(Console.ReadLine());
        } while (num < 0);
    }
}
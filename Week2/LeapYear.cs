using System;

namespace Week2.Task2;

class LeapYear
{
    public static void Main(string[] args)
    {
        bool date = DateTime.IsLeapYear(DateTime.Now.Year);
        if (date)
        {
            Console.WriteLine("Leap year");
        }
        else
        {
            Console.WriteLine("Not leap year");
        }
    }
}
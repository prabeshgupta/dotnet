using System;
namespace Week2.Task4;

class Day
{
    public static void Main(string[] args)
    {
        DayOfWeek day = DateTime.Now.DayOfWeek;
        switch (day)
        {
            case DayOfWeek.Saturday:
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("Weekday");
                break;
        }

    }
}
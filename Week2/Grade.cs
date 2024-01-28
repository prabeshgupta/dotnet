using System;
namespace Week2.Task3;
class Grade
{
    public static void Main(string[] args)
    {
        char grade = 'B';

        if (grade == 'A')
        {
            Console.WriteLine("A Grade");
        }
        else if (grade == 'B')
        {
            Console.WriteLine("B Grade");
        }
        else if (grade == 'C')
        {
            Console.WriteLine("C Grade");

        }
        else if (grade == 'D')
        {
            Console.WriteLine("D Grade");
        }
        else
        {
            Console.WriteLine("E Grade");
        }
    }
}
using System;
namespace Week2.Task7;
class GuessGame
{
    public static void Main(string[] args)
    {
        Random ran = new Random();
        int gen = ran.Next(1, 10);
        int num;
        Console.WriteLine("Guess the number");
        do
        {
            num = Convert.ToInt32(Console.ReadLine());
        } while (num != gen);
        Console.WriteLine("Number matched");
    }
}
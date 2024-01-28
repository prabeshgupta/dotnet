using System;
namespace Week2.Task6;
class Fruit
{
    public static void Main(string[] args)
    {
        string[] fruits = new string[4] { "Strawberry", "Syau", "Naspati", "Kera" };
        foreach (var item in fruits)
        {
            Console.Write(item + " ");
        }
    }
}
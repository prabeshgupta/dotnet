using System;

namespace Week1.Task1;
class Swapping
{
    public static void Main(string[] args)
    {
        int num1 = 6;
        int num2 = 8;

        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;

        Console.WriteLine("num1:{0}\nnum2:{1}", num1, num2);

    }
}
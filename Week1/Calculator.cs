using System;

namespace app
{
    class Calculator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Arithmetic operator");
            char arithmetic = Convert.ToChar(Console.ReadLine());

            switch (arithmetic)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine((float)num1 / num2);
                    break;
                default:
                    break;
            }
        }
    }
}
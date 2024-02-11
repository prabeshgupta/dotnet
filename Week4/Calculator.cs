using System;
namespace Week4.Task2
{
    public class Calculator
    {
        // Addition
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtraction
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Division
        public int Divide(int a, int b)
        {
            return a / b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            // Integer Operations
            Console.WriteLine("Enter two integers for integer operations:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = calculator.Add(num1, num2);
            int difference = calculator.Subtract(num1, num2);
            int product = calculator.Multiply(num1, num2);
            int quotient = calculator.Divide(num1, num2);

            Console.WriteLine($"Integer Sum: {sum}");
            Console.WriteLine($"Integer Difference: {difference}");
            Console.WriteLine($"Integer Product: {product}");
            Console.WriteLine($"Integer Quotient: {quotient}");

            // Double Operations
            Console.WriteLine("Enter two doubles for double operations:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());

            double doubleSum = calculator.Add(num3, num4);
            double doubleDifference = calculator.Subtract(num3, num4);
            double doubleProduct = calculator.Multiply(num3, num4);
            double doubleQuotient = calculator.Divide(num3, num4);

            Console.WriteLine($"Double Sum: {doubleSum}");
            Console.WriteLine($"Double Difference: {doubleDifference}");
            Console.WriteLine($"Double Product: {doubleProduct}");
            Console.WriteLine($"Double Quotient: {doubleQuotient}");
        }
    }
}
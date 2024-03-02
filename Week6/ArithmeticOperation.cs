using System;

namespace Week6.Task1
{
    class ArithmeticOperation
    {
        // Delegate for arithmetic operations
        delegate double Operation(double num1, double num2);

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = Convert.ToInt32(Console.ReadLine());

                // Delegate instance for arithmetic operations
                Operation operation = null;

                switch (choice)
                {
                    case 1:
                        operation = (x, y) => x + y;
                        break;
                    case 2:
                        operation = (x, y) => x - y;
                        break;
                    case 3:
                        operation = (x, y) => x * y;
                        break;
                    case 4:
                        operation = (x, y) =>
                        {
                            if (y == 0)
                            {
                                throw new DivideByZeroException("Cannot divide by zero.");
                            }
                            return x / y;
                        };
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                // Method to perform arithmetic operations
                Calculate(num1, num2, operation);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numbers only.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Method to perform arithmetic operations
        static void Calculate(double num1, double num2, Operation operation)
        {
            Console.WriteLine("Result: " + operation(num1, num2));
        }
    }
}

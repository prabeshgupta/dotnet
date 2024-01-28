using System;
namespace Week2.Task9;
public class PrimeNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter the start of the range: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the end of the range: ");
        int end = Convert.ToInt32(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && i != 1)
            {
                Console.Write(i + " ");
                break;
            }
        }
    }
}
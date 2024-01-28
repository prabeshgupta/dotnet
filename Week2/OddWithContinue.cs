using System;
namespace Week2.Task10;
class OddWithContinue
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
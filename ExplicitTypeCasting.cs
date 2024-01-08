using System;

namespace app
{
    internal class ExplicitTypeCasting
    {
        static void Main(string[] args)
        {
            int num1 = 33;
            int num2 = 4;

            float num3 = (float)num1 / num2;
            Console.WriteLine(num3);
        }
    }
}
using System;

namespace app
{
    internal class ImplicitTypeCasting
    {
        static void Main(string[] args)
        {
            int yr = 2024;
            string year = yr.ToString();

            Console.WriteLine(year.GetType());
        }
    }
}
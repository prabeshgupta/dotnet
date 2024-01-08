// Rectangle array is also called multidimensional array

using System;

namespace app
{
    internal class RectangleArray
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[2, 2] {
                {1,3},
                {2,3}
            };

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

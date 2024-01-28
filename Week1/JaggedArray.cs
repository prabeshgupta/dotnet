using System;

namespace Week1.Task4;

class JaggedArray
{
    public static void Main(string[] args)
    {
        int[][] nums = new int[3][];
        nums[0] = new int[] { 1, 2, 5 };
        nums[1] = new int[] { 64, 46, 44 };
        nums[2] = new int[] { 3, 6, 63 };
        foreach (var item in nums)
        {
            foreach (var element in item)
            {
                Console.Write(element + " ");

            }
            Console.WriteLine();
        }

    }
}
using System;

namespace Week1.Task2;
class LargestElement
{
    public static void Main(string[] args)
    {
        int[] nums = new int[] { 1, 5, 2, 9, 3 };
        int temp;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }

        Console.WriteLine("Largest Element in array:{0}", nums[nums.Length - 1]);
    }
}
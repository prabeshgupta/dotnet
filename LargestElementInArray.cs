using System;

namespace app
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 4, 5, 32, 23, 3 };
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
            Console.WriteLine("Largest Element in Array is " + nums[nums.Length - 1]);
        }
    }
}
using System;

namespace app
{
    internal class Array
    {
        static void Main(string[] args)
        {
            double[] nums = new double[3];
            nums[0] = 3.2323;
            nums[1] = 3.2322234;
            nums[2] = 5.45334;

            // double[] nums = {3.2323,3.2322234}

            // double[] nums = new double[] {3.2323,3.2322234}

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
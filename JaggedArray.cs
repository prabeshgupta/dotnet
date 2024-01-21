// A jagged array is an array of arrays in C#. It is an array whose elements are arrays, and the length of each array index can differ. The elements of a jagged array can be of different dimensions and sizes. 

using System;

namespace app
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jagged_array = new int[2][];
            jagged_array[0] = new int[] { 1, 2, 3, 4, 5 };
            jagged_array[1] = new int[] { 3, 3, 5, 6, 4, 6, 3 };

            foreach (var array in jagged_array)
            {
                foreach (var elements in array)
                {
                    Console.Write(elements + " ");
                }
                Console.WriteLine();
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            int[] nums = new int[9];
            Console.WriteLine("Please enter 9 numbers: "); // Ask the user to enter 9 integers
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums); // Sort the array in ascending order

            int[] distinct = new int[nums.Length]; // Create a new array to store the distinct values
            int j = 0;

            for (int i = 0; i < nums.Length; ++i) // Loop through the sorted array and find the last index of each distinct value
            {
                int res = Array.FindLastIndex(nums, x => x == nums[i]);

                if (res == i) // If the last index of a value is equal to the current index, it is distinct
                {
                    distinct[j++] = nums[i];
                }
                else // Otherwise, skip over the values that are the same
                {
                    i = res;
                }
            }
            Array.Resize(ref distinct, j); // Resize the distinct array to only include the distinct values

            Console.Write("["); // Print out the distinct values
            foreach (int i in distinct)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("]");




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[9];
            Console.WriteLine("Please enter 9 numbers: ");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);
            int[] distinct = new int[nums.Length];
            int j = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                int res = Array.FindLastIndex(nums, x => x == nums[i]);
                if (res == i)
                {
                    distinct[j++] = nums[i];
                }
                else
                {
                    i = res;
                }
            }
            Array.Resize(ref distinct, j);
            Console.Write("[");
            foreach (int i in distinct)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("]");




        }
    }
}

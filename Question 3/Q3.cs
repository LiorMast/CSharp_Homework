using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 0, 1, 2, -1, 4, -3 };

            int[,] arr2 = new int[arr.Length* arr.Length* arr.Length, 3]; //Create two-dim array to hold all the triplets
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
                for (int j = i+1; j < arr.Length; j++)
                    for (int k = j+1; k < arr.Length; k++)  // Nested loops iterate through all possible combinations of three integers from the "arr" array
                    {
                        if (arr[i] + arr[j] + arr[k]==0) // If the sum of three integers is equal to zero, store those integers in the "arr2" array and increment the "count" variable

                        {
                                arr2[count,0] = arr[i];
                                arr2[count, 1] = arr[j];
                                arr2[count, 2] = arr[k];
                                count++;
                            }
                    }
            arr2 = resize2dArray(arr2, count, 3); // Resize the "arr2" array to the exact size needed to fit all the valid combinations found
            print2dArr(arr2); // Print out the valid combinations of three integers whose sum is zero
        }

        // Method to print out a two-dimensional integer array
        static void print2dArr(int[,] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
                count++;
                if (count == arr.GetLength(1)) //Drop down a line when you finish a row
                {
                    Console.WriteLine("");
                    count = 0;
                }
            }
        }

        // Method to resize a two-dimensional integer array
        static int[,] resize2dArray(int[,] arr, int row, int col)
        {
            int[,] newarr = new int[row, col];  // Create a new two-dimensional integer array with the dimensions of (row, col)
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    newarr[i, j] = arr[i, j]; // Copy the valid combinations from the old "arr2" array to the new "newarr" array
                }
            }
            return newarr; // Return the new two-dimensional integer array
        }
    }
}

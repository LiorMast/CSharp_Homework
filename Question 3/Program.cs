using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 0, 1, 2, -1, 4, -3 };

            int[,] arr2 = new int[arr.Length* arr.Length* arr.Length, 3];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
                for (int j = i+1; j < arr.Length; j++)
                    for (int k = j+1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k]==0)
                        
                            {
                                arr2[count,0] = arr[i];
                                arr2[count, 1] = arr[j];
                                arr2[count, 2] = arr[k];
                                count++;
                            }
                    }
            arr2 = resize2dArray(arr2, count, 3);
            print2dArr(arr2);
        }

        static void print2dArr(int[,] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
                count++;
                if (count == arr.GetLength(1))
                {
                    Console.WriteLine("");
                    count = 0;
                }
            }
        }

        static int[,] resize2dArray(int[,] arr, int row, int col)
        {
            int[,] newarr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    newarr[i, j] = arr[i, j];
                }
            }
            return newarr;
        }
    }
}

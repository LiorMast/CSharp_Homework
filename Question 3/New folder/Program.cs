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
            int[] arr = {-1,0,1,2,-1,4,-3 };
            //int[] arr = { 1, 1, 1, 1, 1, 1, 1 ,1,1,1,1,1,1};
            int[,] arr2 = new int[arr.Length* arr.Length* arr.Length, 3];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
                for (int j = i+1; j < arr.Length; j++)
                    for (int k = j+1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k]==3)
                            {
                                arr2[count,0] = arr[i];
                                arr2[count, 1] = arr[j];
                                arr2[count, 2] = arr[k];
                            count++;
                            }
                    }
            //Console.WriteLine(arr2.GetLength(0));
            //Console.WriteLine(arr2.GetLength(1));
            Console.WriteLine(count);
            int[,] res = resize2dArray(arr2 ,count, 3);
            //print2dArr(res);
            prtarr(arr2);

        }

        static int[,] resize2dArray(int[,] arr, int row, int col)
        {
            int[,] newarr = new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    newarr[i, j] = arr[i, j];
                }
            }
            return newarr;
        }
        static void print2dArr(int[,] arr)
        {
            for(int i = 0;i < arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine("");
            }
        }

        static void prtarr(int[,] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
                count++;
                if (count == 3)
                {
                    Console.WriteLine("");
                    count = 0;
                }
            }
        }
    }
}

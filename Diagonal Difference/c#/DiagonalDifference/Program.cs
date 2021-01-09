using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    public class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int result = 0;
            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                rightSum += arr[i][i];
            }
            int j = arr.Count() - 1;

            for (int i = 0; i < arr.Count(); i++)
            {
                leftSum += arr[i][j];
                j--;
            }
            result = rightSum - leftSum;

            if (leftSum > rightSum)
            {
                return (-1) * result;
            }
            return result;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            int result = Result.diagonalDifference(arr);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

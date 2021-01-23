using System;
namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {

            double negativeCount = 0;
            double positiveCount = 0;
            double zeroCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            double denominator = Math.Pow(arr.Length, -1);
            Console.WriteLine((positiveCount * denominator).ToString("0.#####0"));
            Console.WriteLine((negativeCount * denominator).ToString("0.#####0"));
            Console.WriteLine((zeroCount * denominator).ToString("0.#####0"));
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            
            plusMinus(arr);
        }
    }
}


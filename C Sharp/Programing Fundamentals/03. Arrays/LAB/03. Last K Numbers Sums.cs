using System;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                int start = Math.Max(0, i - k); ;
                int end = i - 1;
                long sum = 0;
                for (int j = start; j <= end; j++)
                {
                    sum += arr[j];
                }
                arr[i] = sum;


            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            
        }

    }

}

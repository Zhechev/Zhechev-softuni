using System;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int[] arr = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

            


            while (arr.Length >1)
            {
                int[] arrSum = new int[arr.Length - 1];
                for (int i = 0; i < arr.Length-1; i++)
                {
                    arrSum[i] = arr[i] + arr[i + 1];
                }
                arr = arrSum;

            }

            Console.WriteLine(arr[0]);


        }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int[] inputNums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool flag = true;

            for (int i = 0; i < inputNums.Length; i++)
            {
                for (int l = 0; l < i; l++)
                {
                    leftSum += inputNums[l];
                }
                for (int m = i+1; m <inputNums.Length; m++)
                {
                    rightSum += inputNums[m];
                }
                if (leftSum == rightSum)
                {
                    flag = false;
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }

            }
            if (flag)
            {
                Console.WriteLine("no");
            }

        }
    }
}










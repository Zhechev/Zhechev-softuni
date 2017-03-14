using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int[] inputNums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < inputNums.Length - 1; i++)
            {

                for (int L = i; L < inputNums.Length; L++)
                {
                    int diff = Math.Abs(inputNums[i] - inputNums[L]);
                    if (diff == k)
                    {
                        count++;
                    }

                }
            }


                Console.WriteLine(count);
           
        }
    }
}










using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            List<int> inputNumbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[inputNumbers.Count];

            for (int i = 0; i < k; i++)
            {
                int lastElement = inputNumbers[inputNumbers.Count - 1];
                for (int j = inputNumbers.Count-1; j > 0; j--)
                {
                    inputNumbers[j] = inputNumbers[j - 1];
                }

                inputNumbers[0] = lastElement;
                for (int m = 0; m < inputNumbers.Count; m++)
                {
                    sum[m] += inputNumbers[m];
                }
               
            
            }
            Console.WriteLine(string.Join(" ", sum));




        }

    }

}




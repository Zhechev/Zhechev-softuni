using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            List <int> inputNums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int currentSequence = 1;
            int longestSequence = 1;
           int  mostFreequentNum = inputNums[0];

            for (int i = 0; i < inputNums.Count-1; i++)
            {
                if (inputNums[i] == inputNums[i + 1])
                {
                    currentSequence++;

                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        mostFreequentNum = inputNums[i];
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }
            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write(mostFreequentNum + " ");
            }
        }

    }

}




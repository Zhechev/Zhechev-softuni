using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            List<string> firstRow = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> secondRow = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int maxLength = firstRow.Count > secondRow.Count ? secondRow.Count : firstRow.Count;
            int counterLeftToRight = 0;
            int counterRightToLeft = 0;

            for (int i = 0; i <maxLength; i++)
            {
                if (firstRow[i] == secondRow[i])
                {
                    counterLeftToRight++;
                }
            }

            for (int i = 0; i <maxLength; i++)
            {
               if (firstRow[firstRow.Count - 1 - i] == secondRow[secondRow.Count - 1 - i])
                {
                    counterRightToLeft++;
                }
            }

            Console.WriteLine(counterLeftToRight > counterRightToLeft ? counterLeftToRight : counterRightToLeft);

        }

    }

}




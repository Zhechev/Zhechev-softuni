using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int[] inputNumber = Console.ReadLine()
                                .Split(new[] { " " }, StringSplitOptions
                                .RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int k = inputNumber.Length / 4;
            int[] firstElements = new int[k];
            int[] middleElements = new int[k * 2];
            int[] LastElements = new int[k];
            for (int i = 0; i < inputNumber.Length; i++)
            {
                for (int m = 0; m < middleElements.Length; m++)
                {
                    middleElements[m] = inputNumber[m + k];
                }

                for (int f = 0; f < firstElements.Length; f++)
                {
                    firstElements[f] = inputNumber[f];
                }

                for (int l = 0; l < LastElements.Length; l++)
                {
                    LastElements[l] = inputNumber[l + 3 * k]; 
                }
                Array.Reverse(firstElements);
                Array.Reverse(LastElements);             
            }

            int[] SumFirstAndLastEelemnts = new int[k * 2];

            for (int i = 0; i <SumFirstAndLastEelemnts.Length; i++)
            {
                 if (i < k)
                {
                    SumFirstAndLastEelemnts[i] = firstElements[i];
                }
                 else
                {
                    SumFirstAndLastEelemnts[i] = LastElements[i - k];
                }
            }

            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] += SumFirstAndLastEelemnts[i];
            }

            Console.WriteLine(string.Join(" ", middleElements));

        }

    }

}




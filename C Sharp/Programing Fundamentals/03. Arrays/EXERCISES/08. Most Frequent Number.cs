using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int[] arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int resultNumber = 0;
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int tempCounter = 0;
                foreach (var number in arr)
                {
                    if (arr[i] == number)
                    {
                        tempCounter++;
                    }
                }

                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    resultNumber = arr[i];
                }

            }

            Console.WriteLine(resultNumber);
        }
    }
}










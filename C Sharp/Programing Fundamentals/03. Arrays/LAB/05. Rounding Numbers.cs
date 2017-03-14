using System;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            double[] arr = Console.ReadLine()
               .Split(' ')
               .Select(double.Parse)
               .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " => " + Math.Round(arr[i], MidpointRounding.AwayFromZero));
                 
            }

        }
    }

}

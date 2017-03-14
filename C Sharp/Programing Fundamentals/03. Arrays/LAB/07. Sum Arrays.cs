using System;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int[] firstArr = Console.ReadLine()
                     .Split(' ')
                     .Select(int.Parse)
                     .ToArray();

            int[] secondArr = Console.ReadLine()
                              .Split(' ')
                              .Select(int.Parse)
                              .ToArray();

            int[] arrSum = new int[firstArr.Length > secondArr.Length ? firstArr.Length : secondArr.Length];

            for (int i = 0; i < arrSum.Length; i++)
            {
                arrSum[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }

            Console.WriteLine(string.Join(" ", arrSum));



        }


    }

}

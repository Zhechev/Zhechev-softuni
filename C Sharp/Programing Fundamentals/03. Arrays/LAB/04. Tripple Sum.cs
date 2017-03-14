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

            bool flag = true;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];

                    if (arr.Contains(sum))
                    {
                        flag = false;
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("No");
            }
            
        }

    }

}

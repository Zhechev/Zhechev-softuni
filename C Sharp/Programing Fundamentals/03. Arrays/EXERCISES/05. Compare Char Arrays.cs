using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            char[] arr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int length = arr.Length > arr2.Length ? arr2.Length : arr.Length;
            bool areEqual = false;

            for (int i = 0; i <length ; i++)
            {
                if (arr[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    if (arr[i] < arr2[i])
                    {
                        Console.WriteLine(arr);
                        Console.WriteLine(arr2);
                    }
                    else
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr);
                    }
                    areEqual = true;
                    break;
                }
            }

            if (areEqual != true)
            {
                if (arr.Length <= arr2.Length)
                {
                    Console.WriteLine(arr);
                    Console.WriteLine(arr2);
                }
                else
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr);
                }
            }
            
        }


    }

}





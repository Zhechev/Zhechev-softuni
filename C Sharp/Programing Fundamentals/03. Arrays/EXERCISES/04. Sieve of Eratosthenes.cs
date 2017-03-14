using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());

            bool[] arr = new bool[n+1];

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    for (int l = i + i; l < arr.Length; l += i)
                    {
                        arr[l] = false;
                    }
                }
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write(i + " ");
                }
                
            }
            Console.WriteLine();

        }


    }

}





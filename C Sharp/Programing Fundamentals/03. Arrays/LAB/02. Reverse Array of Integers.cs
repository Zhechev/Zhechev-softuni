using System;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int tmpp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length/2; i++)
            {
                tmpp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmpp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
               
            
        }
        

    }

}

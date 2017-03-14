using System;
using System.Collections.Generic;
using System.Linq;

class InstructionSet_broken
{
    static void Main()
    {
        {
            int[] arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int vremennaPosledovatelnost = 0;
            int startovaVremennaPosledovatelnost = 0;
            int maximalnaPosledovatelnost = 0;
            int startovaMaximalnaPosledovatelnost = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] >= 1)
                {
                    vremennaPosledovatelnost++;
                    startovaVremennaPosledovatelnost = i - vremennaPosledovatelnost;
                    if (vremennaPosledovatelnost > maximalnaPosledovatelnost)
                    {
                        maximalnaPosledovatelnost = vremennaPosledovatelnost;
                        startovaMaximalnaPosledovatelnost = startovaVremennaPosledovatelnost;
                    }
                }
                else
                {
                    vremennaPosledovatelnost = 0;
                }
            }
            for (int i = startovaMaximalnaPosledovatelnost; i <= startovaMaximalnaPosledovatelnost+maximalnaPosledovatelnost; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();



        }
    }
}










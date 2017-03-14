using System;


namespace ChristmasThree
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i <=input; i++)
            {
                for (int j = 0; j <input - i; j++)
                {
                    Console.Write(' ');
                }
                for (int s = 0; s < i; s++)
                {
                    Console.Write('*');
                }
                Console.Write(" | ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();


            }


        }
    }
}









using System;


namespace TEST_DRAW_LOOPS
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+ ");

            for (int f = 0; f < n-2; f++)
            {
                Console.Write("- "); 
            }
            Console.WriteLine("+ ");

            for (int row = 0; row < n-2; row++)
            {
                Console.Write("|");
                for (int col = 0; col < n-2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }


            Console.Write("+ ");

            for (int s = 0; s < n-2; s++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
        }
    }
}

using System;


namespace Rectangle_of_10x10_Stars
{
    class Program
    {
        static void Main()
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}

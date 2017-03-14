using System;


namespace Sunglasess
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', input*2) + new string(' ', input) +
                new string('*',input*2));
            for (int i = 0; i < input - 2; i++)
            {
                Console.Write('*');
                for (int j = 0; j < input *2 - 2; j++)
                {
                    Console.Write('/');
                }
                Console.Write('*');
                if (i == (input - 1) / 2 - 1)
                {
                    Console.Write(new string('|', input));
                }
                else {
                    Console.Write(new string(' ', input));
                }
                Console.Write('*');
                for (int j = 0; j < input * 2 - 2; j++)
                {
                    Console.Write('/');
                }
                Console.Write('*');
                Console.WriteLine();
                
            }
            Console.WriteLine(new string('*', input * 2) + new string(' ', input) +
               new string('*', input * 2));
        }
    }
}









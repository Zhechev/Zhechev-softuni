using System;


namespace Equal_Words
{
    class Program
    {
        static void Main()
        {
            var wordOne = Console.ReadLine().ToLower();
            var wordTwo = Console.ReadLine().ToLower();
            if (wordOne == wordTwo)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}

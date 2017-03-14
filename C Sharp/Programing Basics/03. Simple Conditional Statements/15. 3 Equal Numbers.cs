using System;


namespace Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            var word1 = Console.ReadLine();
            var word2 = Console.ReadLine();
            var word3 = Console.ReadLine();

            if (word1 == word2 && word1 == word3)
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

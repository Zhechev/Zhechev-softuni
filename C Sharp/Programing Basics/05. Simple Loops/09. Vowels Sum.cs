using System;


namespace P9.Vowels_Sum
{
    class Program
    {
        static void Main()
        {
            var letter = Console.ReadLine();
            var totalSum = 0;
            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] == 'a')
                {
                    totalSum = totalSum + 1;
                }
                else if (letter[i] == 'e')
                {
                    totalSum = totalSum + 2;
                }
                else if (letter[i] == 'i')
                {
                    totalSum = totalSum + 3;
                }
                else if (letter[i] == 'o')
                {
                    totalSum = totalSum + 4;
                }
                else if (letter[i] == 'u')
                {
                    totalSum = totalSum + 5;
                }
                Console.WriteLine(totalSum);

            }

        }
    }
}

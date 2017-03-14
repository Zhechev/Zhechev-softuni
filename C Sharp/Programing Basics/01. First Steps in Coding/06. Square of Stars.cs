using System;

class SquareofStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string stars = new string('*', n);
        Console.WriteLine(stars);

        for (int i = 1; i <= n - 2; i++)
        {
            string stars1 = "*" + new string(' ', n - 2) + "*";
            Console.WriteLine(stars1);
        }
        stars = new string('*', n);
        Console.WriteLine(stars);
    }
}
